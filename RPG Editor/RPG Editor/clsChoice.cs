using System;
using System.Collections;

public class clsChoice
{
    private int numChoice;
    private string initText;
    private clsChoiceNum choiceOne;
    private clsChoiceNum choiceTwo;
    private clsChoiceNum choiceThree;
    private clsChoiceNum choiceFour;
    private clsChoiceNum choiceFive;
    private clsChoiceNum choiceSix;

    public clsChoice()
    {
        initText = "";
    }

    public clsChoice(string text, int number, clsChoiceNum one, clsChoiceNum two)
    {
        initText = text;
        choiceOne = one;
        choiceTwo = two;
        numChoice = number;
    }

    public clsChoice(string text, int number, clsChoiceNum one, clsChoiceNum two, clsChoiceNum three)
    {
        choiceOne = one;
        choiceTwo = two;
        choiceThree = three;
        initText = text;
        numChoice = number;
    }

    public clsChoice(string text, int number, clsChoiceNum one, clsChoiceNum two, clsChoiceNum three, clsChoiceNum four)
    {
        choiceOne = one;
        choiceTwo = two;
        choiceThree = three;
        choiceFour = four;
        initText = text;
        numChoice = number;
    }

    public clsChoice(string text, int number, clsChoiceNum one, clsChoiceNum two, clsChoiceNum three, clsChoiceNum four, clsChoiceNum five)
    {
        choiceOne = one;
        choiceTwo = two;
        choiceThree = three;
        choiceFour = four;
        choiceFive = five;
        initText = text;
        numChoice = number;
    }

    public clsChoice(string text, int number, clsChoiceNum one, clsChoiceNum two, clsChoiceNum three, clsChoiceNum four, clsChoiceNum five, clsChoiceNum six)
    {
        choiceOne = one;
        choiceTwo = two;
        choiceThree = three;
        choiceFour = four;
        choiceFive = five;
        choiceSix = six;
        initText = text;
        numChoice = number;
    }

    public int Count
    {
        get
        {
            return numChoice;
        }
        set
        {
            numChoice = value;
        }
    }

    public string Text
    {
        get
        {
            return initText;
        }
        set
        {
            initText = value;
        }
    }

    public clsChoiceNum One
    {
        get
        {
            return choiceOne;
        }
        set
        {
            choiceOne = value;
        }
    }

    public clsChoiceNum Two
    {
        get
        {
            return choiceTwo;
        }
        set
        {
            choiceTwo = value;
        }
    }

    public clsChoiceNum Three
    {
        get
        {
            return choiceThree;
        }
        set
        {
            choiceThree = value;
        }
    }

    public clsChoiceNum Four
    {
        get
        {
            return choiceFour;
        }
        set
        {
            choiceFour = value;
        }
    }

    public clsChoiceNum Five
    {
        get
        {
            return choiceFive;
        }
        set
        {
            choiceFive = value;
        }
    }

    public clsChoiceNum Six
    {
        get
        {
            return choiceSix;
        }
        set
        {
            choiceSix = value;
        }
    }
}