import java.util.Scanner;

class MainClass
{
    public static void main(String[] args)
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
        
        new Scanner(System.in).nextLine();
    }

    public static void PowerOfNumber()
    {
        int myInt = 5;
        int myPowerOfTwo = (int)Math.pow(myInt, 2);
        System.out.println(myPowerOfTwo);

        int myPowerOfThree = (int)Math.pow(myInt, 3);
        System.out.println(myPowerOfThree);
    }

    public static void RootOfNumber()
    {
        int myInt = 81;

        double mySquareRoot = Math.sqrt(myInt);
        System.out.println(mySquareRoot);

        myInt = 125;

        double myCubicRoot = Math.pow(myInt, (double)1/3);
        System.out.println(myCubicRoot);
    } 

    public static void ModuloOfDivision()
    {
        int modulo = 83 % 9;
        System.out.println(modulo);
    }

    public static void ModuloPerformJumpsOfSeven()
    {
        int modulo = 0;

        for (int i=0;i<50;i++)
        {
            modulo = i % 7;

            if (modulo == 0)
                System.out.println(i);
            else
                System.out.println("x");
        }
    }

    public static void GetDecimalPartOfNumber()
    {
        double myDouble = 7.39596;
        int integerOfDouble = (int)myDouble;

        double myDecimalPart = myDouble - integerOfDouble;

        System.out.println(integerOfDouble);
        System.out.println(myDecimalPart);
    }

    public static void RoundingNumbers()
    {
        double myDouble = 7.49;

        int roundedDouble = (int)(myDouble + 0.5);

        System.out.println(roundedDouble);

        myDouble = 7.50;

        roundedDouble = (int)(myDouble + 0.5);

        System.out.println(roundedDouble);
    }

    public static void AlwaysRoundDown()
    {
        double myDouble = 7.49;

        int roundedDouble = (int)myDouble;

        System.out.println(roundedDouble);

        myDouble = 7.50;

        roundedDouble = (int)myDouble;

        System.out.println(roundedDouble);
    }

    public static void AlwaysRoundUp()
    {
        double myDouble = 7.49;

        int roundedDouble = (int)(myDouble + 1);

        System.out.println(roundedDouble);

        myDouble = 7.50;

        roundedDouble = (int)(myDouble + 1);

        System.out.println(roundedDouble);
    }

    public static void RoundToFirstDecimalPart()
    {
        double myDouble = 7.349;

        double roundedDouble = (double)((int)(myDouble * 10 + 0.5)) / 10;
        System.out.println(roundedDouble);

        myDouble = 7.350;

        roundedDouble = (double)((int)(myDouble * 10 + 0.5)) / 10;
        System.out.println(roundedDouble);
    }

    public static void UsingSinusAndCosinus()
    {
        // When walking 1 unit from the center with a 45 degree angle, 
        // your karthesian coordinates will be 0.71/0.71 and not 1/1!!

        double xCoor = Math.sin(Math.PI * 45 / 180.0);
        double yCoor = Math.cos(Math.PI * 45 / 180.0);

        System.out.println(xCoor + "\t" + yCoor);

        xCoor = Math.sin(Math.PI * 90 / 180.0);
        yCoor = Math.cos(Math.PI * 90 / 180.0);

        System.out.println(xCoor + "\t" + yCoor);
    }

    public static void Pythagoras()
    {
        // The distance from the point 0/0 to the point 2/2 is not 2, it is 2.83
        
        int xCoor = 2;
        int yCoor = 2;

        double distance = Math.sqrt(Math.pow(xCoor, 2) + Math.pow(yCoor, 2));
        System.out.println(distance);

    }

    public static void AbsoluteValue()
    {
        double myDouble = -45.45;
        double myAbsoluteDouble = Math.abs(myDouble);

        System.out.println(myAbsoluteDouble);
    }

}