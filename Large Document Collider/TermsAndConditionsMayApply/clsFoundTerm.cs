public class clsFoundTerm
{
    private string term;
    private int count;
    private int sNum;
    private int pNum;

    public clsFoundTerm()
    {
        term = "";
        count = 0;
        sNum = 0;
        pNum = 0;
    }

    public clsFoundTerm(string word)
    {
        term = word;
        count = 1;
    }

    public clsFoundTerm(string word, int sentNum, int paraNum)
    {
        term = word;
        sNum = sentNum;
        pNum = paraNum;
        count = 1;
    }

    public string Term
    {
        get
        {
            return term;
        }
        set
        {
            term = value;
        }
    }

    public int Count
    {
        get
        {
            return count;
        }
        set
        {
            count = value;
        }
    }

    public int SentNum
    {
        get
        {
            return sNum;
        }
        set
        {
            sNum = value;
        }
    }

    public int ParaNum
    {
        get
        {
            return pNum;
        }
        set
        {
            pNum = value;
        }
    }
}