using System;
using System.Collections;

public class clsChoiceNum
{
    private string choiceText;
    private int choiceNum;
    private clsResult choiceResult;

    public clsChoiceNum()
    {
        choiceText = "";
        choiceNum = 0;
    }

    public clsChoiceNum(string text, int position)
    {
        choiceText = text;
        choiceNum = position;
    }

    public clsChoiceNum(string text, int position, clsResult result)
    {
        choiceText = text;
        choiceNum = position;
        choiceResult = result;
    }

    public string Text
    {
        get
        {
            return choiceText;
        }
        set
        {
            choiceText = value;
        }
    }

    public int Postion
    {
        get
        {
            return choiceNum;
        }
        set
        {
            choiceNum = value;
        }
    }

    public clsResult Result
    {
        get
        {
            return choiceResult;
        }
        set
        {
            choiceResult = value;
        }
    }
}