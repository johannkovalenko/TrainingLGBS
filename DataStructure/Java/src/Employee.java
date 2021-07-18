public class Employee {
    public Personal personal    = new Personal();
    public Salary   salary      = new Salary();

    public class Personal {
        public String name = "";
        public int age = 0;
    }

    public class Salary {
        public boolean raise = false;
        public TaxCode taxCode = TaxCode.LOWINCOME;
    }
}