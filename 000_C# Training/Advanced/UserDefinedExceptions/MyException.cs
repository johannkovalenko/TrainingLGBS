using System;

public class MyException : Exception
{
    public MyException(string msg) : base(msg)
    {
    }
}