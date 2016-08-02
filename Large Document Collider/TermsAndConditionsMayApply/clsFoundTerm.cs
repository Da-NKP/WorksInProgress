public class clsFoundTerm
{
    private string term;
    private int count;

    public clsFoundTerm()
    {
        term = "";
        count = 0;
    }

    public clsFoundTerm(string word)
    {
        term = word;
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

}