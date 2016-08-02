using System;
using System.Collections;

public class clsGameProperty
{
    private string propertyName;
    private string propertyOperation;
    private int propertyValue;

    public clsGameProperty(string name, string operation, int pValue)
    {
        propertyName = name;
        propertyOperation = operation;
        propertyValue = pValue;
    }

    public string Name
    {
        get
        {
            return propertyName;
        }
        set
        {
            propertyName = value;
        }
    }

    public string Operation
    {
        get
        {
            return propertyOperation;
        }
        set
        {
            propertyOperation = value;
        }
    }

    public int pValue
    {
        get
        {
            return propertyValue;
        }
        set
        {
            propertyValue = value;
        }
    }
}