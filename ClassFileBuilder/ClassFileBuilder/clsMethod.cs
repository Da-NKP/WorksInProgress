using System;
using System.Collections;

public class clsMethod
{
    private string referenceName;
    private clsAttribute referenceAttribute;

    public clsMethod(string refName, clsAttribute refAttribute)
    {
        referenceName = refName;
        referenceAttribute = refAttribute;
    }

    public string rName
    {
        get
        {
            return referenceName;
        }
        set
        {
            referenceName = value;
        }
    }

    public clsAttribute rAttribute
    {
        get
        {
            return referenceAttribute;
        }
        set
        {
            referenceAttribute = value;
        }
    }
}