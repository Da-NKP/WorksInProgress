using System;
using System.IO;
using System.Windows.Forms;

public partial class frmMain : Form
{
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
    }

    #region Helper Methods Defaults

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

    //public variables that are practically essential to making the game 
    //actually work the way i hope it will *************************
    //these are top stats
    private string playerName;
    private string playerRace;
    private double playerHealth;
    #region Even More Stats
    //these are all the other simple stats
    private double playerIntelligence;
    private double playerExplosion;
    private double playerGuns;
    private double playerRepair;
    private double playerSneak;
    private double playerPerception;
    private double playerCharisma;
    private double playerBarter;
    private double playerEWeapons;
    private double playerMedical;
    private double playerLockPick;
    private double playerCarry;
    private double playerEndurance;
    private double playerAgility;
    private double playerSpeak;
    private double playerStrength;
    private double playerMelee;
    private double playerScience;
    private double playerSurvival;
    //these are the really long stats
    private string playerLongBio;
    private string playerLongPerks;
    private string playerLongTraits;
    private string playerLongSpells;
    private string playerLongItems;
    #endregion
    //these are system global variables
    private bool isReadOnly = true;
    private bool isDataReady = false;
    private bool isFileExist;
    private string externalFile = Path.Combine(Application.StartupPath, "specsheet.txt");
    private TextBox[] specData;
    private double[] specVar;
    private string[] specLong;

    //Load a pre-existing spec sheet into the stats area DONE
    //There is a fatal error that involves some part of the external database
    private void frmMain_Load(object sender, EventArgs e)
    {
        #region TextBox Array specData
        specData = new TextBox[20] {txtHP, txtCarry, txtStrength, txtPerception, txtEndurance, txtIntelligence, txtCharisma, txtAgility, txtExplosion, txtBarter, txtSpeak, txtGuns, txtElectricWeapons, txtMelee, txtRepair, txtMedicine, txtScience, txtSneak, txtLockPick, txtSurvival};
        #endregion
       
        #region Double Array specVar
        specVar = new double[20] {playerHealth, playerCarry, playerStrength, playerPerception, playerEndurance, playerIntelligence, playerCharisma, playerAgility, playerExplosion, playerBarter, playerSpeak, playerGuns, playerEWeapons, playerMelee, playerRepair, playerMedical, playerScience, playerSneak, playerLockPick, playerSurvival };
        #endregion

        #region String Array specLong
        specLong = new string[5] { playerLongBio, playerLongPerks, playerLongTraits, playerLongSpells, playerLongItems };
        #endregion

        //look up external stuff again

        string line;
        StreamReader SR = null;

        try
        {
            if (!File.Exists(externalFile))//if not create the file to be used later
            {
                isFileExist = false;
                return;
            }

            isFileExist = true;

            SR = new StreamReader(externalFile);

            line = SR.ReadLine();

            string[] placeholder = line.Split('\t');
            int mIndexSpare = placeholder.Length;

            /*
            while (line != null)
            {
                
            }
            */

            playerName = placeholder[0];
            txtName.Text = playerName;

            playerRace = placeholder[1];
            txtRace.Text = playerRace;

            int counter = 0;

            for (int i = 2; i < mIndexSpare - 5; i++)
            {
                specData[counter].Text = placeholder[i];
                specVar[counter] = double.Parse(placeholder[i]);

                counter++;
            }

            counter = 0;

            for (int i = 22; i < mIndexSpare; i++)
            {
                specLong[counter] = placeholder[i];

                counter++;
            }

            NewLineToChar(false);

            for (int i = 0; i < specLong.Length; i++)
            {
                switch (i)
                {
                    case 22:
                        playerLongBio = specLong[i];
                        break;
                    case 23:
                        playerLongPerks = specLong[i];
                        break;
                    case 24:
                        playerLongTraits = specLong[i];
                        break;
                    case 25:
                        playerLongSpells = specLong[i];
                        break;
                    case 26:
                        playerLongItems = specLong[i];
                        break;
                    default:
                        break;
                }
            }



        }
        catch (Exception ex)
        {
            ShowMessage(ex.Message);
        }
        finally
        {
            if (isFileExist)
            {
                SR.Close();
            }
        }

    }


    private void NewLineToChar(bool isToFile)
    {
        if (isToFile)
        {
            for (int i = 0; i < specLong.Length; i++)
            {
                string item = specLong[i];
                int nlIndex = item.IndexOf('\n');

                while (nlIndex != -1)
                {
                    item = item.Substring(0, nlIndex - 1) + "[NewLineToChar]" + item.Substring(nlIndex + 1);
                }

                specLong[i] = item;
            }
        }
        else
        {
            for (int i = 0; i < specLong.Length; i++)
            {
                string item = specLong[i];
                int nlIndex = item.IndexOf('\n');

                while (nlIndex != -1)
                {
                    item = item.Substring(0, nlIndex - 1) + "\n" + item.Substring(nlIndex + 15);
                }

                specLong[i] = item;
            }
        }
    }


    //Save all of the Data to Spec sheet DONE
    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        //look up external stuff again

        specLong[0] = playerLongBio;
        specLong[1] = playerLongPerks;
        specLong[2] = playerLongTraits;
        specLong[3] = playerLongSpells;
        specLong[4] = playerLongItems;

        NewLineToChar(true);

        StreamWriter SW = null;

        try
        {
            SW = new StreamWriter(externalFile);

            string textDump = "";

            textDump = playerName + "\t" + playerRace;

            for (int i = 0; i < specVar.Length; i++)
            {
                textDump += "\t" + specVar[i];
            }

            for (int i = 0; i < specLong.Length; i++)
            {
                textDump += "\t" + specLong[i];
            }

            SW.WriteLine(textDump);
        }
        catch (Exception ex)
        {
            ShowMessage(ex.Message);
        }
        finally
        {
            SW.Close();
        }
    }



    //Provide extra detail about certain character attributes
    private void btnDisplayDetail_Click(object sender, EventArgs e)
    {
        if (radBio.Checked)
        {
            txtMainDisplay.Text = playerLongBio;
            radBio.Checked = false;
        }
        else if (radSpells.Checked)
        {
            txtMainDisplay.Text = playerLongSpells;
            radSpells.Checked = false;
        }
        else if (radTraits.Checked)
        {
            txtMainDisplay.Text = playerLongTraits;
            radTraits.Checked = false;
        }
        else if (radPerks.Checked)
        {
            txtMainDisplay.Text = playerLongPerks;
            radPerks.Checked = false;
        }
        else if (radItems.Checked)
        {
            txtMainDisplay.Text = playerLongItems;
            radItems.Checked = false;
        }
        else
        {
            ShowMessage("Please select an option.");
            return;
        }
    }



    //Built in Roll function. Simple enought DONE
    private void btnRoll_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        int randomNumber = 0;
        
        if (radD6.Checked)
        {
            randomNumber = random.Next(0, 7);
        }
        else if (radD20.Checked)
        {
            randomNumber = random.Next(0, 21);
        }
        else if (radD100.Checked)
        {
            randomNumber = random.Next(0, 101);
        }
        else
        {
            ShowMessage("Please choose which die to roll.");
            return;
        }

        txtRoll.Text = randomNumber.ToString();
    }

    

    //Check to see if a skill is enough for a task DONE
    private void btnCalcSuccess_Click(object sender, EventArgs e)
    {
        double result = 0;
        double skill = 0;
        double task = 0;

        if (!validateInput(txtSkill, 0, 100, out skill) || !validateInput(txtTaskDifficulty, 0, 200, out task))
        {
            return;
        }

        result = (skill / task) * 100;

        if (result > 100)
        {
            result = 100;
        }

        txtChanceSuccess.Text = result.ToString("n") + "%";
    }



    //Provides with some help for the program DONE
    private void btnSupport_Click(object sender, EventArgs e)
    {
        #region Large String Values
        string autoSave = "This program features AutoSave. Before the program exits, all current data is saved to the external database. This database is a simple text file with a custom extention and a dump of the game data, data entries are separated by the TAB character. That means that, under no circumstances EVER should you EVER put a TAB in ANY field entry EVER. AutoLoad also exists, but only if there is current data.";
        string manualImport = "This program will give you the option to either provide a datasheet externally or simply enter all of the stats manually. While it can be done in-game, it is advised that game data is added manually. Simply make a txt file called 'specsheet.database' where the extension is literally 'database'. Then enter one item after another with a TAB separating each entry.";
        string support = "This program was made by some kid who is a friend of the Game Master. Please do not completely rely on this program; it is only to assist the player. Make regualar backups of the 'specsheet.database' file, which contains all of your character's information. Functions and items are self explanatory, but if you require assistance, send an email to 'macman540@gmail.com' with the subject being 'Pony game helper app' and then put the problem/concern in the subject window.";
        #endregion

        if (radAutoSave.Checked)
        {
            txtMainDisplay.Text = autoSave;
        }
        else if (radManualImport.Checked)
        {
            txtMainDisplay.Text = manualImport;
        }
        else if (radSupportProgram.Checked)
        {
            txtMainDisplay.Text = support;
        }
        else
        {
            ShowMessage("Please select an option.");
            return;
        }
    }



    //Provides Game Reference Material NOT DONE
    private void btnRefernce_Click(object sender, EventArgs e)
    {
        //Get Reference Data from Link-Sempai
    }



    //This button allows the user to switch the read-only setting of the text boxes DONE
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        int specLength = specData.Length;
        if (!radBio.Checked && !radPerks.Checked && !radSpells.Checked && !radTraits.Checked && !radItems.Checked)
        {
            if (isReadOnly)
            {
                if (MessageBox.Show("You may now edit any of the Specs. Hit 'Update' again once you are done. If there is an error, you be asked to try again.", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtName.ReadOnly = false;
                    txtRace.ReadOnly = false;

                    for (int i = 0; i < specLength; i++)
                    {
                        specData[i].ReadOnly = false;
                    }


                    isReadOnly = false;
                }
            }
            else
            {
                //check all text boxes, set new values, set readonly, reset readonly

                if (!validateInput(txtName, out playerName) || !validateInput(txtRace, out playerRace))
                {
                    return;
                }

                txtName.ReadOnly = true;
                txtRace.ReadOnly = true;

                for (int i = 0; i < specLength; i++)
                {
                    if (!validateInput(specData[i], 0.0, 100.0, out specVar[i]))
                    {
                        return;
                    }

                    specData[i].ReadOnly = true;

                }
                isReadOnly = true;
            }
        }
        //Allow for the user to input awesome detailed stuffs
        else
        {
            if (radBio.Checked)
            {
                if (isDataReady)
                {
                    txtMainDisplay.Text = txtSkillSheet.Text;
                    playerLongBio = txtSkillSheet.Text;
                    radBio.Checked = false;
                    isDataReady = false;
                }
                else
                {
                    txtSkillSheet.Text = playerLongBio;
                    ShowMessage("You may now enter a value for Bio.");
                    isDataReady = true;
                }
            }
            else if (radSpells.Checked)
            {
                if (isDataReady)
                {
                    txtMainDisplay.Text = txtSkillSheet.Text;
                    playerLongSpells = txtSkillSheet.Text;
                    radSpells.Checked = false;
                    isDataReady = false;
                }
                else
                {
                    txtSkillSheet.Text = playerLongSpells;
                    ShowMessage("You may now enter a value for Spells.");
                    isDataReady = true;
                }
            }
            else if (radTraits.Checked)
            {
                if (isDataReady)
                {
                    txtMainDisplay.Text = txtSkillSheet.Text;
                    playerLongTraits = txtSkillSheet.Text;
                    radTraits.Checked = false;
                    isDataReady = false;
                }
                else
                {
                    txtSkillSheet.Text = playerLongTraits;
                    ShowMessage("You may now enter a value for Traits.");
                    isDataReady = true;
                }
            }
            else if (radPerks.Checked)
            {
                if (isDataReady)
                {
                    txtMainDisplay.Text = txtSkillSheet.Text;
                    playerLongPerks = txtSkillSheet.Text;
                    radPerks.Checked = false;
                    isDataReady = false;
                }
                else
                {
                    txtSkillSheet.Text = playerLongPerks;
                    ShowMessage("You may now enter a value for Skills.");
                    isDataReady = true;
                }
            }
            else if (radItems.Checked)
            {
                if (isDataReady)
                {
                    txtMainDisplay.Text = txtSkillSheet.Text;
                    playerLongItems = txtSkillSheet.Text;
                    radItems.Checked = false;
                    isDataReady = false;
                }
                else
                {
                    txtSkillSheet.Text = playerLongItems;
                    ShowMessage("You may now enter a value for Items.");
                    isDataReady = true;
                }
            }
            else
            {
                return;
            }
        }
    }

}
