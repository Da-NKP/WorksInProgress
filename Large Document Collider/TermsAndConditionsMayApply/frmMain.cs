using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;

/*
 * Bill Hall
 * End User License Agreement: Terms and Conditions May Apply
 * 
 * Description: The program is designed to use Big Data Concepts to run through a EULA to show popular terms and the such...
 * The reason behind such is that EULAs tend to be longer than most people can deal with. Via Big Data Analytics, the program 
 * should make it much easier to go through and understand what you agree to.
 * 
 * Why make this? Well, I saw a documentary, forwhich this Application takes part of its name. It's also summer, so I have
 * nothing better to do, and I'd like to make a smarter way for at least myself to go through EULAs. 
 * 
 * Update: This program will be redone to focus on Word Analysis in any large document, not just EULAs. 

just need a space to think here...

need to normalize terms
	need to remove possible punctuation
		comma
		period
		question mark
		etc
	need to set to lowercase

need to compare items 
	need to make sure they aren't "common" words
	need to make sure they are not helper verbs
	need to keep track of instances
	need to remove modifiers

need to read input
	need to support text files
		need to remove new line characters
		need to get words
		need to work around line breaks
	need to support raw input
		need to remove new line characters

idea: use infinite while loop inside of a try/catch
by doing this, I can keep looking for new values inside a text file, even with multiple empty lines
eventually, the StreamReader will run into an exception, jump out of the while loop into catch, which will then allow the program to resume functioning
 
 *
 * 
 * 
 * Currently, Application guarenteed to crash on first launch...
 * 
*/

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
    private bool topTen = false;
    private bool topHundred = false;
    private bool topThousand = false;

    string fileName = "";

    ArrayList badChars;
    ArrayList foundTerms;
    ArrayList badTerms;
    ArrayList listBoxItems;

    public frmMain()
    {
        InitializeComponent();
    }

    #region Validation

    //******************* Validation Helper Methods by Alka Harriger *********************

    // The ShowMessage helper method displays an error message with a standard title and an OK button.
    private void ShowMessage(string msg)
    {
        MessageBox.Show(msg, "Message from Application", MessageBoxButtons.OK);
    }

    // The overloaded validateInput helper method handles just the existence check for any data item.
    private bool validateInput(TextBox txtInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper method handles the existence check for a given string input form object
    // and assigns the equivalent value to its corresponding variable.
    private bool validateInput(TextBox txtInput, out string userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = "";
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        userInput = txtInput.Text;
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check for a given Boolean input form object
    // and assigns the equivalent value to its corresponding variable.
    private bool validateInput(TextBox txtInput, out bool userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = false;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        userInput = bool.Parse(txtInput.Text);
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles int data.)
    private bool validateInput(TextBox txtInput, int min, int max, out int userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (int.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles double data.)
    private bool validateInput(TextBox txtInput, double min, double max, out double userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0D;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (double.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles decimal data.)
    private bool validateInput(TextBox txtInput, decimal min, decimal max, out decimal userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0M;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (decimal.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles DateTime data.)
    private bool validateInput(TextBox txtInput, DateTime min, DateTime max, out DateTime userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = DateTime.Parse("01/01/1900");
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a date in the format mm/dd/yyyy for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (DateTime.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only dates are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToShortDateString() + " and " + max.ToShortDateString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    #endregion

    private void btnAnalyze_Click(object sender, EventArgs e)
    {
        string rawData = "";

        if (!validateInput(txtInput, out rawData))
        {
            ShowMessage("Please provide text for user input.");
            txtInput.Focus();
            return;
        }

        rawData = RemoveNewLineChars(rawData);

        string[] rawTerms = rawData.Split(' ');

        foreach (string term in rawTerms)
        {
            if (CheckLength(term))
            {
                string word = RemoveEncapsulation(NormalizeTerm(RemoveEncapsulation(term))); //This needs to be reviewed

                if (!CompareTerm(word))
                {
                    clsFoundTerm temp = new clsFoundTerm(word);
                    foundTerms.Add(temp);
                }
            }   
        }

        listBoxItems = foundTerms;

        DisplayOutput();

        btnOrderAlphaBeta.Enabled = true;
        btnOrderNum.Enabled = true;
        btnSearch.Enabled = true;
        btnAnalyze.Enabled = false;
        mnuTopTen.Enabled = true;
        mnuTopHundred.Enabled = true;
        mnuTopThousand.Enabled = true;

        txtInput.Clear();
    }

    private void btnOrderNum_Click(object sender, EventArgs e)
    {
        sortNum = true;
        sortWord = false;
        sortWordAsc = false;
        sortWordDesc = false;
        
        if (!sortNumHigh)
        {
            sortNumHigh = true;
            sortNumLow = false;
        }
        else
        {
            sortNumHigh = false;
            sortNumLow = true;
        }

        DisplayOutput();
    }

    private void btnOrderAlphaBeta_Click(object sender, EventArgs e)
    {
        sortNum = false;
        sortWord = true;
        sortNumHigh = false;
        sortNumLow = false;
        
        if (!sortWordAsc)
        {
            sortWordAsc = true;
            sortWordDesc = false;
        }
        else 
        {
            sortWordAsc = false;
            sortWordDesc = true;
        }

        DisplayOutput();
    }

    private void btnWordContext_Click(object sender, EventArgs e)
    {
        btnWordContext.Enabled = false;
        
        #region Comment Methology
        /*
         * Split input by '.' but only if the period is followed by a space and a capital letter
         * Trim the spacing
         * Decapsulate intelligently - conditional check for beginning and end only, not just existence
         * Add Period at the end
         * Split every 'block' by space char
         * Do normal formatting
         * Check Existence
         * Display Relevent Sentence
         * 
         * Even more ridiculous...
         * 
         * In retrospect, not nearly as ridiculous as I thought...
         * 
        */
        #endregion

        int focusTermIndex = 0;

        if (lstBigDataOutput.SelectedIndex == -1)
        {
            ShowMessage("Please selcet a term to Contextualize.");
            return;
        }
        else
        {
            focusTermIndex = lstBigDataOutput.SelectedIndex;
        }

        clsFoundTerm temp = (clsFoundTerm)listBoxItems[focusTermIndex];
        string focusTerm = temp.Term;

        string rawInput = txtInput.Text;
        string[] rawSentenceInput = rawInput.Split('.');
        ArrayList rawSentences = new ArrayList();

        foreach (string sentence in rawSentenceInput)
        {
            string newSentences = RemoveNewLineChars(sentence);
            
            rawSentences.Add(newSentences);
        }

        ArrayList termSentences = new ArrayList();

        for (int i = 1; i < termSentences.Count - 2; i++)
        {
            string sentence = (string)termSentences[i];

            if (sentence.IndexOf(focusTerm) != -1)
            {
                string newSentence = (string)termSentences[i - 1] + "." + sentence + "." + (string)termSentences[i + 1] + ".";
                termSentences.Add(newSentence);
            }
        }

        foreach (string sentence in termSentences)
        {
            lstWordContext.Items.Add(sentence);
        }

        btnWordContext.Enabled = true;
    }

    private void mnuOpen_Click(object sender, EventArgs e)
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

    private void mnuShowTopTen_Click(object sender, EventArgs e)
    {
        topTen = true;
        topHundred = false;
        topThousand = false;

        DisplayOutput();
    }

    private void mnuShowTopHundred_Click(object sender, EventArgs e)
    {
        topTen = false;
        topHundred = true;
        topThousand = false;

        DisplayOutput();
    }

    private void mnuShowTopThousand_Click(object sender, EventArgs e)
    {
        topTen = false;
        topHundred = false;
        topThousand = true;

        DisplayOutput();
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
        ShowMessage("The program is designed to use Big Data Concepts to run through a EULA to show popular terms and the such. The reason behind such is that EULAs tend to be longer than most people can deal with. Via Big Data Analytics, the program should make it much easier to go through and understand what you agree to.");
    }

    private void mnuDevelopment_Click(object sender, EventArgs e)
    {
        ShowMessage("Why make this? Well, I saw a documentary, forwhich this Application takes part of its name. It's also summer, so I have nothing better to do, and I'd like to make a smarter way for at least myself to go through EULAs.");
    }

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

    private string RemoveNewLineChars(string text)
    {
        string newLine = Environment.NewLine;
        string[] textDumpOne = text.Split(new string[] { "\r\n", "\n", "\t" }, StringSplitOptions.None); //Code provided online via StackExchange
        

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
        listBoxItems = new ArrayList();
        
        badChars.Add('.');
        badChars.Add(',');
        badChars.Add(';');
        badChars.Add(':');
        badChars.Add('?');
        badChars.Add('!');

        badTerms.Add("a");
        badTerms.Add("an");
        badTerms.Add("the");
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

    private void dataLoad()
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

        int tNum = foundTerms.Count;

        if (topTen)
        {
            tNum = 10;
        }

        if (topHundred)
        {
            tNum = 100;
        }

        if (topThousand)
        {
            tNum = 1000;
        }

        for (int i = 0; i < tNum; i++)
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

    private void btnFirstWord_Click(object sender, EventArgs e)
    {

    }

    private void btnPrevWord_Click(object sender, EventArgs e)
    {

    }

    private void btnNextWord_Click(object sender, EventArgs e)
    {

    }

    private void btnLastWord_Click(object sender, EventArgs e)
    {

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

        foreach(string term in sTerms)
        {
            int cNum = numItems;
            
            foreach(clsFoundTerm item in foundTerms)
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

}
