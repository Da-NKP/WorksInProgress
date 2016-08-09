using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ClassFileBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList systemUsing;
        private ArrayList systemAttributes;
        private ArrayList systemMethods;
        private ArrayList methodArgs;
        private ArrayList rawInput;
        private ArrayList rawOutput;
        private ArrayList constructStrings;

        private string selectedFileName;

        private void mnuClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit? Your work will not be automatically saved.", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }
            else
            {
                Close();
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd;

            //SaveFileDialog.Filter format (all in quotes): fileTypeName (*.fileExt)|*.fileExt|(repeat for all possibilites)|All Files (*.*)|*.*
            string fileFilter = "Class File (*.cs)|*.cs";

            try
            {
                sfd = new SaveFileDialog();
                sfd.Title = "Select file to save";
                sfd.Filter = fileFilter;
                sfd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    selectedFileName = sfd.FileName;
                }
            }

            catch (Exception ex)
            {
                ShowMessage("The following save error occured: " + ex.Message);
            }
            
            SaveClassFile();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd;

            //OpenFileDialog.Filter format (all in quotes): fileTypeName (*.fileExt)|*.fileExt|(repeat for all possibilites)|All Files (*.*)|*.*
            string fileFilter = "Class File (*.cs)|*.cs";

            try
            {
                ofd = new OpenFileDialog();
                ofd.Title = "Select file to open";
                ofd.Filter = fileFilter;
                ofd.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFileName = ofd.FileName;
                }
            }

            catch (Exception ex)
            {
                ShowMessage("The following load error occured: " + ex.Message);
            }

            ReadClassFile();
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Would you like to save your work?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SaveClassFile();
            }
        }

        private void SaveClassFile()
        {
            if (selectedFileName == "")
            {
                ShowMessage("There was a problem saving to a file: no file specified.");
                return;
            }

            BuildClassFile();

            StreamWriter SW = null;

            try
            {
                SW = new StreamWriter(selectedFileName);

                foreach (string line in rawOutput)
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
        }

        private void ReadClassFile()
        {
            if (selectedFileName == "")
            {
                ShowMessage("There was a problem saving to a file: no file specified.");
                return;
            }

            StreamReader SR = null;

            try
            {
                SR = new StreamReader(selectedFileName);

                string input = SR.ReadLine();

                rawInput = new ArrayList();

                while (input != null)
                {
                    rawInput.Add(input);

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

            ParseToGUI();
        }

        private void BuildClassFile()
        {
            //There are a total of three text boxes in the application. Everything must be built from there.

            string[] usingLines = txtUsing.Text.Split('\n');

            rawOutput.Add("using System;");
            rawOutput.Add("using System.Collections;");

            if (usingLines[0] == "" || (usingLines[0] == "using System;" && usingLines[1] == "using System.Collections;" && usingLines.Length == 2))
            {
                //Ignore
            }
            else
            {
                foreach (string line in usingLines)
                {
                    rawOutput.Add(line.Trim() + ";");
                }
            }

            string[] attLines = txtAttributes.Text.Split('\n');

            string className = selectedFileName.Substring(0, selectedFileName.IndexOf('.'));
            className = className.Substring(className.LastIndexOf('\\'));
            className = className.Substring(1);

            rawOutput.Add("public class " + className + "\n{");

            foreach (string line in attLines)
            {
                if (line != "")
                {
                    string[] temp = line.Split(' ');

                    rawOutput.Add("private " + temp[0].Trim() + " " + temp[1].Trim() + ";");
                }
            }

            string[] mLines = txtMethods.Text.Split('\n');

            foreach (string line in mLines)
            {
                if (line.Trim() == "")
                {
                    //Ignore
                }
                else if (line.Trim() == "NULL")
                {
                    rawOutput.Add("public " + className + "()\n{");

                    foreach (string att in attLines)
                    {
                        string[] temp = att.Split(' ');
                        string type = "";
                        string value = "";
                        
                        if (att != "")
                        {
                            type = temp[0].Trim();
                            value = temp[1].Trim();
                        }

                        if (type == "int")
                        {
                            rawOutput.Add(value + "=" + "0;");
                        }
                        else if (type == "string")
                        {
                            rawOutput.Add(value + "=" + "\"\";");
                        }
                        else if (type == "decimal")
                        {
                            rawOutput.Add(value + "=" + "0.0;");
                        }
                        else if (type == "double")
                        {
                            rawOutput.Add(value + "=" + "0.0;");
                        }
                        else
                        {
                            ShowMessage("There was an issue processing the type " + type);
                        }
                    }

                    rawOutput.Add("}");
                }
                else
                {
                    string[] mArgs = line.Split(',');

                    string methodLine = "public " + className + "(";

                    for (int i = 0; i < attLines.Length; i++)
                    {
                        methodLine += attLines[i].Substring(0, attLines[i].IndexOf(' ')).Trim() + " " + mArgs[i].Trim() + ",";
                    }

                    methodLine = methodLine.Substring(0, methodLine.Length - 1) + ")\n{";

                    rawOutput.Add(methodLine);

                    for (int i = 0; i < attLines.Length; i++)
                    {
                        rawOutput.Add(attLines[i].Substring(attLines[i].IndexOf(' ')).Trim() + "=" + mArgs[i].Trim() + ";");
                    }

                    rawOutput.Add("}");
                }
            }

            foreach (string line in attLines)
            {
                string[] temp = line.Split(' ');
                string type = temp[0].Trim();
                string name = temp[1].Trim();
                string value = name;
                string space = " ";
                name = name.Substring(0,1).ToUpper() + name.Substring(1);

                string outLine = "public" + space + type + space + name + "\n{\nset\n{\n" + value + "=value;\n}\nget\n{\nreturn" + space + value + ";\n}\n}";

                rawOutput.Add(outLine);
            }


            rawOutput.Add("}");
        }

        private void ParseToGUI() //There is still work to be done in terms of handling method importation
        {
            bool usingStatments = true;
            
            foreach (string line in rawInput)
            {
                if (line == "\n" || line == "" || line.Trim() == "{" || line.Trim() == "}") //The parser can just skip stuffs :D
                {
                    //
                }
                else if (line.IndexOf("get") != -1 || line.IndexOf("set") != -1)
                {
                    break;
                }
                else if (usingStatments && line.Substring(0, 5) == "using")
                {
                    systemUsing.Add(line.Substring(6, line.Length - 7));
                }
                else if (line.Trim().Substring(0, 7) == "private")
                {
                    string text = line.Trim().Substring(8);
                    string name = text.Substring(text.IndexOf(' '));
                    string type = text.Substring(0, text.Length - name.Length + 1);

                    systemAttributes.Add(new clsAttribute(name, type));
                }
                else if (line.IndexOf("public " + selectedFileName) == -1)
                {
                    constructStrings.Add(line);
                }
                else if (line.IndexOf('=') != -1)
                {
                    string text = line.Trim().Substring(0, line.Length - 1);
                    string attName = text.Substring(0, text.IndexOf('=') - 2);
                    string mRef = text.Substring(text.IndexOf('=') + 2);

                    foreach (clsAttribute att in systemAttributes)
                    {
                        if (att.Name == attName)
                        {
                            systemMethods.Add(new clsMethod(mRef, att));
                        }
                    }
                }
                else
                {
                    //Ignore
                }
                
            }

            foreach (string item in systemUsing)
            {
                txtUsing.Text += item + Environment.NewLine;
            }

            foreach (clsAttribute item in systemAttributes)
            {
                txtAttributes.Text += item.Type + " " + item.Name + Environment.NewLine;
            }

            int[] pMethods = new int[systemMethods.Count];

            foreach (string cMethod in constructStrings)
            {

                if (cMethod.IndexOf('=') != -1)
                {
                    //txtMethods.Text += cMethod.Substring(0, cMethod.IndexOf(';')).Trim() + Environment.NewLine;//Useless
                }
                else if (/*cMethod.IndexOf("//") != -1 || */cMethod.IndexOf("class") != -1 || cMethod.IndexOf("#region") != -1 || cMethod.IndexOf("#endregion") != -1)
                {
                    //Ignore
                }
                else if (cMethod.IndexOf("get") != -1 || cMethod.IndexOf("set") != -1 || cMethod.IndexOf('(') == -1)
                {
                    //Ignore
                }
                else
                {
                    txtMethods.Text += Environment.NewLine;

                    string methodRef = "NULL";

                    if (cMethod.IndexOf("()") == -1)
                    {
                        methodRef = cMethod.Substring(cMethod.IndexOf('(') + 1);

                        methodRef = methodRef.Substring(0, methodRef.IndexOf(')'));
                    }

                    //txtMethods.Text += methodRef.Trim() + Environment.NewLine;//clsAttribute Reference

                    //this is the part where you retrieve items inside the Method argument (aka, the only thing used by the constructor)

                    string[] methodArgs = methodRef.Split(',');

                    for (int i = 0; i < methodArgs.Length; i++)
                    {
                        methodArgs[i] = methodArgs[i].Trim();
                        methodArgs[i] = methodArgs[i].Substring(methodArgs[i].IndexOf(' ') + 1);
                    }

                    foreach (string arg in methodArgs)
                    {
                        if (arg != methodArgs[methodArgs.Length -1])
                        {
                            txtMethods.Text += arg + ",";
                        }
                        else
                        {
                            txtMethods.Text += arg;
                        }
                    }

                    txtMethods.Text += Environment.NewLine;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            systemAttributes = new ArrayList();
            systemMethods = new ArrayList();
            systemUsing = new ArrayList();
            constructStrings = new ArrayList();
            methodArgs = new ArrayList();
            rawOutput = new ArrayList();
        }
    }
}
