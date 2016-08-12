using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;

public partial class frmMain : Form
{
    [STAThread]
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    //public Variable Definitions
    private bool sortNum = false;
    private bool sortNumLow = false;
    private bool sortNumHigh = true;
    private bool sortWord = false;
    private bool sortWordAsc = false;
    private bool sortWordDesc = false;

    string fileName = "";

    ArrayList badChars;
    ArrayList foundTerms;
    ArrayList foundUniqueTerms;
    ArrayList badTerms;
    ArrayList searchTerms;
    ArrayList listBoxItems;
    ArrayList sentences;
    ArrayList paragraphs;

    public frmMain()
    {
        InitializeComponent();
    }

    //Buttons

    private void btnAnalyze_Click(object sender, EventArgs e)
    {
        string rawData = txtInput.Text;

        foundTerms.Clear();
        foundUniqueTerms.Clear();
        
        #region TermLocation
        sentences = new ArrayList();
        paragraphs = new ArrayList();

        if (rawData.Trim() == "")
        {
            ShowMessage("Please provide text for user input.");
            txtInput.Focus();
            return;
        }

        string[] p = rawData.Split('\n');

        int sNum = 0;
        int pNum = 0;

        foreach (string para in p)
        {
            paragraphs.Add(para);
            
            string[] s = Regex.Split(para, @"(?<=[\.!\?])\s+"); // Courtesy: http://stackoverflow.com/questions/4957226/split-text-into-sentences-in-c-sharp

            foreach (string sent in s)
            {
                sentences.Add(sent);
                
                string[] rawTerms = sent.Split(' ');

                foreach (string term in rawTerms)
                {
                    if (CheckLength(term))
                    {
                        string word = RemoveEncapsulation(term);
                        string tWord = term;

                        while (word != tWord)
                        {
                            tWord = word;
                            word = RemoveEncapsulation(word);
                        }

                        word = NormalizeTerm(word);

                        if (!CompareTerm(word, sNum, pNum))
                        {
                            clsFoundTerm temp = new clsFoundTerm(word,sNum,pNum);
                            foundUniqueTerms.Add(temp);
                        }
                    }
                }

                sNum++;
            }

            pNum++;
        }
#endregion
        
        #region TermCount
        rawData = RemoveNewLineChars(rawData);

        string[] rawTerm = rawData.Split(' ');

        foreach (string term in rawTerm)
        {
            if (CheckLength(term))
            {
                string word = RemoveEncapsulation(term);
                string tWord = term;

                while (word != tWord)
                {
                    tWord = word;
                    word = RemoveEncapsulation(word);
                }

                word = NormalizeTerm(word);

                if (!CompareTerm(word))
                {
                    clsFoundTerm temp = new clsFoundTerm(word);
                    foundTerms.Add(temp);
                }
            }
        }
        #endregion

        listBoxItems = foundTerms;

        DisplayOutput();

        btnSearch.Enabled = true;
        btnAddTerm.Enabled = true;
        btnRemoveTerm.Enabled = true;
        btnAnalyze.Enabled = false;

        txtInput.Clear();
    }

    private void btnWordContext_Click(object sender, EventArgs e)
    {
        if (lstBigDataOutput.SelectedIndex == -1)
        {
            ShowMessage("Please Select a Term");
            return;
        }
        
        btnWordContext.Enabled = false;

        string word = (string)lstBigDataOutput.Items[lstBigDataOutput.SelectedIndex];

        word = word.Substring(0, word.IndexOf(' '));

        clsFoundTerm sTerm = new clsFoundTerm();

        foreach (clsFoundTerm term in foundTerms)
        {
            if (term.Term == word)
            {
                sTerm = term;
                break;
            }
        }

        ArrayList fTerms = new ArrayList();

        foreach (clsFoundTerm term in foundUniqueTerms)
        {
            if (term.Term == sTerm.Term)
            {
                fTerms.Add(term);
            }
        }

        foreach (clsFoundTerm term in fTerms)
        {
            lstWordContext.Items.Add((string)sentences[term.SentNum]);
        }
    }

