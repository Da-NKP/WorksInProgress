using System;
using System.Windows.Forms;
/*
 * Bill Hall
 * CNIT255 Lab#
 * 
 * Description: 
 * 
 * Code Statement:
 * 
*/
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

    #region Validation Stuffs
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


}
