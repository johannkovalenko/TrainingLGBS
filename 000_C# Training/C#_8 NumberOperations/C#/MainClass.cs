using System;

class MainClass
{
    public static void Main()
    {
        PowerOfNumber();
        RootOfNumber();
        ModuloOfDivision();
        ModuloPerformJumpsOfSeven();
        GetDecimalPartOfNumber();
        RoundingNumbers();
        AlwaysRoundDown();
        AlwaysRoundUp();
        RoundToFirstDecimalPart();
        UsingSinusAndCosinus();
        Pythagoras();
        AbsoluteValue();
        
        Console.ReadLine();
    }

    public static void PowerOfNumber()
    {
        int myInt = 5;
        int myPowerOfTwo = (int)Math.Pow(myInt, 2);
        Console.WriteLine(myPowerOfTwo);

        int myPowerOfThree = (int)Math.Pow(myInt, 3);
        Console.WriteLine(myPowerOfThree);
    }

    public static void RootOfNumber()
    {
        int myInt = 81;

        double mySquareRoot = Math.Sqrt(myInt);
        Console.WriteLine(mySquareRoot);

        myInt = 125;

        double myCubicRoot = Math.Pow(myInt, (double)1/3);
        Console.WriteLine(myCubicRoot);
    } 

    public static void ModuloOfDivision()
    {
        int modulo = 83 % 9;
        Console.WriteLine(modulo);
    }

    public static void ModuloPerformJumpsOfSeven()
    {
        int modulo = 0;

        for (int i=0;i<50;i++)
        {
            modulo = i % 7;

            if (modulo == 0)
                Console.WriteLine(i);
            else
                Console.WriteLine("x");
        }
    }

    public static void GetDecimalPartOfNumber()
    {
        double myDouble = 7.39596;
        int integerOfDouble = (int)myDouble;

        double myDecimalPart = myDouble - integerOfDouble;

        Console.WriteLine(integerOfDouble);
        Console.WriteLine(myDecimalPart);
    }

    public static void RoundingNumbers()
    {
        double myDouble = 7.49;

        int roundedDouble = (int)(myDouble + 0.5);

        Console.WriteLine(roundedDouble);

        myDouble = 7.50;

        roundedDouble = (int)(myDouble + 0.5);

        Console.WriteLine(roundedDouble);
    }

    public static void AlwaysRoundDown()
    {
        double myDouble = 7.49;

        int roundedDouble = (int)myDouble;

        Console.WriteLine(roundedDouble);

        myDouble = 7.50;

        roundedDouble = (int)myDouble;

        Console.WriteLine(roundedDouble);
    }

    public static void AlwaysRoundUp()
    {
        double myDouble = 7.49;

        int roundedDouble = (int)(myDouble + 1);

        Console.WriteLine(roundedDouble);

        myDouble = 7.50;

        roundedDouble = (int)(myDouble + 1);

        Console.WriteLine(roundedDouble);
    }

    public static void RoundToFirstDecimalPart()
    {
        double myDouble = 7.349;

        double roundedDouble = (double)((int)(myDouble * 10 + 0.5)) / 10;
        Console.WriteLine(roundedDouble);

        myDouble = 7.350;

        roundedDouble = (double)((int)(myDouble * 10 + 0.5)) / 10;
        Console.WriteLine(roundedDouble);
    }

    public static void UsingSinusAndCosinus()
    {
        // When walking 1 unit from the center with a 45 degree angle, 
        // your karthesian coordinates will be 0.71/0.71 and not 1/1!!

        double xCoor = Math.Sin(Math.PI * 45 / 180.0);
        double yCoor = Math.Cos(Math.PI * 45 / 180.0);

        Console.WriteLine(xCoor + "\t" + yCoor);

        xCoor = Math.Sin(Math.PI * 90 / 180.0);
        yCoor = Math.Cos(Math.PI * 90 / 180.0);

        Console.WriteLine(xCoor + "\t" + yCoor);
    }

    public static void Pythagoras()
    {
        // The distance from the point 0/0 to the point 2/2 is not 2, it is 2.83
        
        int xCoor = 2;
        int yCoor = 2;

        double distance = Math.Sqrt(Math.Pow(xCoor, 2) + Math.Pow(yCoor, 2));
        Console.WriteLine(distance);

    }

    public static void AbsoluteValue()
    {
        double myDouble = -45.45;
        double myAbsoluteDouble = Math.Abs(myDouble);

        Console.WriteLine(myAbsoluteDouble);
    }

}