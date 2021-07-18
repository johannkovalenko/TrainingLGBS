public class MyClass
{
    public event MyEventHandler OnMaximum;
    private int i;
    private int Maximum = 10;
    public int MyValue
    {
        get
        { return i;}
        set
        {
            if(value <= Maximum)
                i = value;
            else if(OnMaximum != null)
                OnMaximum(this, new MyEventArgs(value.ToString() + Maximum.ToString());
        }
    }
}