    private void btnAddTerm_Click(object sender, EventArgs e)
    {
        bool isListed = false;
        
        if (lstBigDataOutput.SelectedIndex == -1)
        {
            ShowMessage("Please Select a Term");
            return;
        }

        string word = (string)lstBigDataOutput.Items[lstBigDataOutput.SelectedIndex];

        word = word.Substring(0, word.IndexOf(' '));

        clsFoundTerm sTerm = new clsFoundTerm();

        foreach (clsFoundTerm term in foundTerms)
        {
            if (term.Term == word)
            {
                sTerm = term;
                break;
            }
        }

        foreach (string term in searchTerms)
        {
            if (sTerm.Term == term)
            {
                isListed = true;
                break;
            }
        }

        if (!isListed)
        {
            searchTerms.Add(sTerm.Term);
        }
    }

    private void btnRemoveTerm_Click(object sender, EventArgs e)
    {
        bool isListed = false;
        
        if (lstBigDataOutput.SelectedIndex == -1)
        {
            ShowMessage("Please Select a Term");
            return;
        }

        string word = (string)lstBigDataOutput.Items[lstBigDataOutput.SelectedIndex];

        word = word.Substring(0, word.IndexOf(' '));

        clsFoundTerm sTerm = new clsFoundTerm();

        foreach (clsFoundTerm term in foundTerms)
        {
            if (term.Term == word)
            {
                sTerm = term;
                break;
            }
        }

        foreach (string term in badTerms)
        {
            if (sTerm.Term == term)
            {
                isListed = true;
                break;
            }
        }

        if (!isListed)
        {
            badTerms.Add(sTerm.Term);
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string sTerm = txtInput.Text.Trim();
        string tempTerms = sTerm;
        int numItems = 0;

        ArrayList sTerms = new ArrayList();
        ArrayList fTerms = new ArrayList();

        if (sTerm.IndexOf(' ') == -1)
        {
            foreach (clsFoundTerm item in foundTerms)
            {
                if (sTerm == item.Term)
                {
                    lstWordContext.Items.Add(item.Term + ":" + item.Count);
                    numItems = item.Count;
                    break;
                }
            }
            ShowMessage("There were " + numItems.ToString() + " matches.");

            return;
        }

        while (tempTerms.IndexOf(' ') != -1)
        {
            sTerms.Add(tempTerms.Substring(0, tempTerms.IndexOf(' ')));
            tempTerms = tempTerms.Substring(tempTerms.IndexOf(' ') + 1);
        }

        sTerms.Add(tempTerms);

        foreach (string term in sTerms)
        {
            int cNum = numItems;

            foreach (clsFoundTerm item in foundTerms)
            {
                if (term == item.Term)
                {
                    fTerms.Add(item);
                    numItems += item.Count;
                    break;
                }
            }
        }

        foreach (clsFoundTerm item in fTerms)
        {
            lstWordContext.Items.Add(item.Term + ":" + item.Count);
        }

        ShowMessage("There were " + numItems.ToString() + " matches.");

        txtInput.Clear();
        txtInput.Focus();
    }

    //Menus

    private void mnuOpen_Click(object sender, EventArgs e) //ugh Why VisualStudio Why? 
    {
        //BadCode Ugh Why?
    } //ugh Why VisualStudio Why? 

    private void mnuSaveDefault_Click(object sender, EventArgs e)
    {
        dataSave(txtInput.Text, "Original");
        dataSave(BuildOutput(lstBigDataOutput), "Analysis");
        dataSave(BuildOutput(lstWordContext), "Context");
    }

    private void mnuSaveContext_Click(object sender, EventArgs e)
    {
        dataSave(BuildOutput(lstWordContext), "Context");
    }

    private void mnuSaveOriginal_Click(object sender, EventArgs e)
    {
        dataSave(txtInput.Text, "Original");
    }

    private void mnuSaveAnalysis_Click(object sender, EventArgs e)
    {
        dataSave(BuildOutput(lstBigDataOutput), "Analysis");
    }

    private void mnuExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void mnuHowTo_Click(object sender, EventArgs e)
    {
        string lineOne = "The Application first needs some kind of text to analyze. This can either be pasted into the main text box or as a text file by going through 'File' -> 'Open'.";

        string lineTwo = "Once done, the user can then use the various funtions. 'Sort Number' will alternate the order shown based on count. 'Sort Word' does much the same, but Alphabetically. 'Isolate Word' pulls the sentence(s) that the word appears in and loads it in the bottom list box. 'Focus Word' will modify the original content by throwing triple quotes around whatever instances of a word you select in the right list box. The menu bar has more functionality. The 'View' Tab lets you show the 'top' count based on the current count sort and limit the number of shown results in the right list box.";

        string lineThree = "When done, the user can save whatever they want. Through 'File', 'Save' will do the default save, which saves all three options. 'Save Original' saves the original EULA with whatever word focus was selected. 'Save Context' saves the content of the bottom list box if there is anything there. 'Save Analysis' saves the content of the right list box.";
        
        ShowMessage(lineOne + Environment.NewLine + Environment.NewLine + lineTwo + Environment.NewLine + Environment.NewLine + lineThree);
    }

    private void mnuPurpose_Click(object sender, EventArgs e)
    {
        ShowMessage("The program is designed to allow normal people with normal, busy lives to analyze and examine long, complicated documets. This can either be done by sorting terms by count or alphabetically, as well as examining terms based on occurrence with context, such as sentence and paragraph, as well as by allowing the search of individual or multiple terms.");
    }

    private void mnuDevelopment_Click(object sender, EventArgs e)
    {
        ShowMessage("Why make this? Well, I saw a documentary, forwhich this Application takes part of its name. It's also summer, so I have nothing better to do, and I'd like to make a smarter way for at least myself to go through EULAs.");
    }

    private void mnuAscending_Click(object sender, EventArgs e)
    {
        if (!sortNumHigh)
        {
            sortNum = true;
            sortWord = false;
            sortWordAsc = false;
            sortWordDesc = false;

            sortNumHigh = true;
            sortNumLow = false;

            DisplayOutput();
        }
    }

    private void mnuDescending_Click(object sender, EventArgs e)
    {
        if (!sortNumLow)
        {
            sortNum = true;
            sortWord = false;
            sortWordAsc = false;
            sortWordDesc = false;

            sortNumHigh = false;
            sortNumLow = true;

            DisplayOutput();
        }
    }

    private void mnuAlpha_Click(object sender, EventArgs e)
    {
        if (!sortWordDesc)
        {
            sortNum = false;
            sortWord = true;
            sortNumHigh = false;
            sortNumLow = false;

            sortWordAsc = false;
            sortWordDesc = true;

            DisplayOutput();
        }
    }

    private void mnuReverse_Click(object sender, EventArgs e)
    {
        if (!sortWordAsc)
        {
            sortNum = false;
            sortWord = true;
            sortNumHigh = false;
            sortNumLow = false;

            sortWordAsc = true;
            sortWordDesc = false;

            DisplayOutput();
        } 
    }

    private void mnuOpenDocument_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd;

        //OpenFileDialog.Filter format (all in quotes): fileTypeName (*.fileExt)|*.fileExt|(repeat for all possibilites)|All Files (*.*)|*.*
        string fileFilter = "Text files (*.txt)|*.txt";

        try
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select file to open";
            ofd.Filter = fileFilter;
            ofd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
        }

