class Employee
{
    public Personal personal    = new Personal();
    public Salary   salary      = new Salary();

    public class Personal
    {
        public string name = "";
        public int age = 0;
    }

    public class Salary
    {
        public bool raise = false;
        public TaxCode taxCode = TaxCode.LOWINCOME;
    }
}