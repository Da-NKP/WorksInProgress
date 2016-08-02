using System;
using System.Collections;

public class clsResult
{
    private string resultType;
    private string resultValue;
    private clsGameProperty resultProperty;

    public clsResult(clsGameProperty rProperty)
    {
        resultType = "property";
        resultProperty = rProperty;
    }

    public clsResult(string rValue)
    {
        resultType = "string";
        resultValue = rValue;
    }

    public clsResult(string rValue, clsGameProperty rProperty)
    {
        resultType = "both";
        resultValue = rValue;
        resultProperty = rProperty;
    }

    public string Type
    {
        get
        {
            return resultType;
        }
        set
        {
            resultType = value;
        }
    }

    public string rValue
    {
        get
        {
            return resultValue;
        }
        set
        {
            resultValue = value;
        }
    }

    public clsGameProperty Property
    {
        get
        {
            return resultProperty;
        }
        set
        {
            resultProperty = value;
        }
    }
}