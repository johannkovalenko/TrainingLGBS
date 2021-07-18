public class MyArrayClass
{
    string[] values = new string[100];

    public string this[int number]
    {
        get {return values[number];}
        set {values[number] = value;}
    }
}