        catch (Exception ex)
        {
            ShowMessage("The following load error occured: " + ex.Message);
        }

        dataLoad();
    }

    private void mnuOpenSearchDict_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd;

        //OpenFileDialog.Filter format (all in quotes): fileTypeName (*.fileExt)|*.fileExt|(repeat for all possibilites)|All Files (*.*)|*.*
        string fileFilter = "Dictionary files (*.ldcDict)|*.ldcDict";

        try
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select file to open";
            ofd.Filter = fileFilter;
            ofd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
        }

        catch (Exception ex)
        {
            ShowMessage("The following load error occured: " + ex.Message);
        }

        dictLoad();
    }

    private void mnuOpenBlacklist_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd;

        //OpenFileDialog.Filter format (all in quotes): fileTypeName (*.fileExt)|*.fileExt|(repeat for all possibilites)|All Files (*.*)|*.*
        string fileFilter = "Blacklist files (*.ldcBL)|*.ldcBL";

        try
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select file to open";
            ofd.Filter = fileFilter;
            ofd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
        }

        catch (Exception ex)
        {
            ShowMessage("The following load error occured: " + ex.Message);
        }

        blLoad();
    }

    private void mnuResetDoc_Click(object sender, EventArgs e)
    {
        btnAnalyze.Enabled = true;
        btnAddTerm.Enabled = false;
        btnRemoveTerm.Enabled = false;
        btnSearch.Enabled = false;
        btnWordContext.Enabled = false;
        mnuAlpha.Enabled = false;
        mnuReverse.Enabled = false;
        mnuAscending.Enabled = false;
        mnuDescending.Enabled = false;

        lstBigDataOutput.Items.Clear();
        lstWordContext.Items.Clear();
        txtInput.Clear();
    }

    //Functions

    private string NormalizeTerm(string term)
    {
        term = term.Trim();
        term = term.ToLower();

        //build items in 'badChar' for normalization check

        foreach (char badChar in badChars)
        {
            if (term.IndexOf(badChar) == term.Length -1 && term.Length > 0)
            {
                term = term.Substring(0, term.Length - 1);
                break;
            }
        }

        return term;
    }

    private bool CompareTerm(string term)
    {
        foreach (clsFoundTerm found in foundTerms)
        {
            if (found.Term == term)
            {
                found.Count++;
                return true;
            }
        }

        foreach (string bad in badTerms)
        {
            if (bad == term)
            {
                return true;
            }
        }

        return false;
    }
    
    private bool CompareTerm(string term, int sentNum, int paraNum)
    {
        foreach (clsFoundTerm found in foundUniqueTerms)
        {
            if(found.Term == term && found.SentNum == sentNum && found.ParaNum == paraNum)
            {
                return false;
            }
            
            if (found.Term == term)
            {
                return true;
            }
        }

        foreach (string bad in badTerms)
        {
            if (bad == term)
            {
                return true;
            }
        }

        return false;
    }

    private string RemoveNewLineChars(string text)
    {
        string newLine = Environment.NewLine;
        string[] textDumpOne = text.Split(new string[] { "\r\n", "\n", "\t" }, StringSplitOptions.None); //Code provided online via StackExchange

        text = "";

        foreach (string line in textDumpOne)
        {
            text = text + " " + line;
        }

        text = text.Trim();

        return text;
    }

    private string RemoveEncapsulation(string term)
    {
        if (term.IndexOf('(') != - 1 || term.IndexOf(')') != - 1)
        {
            if (term.IndexOf('(') == 0 && term.IndexOf(')') == term.Length - 1)
            {
                term = term.Substring(1, term.Length - 2);
            }
            else if (term.IndexOf('(') == 0)
            {
                term = term.Substring(1, term.Length - 1);
            }
            else
            {
                term = term.Substring(0, term.Length - 2);
            }
        }

        if (term.IndexOf('"') != -1)
        {
            if (term.IndexOf('"') == 0 && term.IndexOf('"') == term.Length - 1)
            {
                term = term.Substring(1, term.Length - 2);
            }
            else if (term.IndexOf('"') == 0)
            {
                term = term.Substring(1, term.Length - 1);
            }
            else
            {
                term = term.Substring(0, term.Length - 2);
            }
        }

        if (term.IndexOf('(') != -1 || term.IndexOf(')') != -1)
        {
            if (term.IndexOf('(') == 0 && term.IndexOf(')') == term.Length - 1)
            {
                term = term.Substring(1, term.Length - 2);
            }
            else if (term.IndexOf('(') == 0)
            {
                term = term.Substring(1, term.Length - 1);
            }
            else
            {
                term = term.Substring(0, term.Length - 2);
            }
        }

        if (term.IndexOf('"') != -1)
        {
            if (term.IndexOf('"') == 0 && term.IndexOf('"') == term.Length - 1)
            {
                term = term.Substring(1, term.Length - 2);
            }
            else if (term.IndexOf('"') == 0)
            {
                term = term.Substring(1, term.Length - 1);
            }
            else
            {
                term = term.Substring(0, term.Length - 2);
            }
        }

        return term;
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        badChars = new ArrayList();
        badTerms = new ArrayList();
        foundTerms = new ArrayList();
        foundUniqueTerms = new ArrayList();
        listBoxItems = new ArrayList();
        searchTerms = new ArrayList();
        
        badChars.Add('.');
        badChars.Add(',');
        badChars.Add(';');
        badChars.Add(':');
        badChars.Add('?');
        badChars.Add('!');

        badTerms.Add("a");
        badTerms.Add("an");
        badTerms.Add("the");

        searchTerms.Add("policy");
        searchTerms.Add("own");
        searchTerms.Add("right");
        searchTerms.Add("soul");
        searchTerms.Add("agree");
    }

    private void dataSave(string text, string saveType)
    {
        StreamWriter SW = null;

        try
        {
            SW = new StreamWriter(saveType);

            SW.WriteLine(text);
        }

        catch (Exception ex)
        {
            ShowMessage("There was a problem Saving the data: " + ex.Message);
        }

        finally
        {
            SW.Close();
        }
    }

    private void dataLoad() //Loads Document
    {
        string rawData = "";
        
        StreamReader SR = null;
        try
        {
            SR = new StreamReader(fileName);

            string input = SR.ReadLine();

            while (input != null)
            {
                rawData += input + Environment.NewLine;
                input = SR.ReadLine();
            }
        }

        catch (Exception ex)
        {
            ShowMessage("There was an error loading Data: " + ex.Message);
        }

        finally
        {
            SR.Close();
        }

        txtInput.Text = rawData;
    }

    private void dictLoad() //Loads Dictionary
    {
        StreamReader SR = null;
        
        try
        {
            SR = new StreamReader(fileName);

            string input = SR.ReadLine();

            while (input != null)
            {
                string temp = input.Trim().ToLower();
                bool isListed = false;
                
                foreach (string term in searchTerms)
                {
                    if (temp == term)
                    {
                        isListed = true;
                        break;
                    }
                }

                if (!isListed)
                {
                    searchTerms.Add(temp);
                }

                input = SR.ReadLine();
            }
        }

        catch (Exception ex)
        {
            ShowMessage("There was an error loading Data: " + ex.Message);
        }

        finally
        {
            SR.Close();
        }


    }

    private void blLoad() //Loads Blacklist
    {
        StreamReader SR = null;

        try
        {
            SR = new StreamReader(fileName);

            string input = SR.ReadLine();

            while (input != null)
            {
                string temp = input.Trim().ToLower();
                bool isListed = false;

                foreach (string term in badTerms)
                {
                    if (temp == term)
                    {
                        isListed = true;
                        break;
                    }
                }

                if (!isListed)
                {
                    badTerms.Add(temp);
                }

                input = SR.ReadLine();
            }
        }

        catch (Exception ex)
        {
            ShowMessage("There was an error loading Data: " + ex.Message);
        }

        finally
        {
            SR.Close();
        }
    }

    private string BuildOutput(ListBox lstOutput)
    {
        string newLine = Environment.NewLine;
        string output = "";

        for (int i = 0; i < lstOutput.Items.Count - 1; i++)
        {
            if (i == 0)
            {
                output = (string)lstOutput.Items[0];
                
            }
            else
            {
                output = output + newLine + (string)lstOutput.Items[i];
            }
        }

        return output;
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Do you want to save before closing?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            dataSave(txtInput.Text, "Original");
            dataSave(BuildOutput(lstBigDataOutput), "Analysis");
            dataSave(BuildOutput(lstWordContext), "Context");
        }
    }

    private void DisplayOutput()
    {
        lstBigDataOutput.Items.Clear();
        
        ArrayList tempData = new ArrayList();

        foreach (clsFoundTerm item in foundTerms)
        {
            tempData.Add(item);
        }

        //Basic Sort Structure
        if (sortNum)
        {
            if (sortNumHigh)
            {
                for (int i = 0; i < tempData.Count - 2; i++)
                {
                    for (int n = i + 1; n < tempData.Count - 1; n++)
                    {
                        clsFoundTerm first = (clsFoundTerm)tempData[i];
                        clsFoundTerm second = (clsFoundTerm)tempData[n];
                        int firstTerm = first.Count;
                        int secondTerm = second.Count;

                        if (firstTerm < secondTerm)
                        {
                            clsFoundTerm temp = (clsFoundTerm)tempData[i];
                            tempData[i] = second;
                            tempData[n] = temp;
                        }
                    }
                }

            }
            else
            {
                for (int i = 0; i < tempData.Count - 2; i++)
                {
                    for (int n = i + 1; n < tempData.Count - 1; n++)
                    {
                        clsFoundTerm first = (clsFoundTerm)tempData[i];
                        clsFoundTerm second = (clsFoundTerm)tempData[n];
                        int firstTerm = first.Count;
                        int secondTerm = second.Count;

                        if (firstTerm > secondTerm)
                        {
                            clsFoundTerm temp = (clsFoundTerm)tempData[i];
                            tempData[i] = second;
                            tempData[n] = temp;
                        }
                    }
                }
            }
        }
        else if (sortWord)
        {
            if (sortWordAsc)
            {
                for (int i = 0; i < tempData.Count - 2; i++)
                {
                    for (int n = i + 1; n < tempData.Count - 1; n++)
                    {
                        clsFoundTerm first = (clsFoundTerm)tempData[i];
                        clsFoundTerm second = (clsFoundTerm)tempData[n];
                        string firstTerm = first.Term;
                        string secondTerm = second.Term;

                        if (firstTerm.CompareTo(secondTerm) < 0)
                        {
                            clsFoundTerm temp = (clsFoundTerm)tempData[i];
                            tempData[i] = second;
                            tempData[n] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < tempData.Count - 2; i++)
                {
                    for (int n = i + 1; n < tempData.Count - 1; n++)
                    {
                        clsFoundTerm first = (clsFoundTerm)tempData[i];
                        clsFoundTerm second = (clsFoundTerm)tempData[n];
                        string firstTerm = first.Term;
                        string secondTerm = second.Term;

                        if (firstTerm.CompareTo(secondTerm) > 0)
                        {
                            clsFoundTerm temp = (clsFoundTerm)tempData[i];
                            tempData[i] = second;
                            tempData[n] = temp;
                        }
                    }
                }
            }
        }
        else
        {
            //Displays no sort or limit
        }

        for (int i = 0; i < foundTerms.Count; i++)
        {
            clsFoundTerm temp = (clsFoundTerm)tempData[i];

            lstBigDataOutput.Items.Add(temp.Term.PadRight(50) + temp.Count.ToString().PadLeft(5));
        }
    }

    private void lstBigDataOutput_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstBigDataOutput.SelectedIndex != -1)
        {
            btnWordContext.Enabled = true;
        }
    }

    private bool CheckLength(string term)
    {
        if (term.Length < 4)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void ShowMessage(string msg)
    {
        MessageBox.Show(msg, "Large Document Collider", MessageBoxButtons.OK);
    }

    

    

    

    


    

}
