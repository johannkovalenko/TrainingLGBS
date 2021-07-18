using System;

public class Company
{
    public Company(int revenue, int expenses)
    {
        this.revenue = revenue;
        this.expenses = expenses;
    }

    public int revenue;
    public int expenses;
}

public static void Main()
{
    //Task: calculate profit of Ford, GM, Chrysler, Volkswagen
    //but each company has own tax law 

    Company ford = new Company(2000, 4000);


}

