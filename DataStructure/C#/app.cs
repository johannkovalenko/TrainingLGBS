using System;

class App
{
    static void Main()
    {
        var employee = new Employee();
        
        employee.personal.name  = "Paul";
        employee.personal.age   = 25;
        employee.salary.raise   = true;
        employee.salary.taxCode = TaxCode.MIDDLEINCOME;

        var empShort = new EmpShort("Mike", new DateTime(1989, 1, 30), 4000.00);
        empShort.net    = 3000.00;
        empShort.gross  = 4050.00;
    }
}