using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

public partial class frmMain : Form
{
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private string selectedFileName;
    private ArrayList gameLines;
    private ArrayList gameSaveList;
    private string[] xmlCodes;
    private bool save, game, display, choice;
    private ArrayList commandType;
    private ArrayList Commands;
    private char[] operators;
    private ArrayList properties;

    public frmMain()
    {
        InitializeComponent();
    }

    #region Validation Stuffs

    private void ShowMessage(string text)
    {
        MessageBox.Show(text, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private bool validateInput(TextBox tBox, bool output)
    {
        bool value = bool.TryParse(tBox.Text, out output);
        return value;
    }

    private bool validateInput(TextBox tBox, int output)
    {
        bool value = int.TryParse(tBox.Text, out output);
        return value;
    }

    private bool validateInput(TextBox tBox, decimal output)
    {
        bool value = decimal.TryParse(tBox.Text, out output);
        return value;
    }

    private bool validateInput(TextBox tBox, string output)
    {
        bool value = false;
        if (tBox.Text.Trim() != "")
        {
            output = tBox.Text.Trim();
        }
        return value;
    }
    #endregion

    private void tabMain_Selected(object sender, TabControlEventArgs e)
    {
        if (tabMain.SelectedIndex == 0) //This is the Editor
        {
            //reset tester
        }
        else //This is the Tester
        {
            //Call build and run methods
        }
    }

    private void dataLoad(bool success)
    {
        if (!success)
        {
            return;
        }

        StreamReader SR = null;

        try
        {
            SR = new StreamReader(selectedFileName);

            string input = SR.ReadLine();

            gameLines = new ArrayList();

            while (input != null)
            {
                gameLines.Add(input);

                input = SR.ReadLine();
            }
        }

        catch (Exception ex)
        {
            ShowMessage("There was an error loading Data: " + ex.Message);
        }

        finally
        {
            if (SR.ReadLine() == null)
            {
                SR.Close();
            }
        }

        BuildGameData();
    }//Complete

    private void dataSave(bool success)
    {
        if (!success)
        {
            return;
        }

        StreamWriter SW = null;

        try
        {
            SW = new StreamWriter(selectedFileName);

            foreach (string line in gameSaveList)
            {
                SW.WriteLine(line);
            }
        }

        catch (Exception ex)
        {
            ShowMessage("There was a problem Saving the data: " + ex.Message);
        }

        finally
        {
            SW.Close();
        }
    }//Complete

    private void mnuSave_Click(object sender, EventArgs e)
    {
        SaveFileDialog sfd;

        bool isSuccess = false;

        //SaveFileDialog.Filter format (all in quotes): fileTypeName (*.fileExt)|*.fileExt|(repeat for all possibilites)|All Files (*.*)|*.*
        string fileFilter = "RPG Game file (*.rpg)|*.rpg";

        try
        {
            sfd = new SaveFileDialog();
            sfd.Title = "Select file to save";
            sfd.Filter = fileFilter;
            sfd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = sfd.FileName;
                isSuccess = true;
            }
        }

        catch (Exception ex)
        {
            ShowMessage("The following save error occured: " + ex.Message);
        }

        dataSave(isSuccess);
    }//Complete

    private void mnuLoad_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd;

        bool isSuccess = false;

        //OpenFileDialog.Filter format (all in quotes): fileTypeName (*.fileExt)|*.fileExt|(repeat for all possibilites)|All Files (*.*)|*.*
        string fileFilter = "RPG Game files (*.rpg)|*.rpg";

        try
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select file to open";
            ofd.Filter = fileFilter;
            ofd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = ofd.FileName;
                isSuccess = true;
            }
        }

        catch (Exception ex)
        {
            ShowMessage("The following load error occured: " + ex.Message);
        }

        dataLoad(isSuccess);
        this.Text += " " + selectedFileName;
    }//Complete

    private void BuildGameData()
    {
        xmlCodes = new string[24] {"<save>","</save>","<game>","</game>","<display>","</display>","<choice>","</choice>","<text>","</text>","<choice1>","</choice1>","<choice2>","</choice2>","<choice3>","</choice3>","<choice4>","</choice4>","<choice5>","</choice5>","<choice6>","</choice6>","<result>","</result>"};
        
        save = false;
        game = false;
        display = false;
        choice = false;

        #region foreach line in gameLines
        foreach (string line in gameLines)
        {
            if (line == "<save>")
            {
                save = true;
            }
            else if (line == "</save>")
            {
                save = false;
            }
            else if (line == "<game>")
            {
                game = true;
            }
            else if (line == "</game>")
            {
                game = false;
            }
            else if (line == "<display>")
            {
                display = true;
            }
            else if (line == "</display>")
            {
                display = false;
            }
            else if (line.Substring(0,7) == "<choice>")
            {
                choice = true;
            }
            else if (line == "</choice>")
            {
                choice = false;
            }
            else
            {
                StringParse(line);
            }
        }
        #endregion
    }//Complete

    private void ExportGame()
    {
        gameSaveList = new ArrayList();

        gameSaveList.Add("<save>");

        foreach (string property in properties)
        {
            gameSaveList.Add(property);
        }

        gameSaveList.Add("</save>");

        gameSaveList.Add("<game>");

        for (int i = 0; i < Commands.Count - 1; i++)
        {
            if ((string)commandType[i] == "string")
            {
                gameSaveList.Add("<display>");
                gameSaveList.Add((string)Commands[i]);
                gameSaveList.Add("</display>");
            }
            if ((string)commandType[i] == "choice")
            {
                gameSaveList.Add("<choice>");
                clsChoice test = (clsChoice)Commands[i];
                gameSaveList.Add("<text>");
                gameSaveList.Add(test.Text);
                gameSaveList.Add("</text>");
                if (test.Count == 6)
                {
                    #region Choice1
                    gameSaveList.Add("<choice1>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.One.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.One.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.One.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice1>");
                    #endregion

                    #region Choice2
                    gameSaveList.Add("<choice2>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Two.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Two.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Two.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice2>");
#endregion

                    #region Choice3
                    gameSaveList.Add("<choice3>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Three.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Three.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Three.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice3>");
                    #endregion

                    #region Choice4
                    gameSaveList.Add("<choice4>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Four.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Four.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Four.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Four.Result.Property.Name + test.Four.Result.Property.Operation + test.Four.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Four.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Four.Result.Property.Name + test.Four.Result.Property.Operation + test.Four.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Four.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice4>");
                    #endregion

                    #region Choice5
                    gameSaveList.Add("<choice5>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Five.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Five.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Five.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Five.Result.Property.Name + test.Five.Result.Property.Operation + test.Five.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Five.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Five.Result.Property.Name + test.Five.Result.Property.Operation + test.Five.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Five.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice5>");
                    #endregion

                    #region Choice6
                    gameSaveList.Add("<choice6>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Six.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Six.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Six.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Six.Result.Property.Name + test.Six.Result.Property.Operation + test.Six.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Six.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Six.Result.Property.Name + test.Six.Result.Property.Operation + test.Six.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Six.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice6>");
                    #endregion

                    gameSaveList.Add("</choice>");
                }
                else if (test.Count == 5)
                {
                    #region Choice1
                    gameSaveList.Add("<choice1>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.One.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.One.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.One.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice1>");
                    #endregion

                    #region Choice2
                    gameSaveList.Add("<choice2>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Two.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Two.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Two.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice2>");
                    #endregion

                    #region Choice3
                    gameSaveList.Add("<choice3>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Three.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Three.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Three.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice3>");
                    #endregion

                    #region Choice4
                    gameSaveList.Add("<choice4>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Four.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Four.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Four.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Four.Result.Property.Name + test.Four.Result.Property.Operation + test.Four.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Four.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Four.Result.Property.Name + test.Four.Result.Property.Operation + test.Four.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Four.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice4>");
                    #endregion

                    #region Choice5
                    gameSaveList.Add("<choice5>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Five.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Five.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Five.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Five.Result.Property.Name + test.Five.Result.Property.Operation + test.Five.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Five.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Five.Result.Property.Name + test.Five.Result.Property.Operation + test.Five.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Five.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice5>");
                    #endregion

                    gameSaveList.Add("</choice>");
                }
                else if (test.Count == 4)
                {
                    #region Choice1
                    gameSaveList.Add("<choice1>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.One.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.One.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.One.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice1>");
                    #endregion

                    #region Choice2
                    gameSaveList.Add("<choice2>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Two.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Two.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Two.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice2>");
                    #endregion

                    #region Choice3
                    gameSaveList.Add("<choice3>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Three.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Three.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Three.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice3>");
                    #endregion

                    #region Choice4
                    gameSaveList.Add("<choice4>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Four.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Four.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Four.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Four.Result.Property.Name + test.Four.Result.Property.Operation + test.Four.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Four.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Four.Result.Property.Name + test.Four.Result.Property.Operation + test.Four.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Four.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice4>");
                    #endregion

                    gameSaveList.Add("</choice>");
                }
                else if (test.Count == 3)
                {
                    #region Choice1
                    gameSaveList.Add("<choice1>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.One.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.One.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.One.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice1>");
                    #endregion

                    #region Choice2
                    gameSaveList.Add("<choice2>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Two.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Two.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Two.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice2>");
                    #endregion

                    #region Choice3
                    gameSaveList.Add("<choice3>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Three.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Three.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Three.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Three.Result.Property.Name + test.Three.Result.Property.Operation + test.Three.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Three.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice3>");
                    #endregion

                    gameSaveList.Add("</choice>");
                }
                else
                {
                    #region Choice1
                    gameSaveList.Add("<choice1>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.One.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.One.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.One.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.One.Result.Property.Name + test.One.Result.Property.Operation + test.One.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.One.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice1>");
                    #endregion

                    #region Choice2
                    gameSaveList.Add("<choice2>");
                    gameSaveList.Add("<text>");
                    gameSaveList.Add(test.Two.Text);
                    gameSaveList.Add("</text>");
                    gameSaveList.Add("<result>");
                    if (test.Two.Result.Type == "both")
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else if (test.Two.Result.Type == "property")
                    {
                        gameSaveList.Add("<system>");
                        gameSaveList.Add(test.Two.Result.Property.Name + test.Two.Result.Property.Operation + test.Two.Result.Property.pValue.ToString());
                        gameSaveList.Add("</system");
                    }
                    else
                    {
                        gameSaveList.Add("<text>");
                        gameSaveList.Add(test.Two.Result.rValue);
                        gameSaveList.Add("</text>");
                    }
                    gameSaveList.Add("</choice2>");
                    #endregion

                    gameSaveList.Add("</choice>");
                }
            }
        }

        gameSaveList.Add("</game>");
    }//Complete

    private void StringParse(string line)
    {
        operators = new char[5] { '=', '+', '-', '*', '/' };
        properties = new ArrayList();

        if (save && line.IndexOf('=') != -1)
        {
            properties.Add(new clsGameProperty(line.Substring(0, line.Length - line.IndexOf('=') + 1), "=", int.Parse(line.Substring(line.IndexOf('=') + 1))));
        }
        else if (game && display)
        {
            Commands.Add(line);
            commandType.Add("string");
        }
        else if (game && choice)
        {
            string initText = line.Substring(line.IndexOf("<text>"), line.Length - line.IndexOf("</text>") + 1);
            string choiceOneText = line.Substring(line.IndexOf("<choice1>"), line.Length - line.IndexOf("</choice1>") + 1);
            string choiceTwoText = line.Substring(line.IndexOf("<choice2>"), line.Length - line.IndexOf("</choice2>") + 1);
            string choiceThreeText = "";
            string choiceFourText = "";
            string choiceFiveText = "";
            string choiceSixText = ""; ;
            
            if (line.IndexOf("<choice3>") != -1)
            {
                choiceThreeText = line.Substring(line.IndexOf("<choice3>"), line.Length - line.IndexOf("</choice3>") + 1);
            }
            if (line.IndexOf("<choice4>") != -1)
            {
                choiceFourText = line.Substring(line.IndexOf("<choice4>"), line.Length - line.IndexOf("</choice4>") + 1);
            }
            if (line.IndexOf("<choice5>") != -1)
            {
                choiceFiveText = line.Substring(line.IndexOf("<choice5>"), line.Length - line.IndexOf("</choice5>") + 1);
            }
            if (line.IndexOf("<choice6>") != -1)
            {
                choiceSixText = line.Substring(line.IndexOf("<choice6>"), line.Length - line.IndexOf("</choice6>") + 1);
            }
            #region ChoiceBuild
            clsChoiceNum choiceNumberOne = new clsChoiceNum();
            clsChoiceNum choiceNumberTwo = new clsChoiceNum();
            clsChoiceNum choiceNumberThree = new clsChoiceNum();
            clsChoiceNum choiceNumberFour = new clsChoiceNum();
            clsChoiceNum choiceNumberFive = new clsChoiceNum();
            clsChoiceNum choiceNumberSix = new clsChoiceNum();

            if (choiceSixText != "")
            {
                string choiceLabel = choiceSixText.Substring(choiceSixText.IndexOf("<text>"), choiceSixText.Length - choiceSixText.IndexOf("</text>") + 1);
                string resultText = choiceSixText.Substring(choiceSixText.IndexOf("<result>"), choiceSixText.Length - choiceSixText.IndexOf("</result>") + 1);
                string resultValue = "";
                string resultProperty = "";
                if (resultText.IndexOf("<text>") != -1)
                {
                    resultValue = resultText.Substring(resultText.IndexOf("<text>"), resultText.Length - resultText.IndexOf("</text>") + 1);
                }
                if (resultText.IndexOf("<system>") != -1)
                {
                    resultProperty = resultText.Substring(resultText.IndexOf("<system>"), resultText.Length - resultText.IndexOf("</system>") + 1);
                }

                if (resultProperty != "" && resultText != "")
                {
                    clsResult resultDerp = new clsResult(resultValue, ReturnGameProperty(resultProperty));
                    choiceNumberSix = new clsChoiceNum(choiceLabel, 6, resultDerp);
                }
                else if (resultProperty != "")
                {
                    clsResult resultDerp = new clsResult(ReturnGameProperty(resultProperty));
                    choiceNumberSix = new clsChoiceNum(choiceLabel, 6, resultDerp);
                }
                else
                {
                    clsResult resultDerp = new clsResult(resultValue);
                    choiceNumberSix = new clsChoiceNum(choiceLabel, 6, resultDerp);
                }
            }
            if (choiceFiveText != "")
            {
                string choiceLabel = choiceFiveText.Substring(choiceFiveText.IndexOf("<text>"), choiceFiveText.Length - choiceFiveText.IndexOf("</text>") + 1);
                string resultText = choiceFiveText.Substring(choiceFiveText.IndexOf("<result>"), choiceFiveText.Length - choiceFiveText.IndexOf("</result>") + 1);
                string resultValue = "";
                string resultProperty = "";
                if (resultText.IndexOf("<text>") != -1)
                {
                    resultValue = resultText.Substring(resultText.IndexOf("<text>"), resultText.Length - resultText.IndexOf("</text>") + 1);
                }
                if (resultText.IndexOf("<system>") != -1)
                {
                    resultProperty = resultText.Substring(resultText.IndexOf("<system>"), resultText.Length - resultText.IndexOf("</system>") + 1);
                }

                if (resultProperty != "" && resultText != "")
                {
                    clsResult resultDerp = new clsResult(resultValue, ReturnGameProperty(resultProperty));
                    choiceNumberFive = new clsChoiceNum(choiceLabel, 5, resultDerp);
                }
                else if (resultProperty != "")
                {
                    clsResult resultDerp = new clsResult(ReturnGameProperty(resultProperty));
                    choiceNumberFive = new clsChoiceNum(choiceLabel, 5, resultDerp);
                }
                else
                {
                    clsResult resultDerp = new clsResult(resultValue);
                    choiceNumberFive = new clsChoiceNum(choiceLabel, 5, resultDerp);
                }
            }
            if (choiceFourText != "")
            {
                string choiceLabel = choiceFourText.Substring(choiceFourText.IndexOf("<text>"), choiceFourText.Length - choiceFourText.IndexOf("</text>") + 1);
                string resultText = choiceFourText.Substring(choiceFourText.IndexOf("<result>"), choiceFourText.Length - choiceFourText.IndexOf("</result>") + 1);
                string resultValue = "";
                string resultProperty = "";
                if (resultText.IndexOf("<text>") != -1)
                {
                    resultValue = resultText.Substring(resultText.IndexOf("<text>"), resultText.Length - resultText.IndexOf("</text>") + 1);
                }
                if (resultText.IndexOf("<system>") != -1)
                {
                    resultProperty = resultText.Substring(resultText.IndexOf("<system>"), resultText.Length - resultText.IndexOf("</system>") + 1);
                }

                if (resultProperty != "" && resultText != "")
                {
                    clsResult resultDerp = new clsResult(resultValue, ReturnGameProperty(resultProperty));
                    choiceNumberFour = new clsChoiceNum(choiceLabel, 4, resultDerp);
                }
                else if (resultProperty != "")
                {
                    clsResult resultDerp = new clsResult(ReturnGameProperty(resultProperty));
                    choiceNumberFour = new clsChoiceNum(choiceLabel, 4, resultDerp);
                }
                else
                {
                    clsResult resultDerp = new clsResult(resultValue);
                    choiceNumberFour = new clsChoiceNum(choiceLabel, 4, resultDerp);
                }
            }
            if (choiceThreeText != "")
            {
                string choiceLabel = choiceThreeText.Substring(choiceThreeText.IndexOf("<text>"), choiceThreeText.Length - choiceThreeText.IndexOf("</text>") + 1);
                string resultText = choiceThreeText.Substring(choiceThreeText.IndexOf("<result>"), choiceThreeText.Length - choiceThreeText.IndexOf("</result>") + 1);
                string resultValue = "";
                string resultProperty = "";
                if (resultText.IndexOf("<text>") != -1)
                {
                    resultValue = resultText.Substring(resultText.IndexOf("<text>"), resultText.Length - resultText.IndexOf("</text>") + 1);
                }
                if (resultText.IndexOf("<system>") != -1)
                {
                    resultProperty = resultText.Substring(resultText.IndexOf("<system>"), resultText.Length - resultText.IndexOf("</system>") + 1);
                }

                if (resultProperty != "" && resultText != "")
                {
                    clsResult resultDerp = new clsResult(resultValue, ReturnGameProperty(resultProperty));
                    choiceNumberThree = new clsChoiceNum(choiceLabel, 3, resultDerp);
                }
                else if (resultProperty != "")
                {
                    clsResult resultDerp = new clsResult(ReturnGameProperty(resultProperty));
                    choiceNumberThree = new clsChoiceNum(choiceLabel, 3, resultDerp);
                }
                else
                {
                    clsResult resultDerp = new clsResult(resultValue);
                    choiceNumberThree = new clsChoiceNum(choiceLabel, 3, resultDerp);
                }
            }
            if (true)
            {
                string choiceLabel = choiceOneText.Substring(choiceOneText.IndexOf("<text>"), choiceOneText.Length - choiceOneText.IndexOf("</text>") + 1);
                string resultText = choiceOneText.Substring(choiceOneText.IndexOf("<result>"), choiceOneText.Length - choiceOneText.IndexOf("</result>") + 1);
                string choiceLabelTwo = choiceTwoText.Substring(choiceTwoText.IndexOf("<text>"), choiceTwoText.Length - choiceTwoText.IndexOf("</text>") + 1);
                string resultTextTwo = choiceTwoText.Substring(choiceTwoText.IndexOf("<result>"), choiceTwoText.Length - choiceTwoText.IndexOf("</result>") + 1);
                string resultValue = "";
                string resultProperty = "";
                string resultValueTwo = "";
                string resultPropertyTwo = "";
                if (resultText.IndexOf("<text>") != -1)
                {
                    resultValue = resultText.Substring(resultText.IndexOf("<text>"), resultText.Length - resultText.IndexOf("</text>") + 1);
                }
                if (resultText.IndexOf("<system>") != -1)
                {
                    resultProperty = resultText.Substring(resultText.IndexOf("<system>"), resultText.Length - resultText.IndexOf("</system>") + 1);
                }
                if (resultTextTwo.IndexOf("<text>") != -1)
                {
                    resultValueTwo = resultTextTwo.Substring(resultTextTwo.IndexOf("<text>"), resultTextTwo.Length - resultTextTwo.IndexOf("</text>") + 1);
                }
                if (resultTextTwo.IndexOf("<system>") != -1)
                {
                    resultPropertyTwo = resultTextTwo.Substring(resultTextTwo.IndexOf("<system>"), resultTextTwo.Length - resultTextTwo.IndexOf("</system>") + 1);
                }

                if (resultProperty != "" && resultText != "")
                {
                    clsResult resultDerp = new clsResult(resultValue, ReturnGameProperty(resultProperty));
                    choiceNumberOne = new clsChoiceNum(choiceLabel, 1, resultDerp);
                }
                else if (resultProperty != "")
                {
                    clsResult resultDerp = new clsResult(ReturnGameProperty(resultProperty));
                    choiceNumberOne = new clsChoiceNum(choiceLabel, 1, resultDerp);
                }
                else
                {
                    clsResult resultDerp = new clsResult(resultValue);
                    choiceNumberOne = new clsChoiceNum(choiceLabel, 1, resultDerp);
                }
                if (resultPropertyTwo != "" && resultTextTwo != "")
                {
                    clsResult resultDerp = new clsResult(resultValueTwo, ReturnGameProperty(resultPropertyTwo));
                    choiceNumberTwo = new clsChoiceNum(choiceLabel, 2, resultDerp);
                }
                else if (resultPropertyTwo != "")
                {
                    clsResult resultDerp = new clsResult(ReturnGameProperty(resultPropertyTwo));
                    choiceNumberTwo = new clsChoiceNum(choiceLabel, 2, resultDerp);
                }
                else
                {
                    clsResult resultDerp = new clsResult(resultValueTwo);
                    choiceNumberTwo = new clsChoiceNum(choiceLabel, 2, resultDerp);
                }
            }
#endregion
            clsChoice choiceMain = new clsChoice();

            if (choiceNumberSix.Text != "")
            {
                choiceMain = new clsChoice(initText, 6, choiceNumberOne, choiceNumberTwo, choiceNumberThree, choiceNumberFour, choiceNumberFive, choiceNumberSix);
            }
            else if (choiceNumberFive.Text != "")
            {
                choiceMain = new clsChoice(initText, 5, choiceNumberOne, choiceNumberTwo, choiceNumberThree, choiceNumberFour, choiceNumberFive, choiceNumberSix);
            }
            else if (choiceNumberFour.Text != "")
            {
                choiceMain = new clsChoice(initText, 4, choiceNumberOne, choiceNumberTwo, choiceNumberThree, choiceNumberFour, choiceNumberFive, choiceNumberSix);
            }
            else if (choiceNumberThree.Text != "")
            {
                choiceMain = new clsChoice(initText, 3, choiceNumberOne, choiceNumberTwo, choiceNumberThree, choiceNumberFour, choiceNumberFive, choiceNumberSix);
            }
            else
            {
                choiceMain = new clsChoice(initText, 2, choiceNumberOne, choiceNumberTwo, choiceNumberThree, choiceNumberFour, choiceNumberFive, choiceNumberSix);
            }

            Commands.Add(choiceMain);
            commandType.Add("choice");
        }

    }//Complete

    private clsGameProperty ReturnGameProperty(string text)
    {
        clsGameProperty gProperty = new clsGameProperty("ERROR", "=", 9999);

        if (text.IndexOf('+') != -1)
        {
            foreach (clsGameProperty property in properties)
            {
                if (property.Name == text.Substring(0, text.Length - text.IndexOf('+') + 1))
                {
                    property.pValue += int.Parse(text.Substring(text.IndexOf('+') + 1));
                    gProperty = new clsGameProperty(property.Name, "+", property.pValue);
                }
            }
        }
        else if (text.IndexOf('-') != -1)
        {
            foreach (clsGameProperty property in properties)
            {
                if (property.Name == text.Substring(0, text.Length - text.IndexOf('-') + 1))
                {
                    property.pValue -= int.Parse(text.Substring(text.IndexOf('-') + 1));
                    gProperty = new clsGameProperty(property.Name, "-", property.pValue);
                }
            }
        }
        else if (text.IndexOf('*') != -1)
        {
            foreach (clsGameProperty property in properties)
            {
                if (property.Name == text.Substring(0, text.Length - text.IndexOf('*') + 1))
                {
                    property.pValue *= int.Parse(text.Substring(text.IndexOf('*') + 1));
                    gProperty = new clsGameProperty(property.Name, "*", property.pValue);
                }
            }
        }
        else if (text.IndexOf('/') != -1)
        {
            foreach (clsGameProperty property in properties)
            {
                if (property.Name == text.Substring(0, text.Length - text.IndexOf('/') + 1))
                {
                    property.pValue /= int.Parse(text.Substring(text.IndexOf('/') + 1));
                    gProperty = new clsGameProperty(property.Name, "/", property.pValue);
                }
            }
        }
        else
        {
            foreach (clsGameProperty property in properties)
            {
                if (property.Name == text.Substring(0, text.Length - text.IndexOf('=') + 1))
                {
                    property.pValue = int.Parse(text.Substring(text.IndexOf('=') + 1));
                    gProperty = new clsGameProperty(property.Name, "=", property.pValue);
                }
            }
        }

        return gProperty;
    }//Complete

}
