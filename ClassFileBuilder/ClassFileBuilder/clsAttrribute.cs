using System;
using System.Collections;

public class clsAttribute
{
    private string attributeName;
    private string attributeType;
    //private string attributeAccess;

    public clsAttribute(string name, string type)
    {
        attributeName = name;
        attributeType = type;
    }

    public string Name
    {
        get
        {
            return attributeName;
        }
        set
        {
            attributeName = value;
        }
    }

    public string Type
    {
        get
        {
            return attributeType;
        }
        set
        {
            attributeType = value;
        }
    }
}