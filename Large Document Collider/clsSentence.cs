using System;
using System.Collections;

public class clsSentence
{
    Arraylist terms;
    
    public clsSentence()
    {
        terms = new Arraylist();
    }

    public clsSentence(Arraylist temp)
    {
        foreach (clsFoundTerm term in temp)
        {
            terms.Add(term);
        }
    }

    public Arraylist Terms
    {
        get
        {
            return terms;
        }
        set
        {
            terms = value;
        }
    }

}