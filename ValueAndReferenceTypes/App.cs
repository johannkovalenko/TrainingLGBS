class App
{
    public static void Main()
    {
        int 	myInt = 50;
        int[]	myArr = {100, 150, 200};

        Change(myInt, myArr);

        Console.WriteLine(myInt);
        Console.WriteLine(myArr[0]);
    }

    private static void Change(int myInt, int[] myArr)
    {
        myInt 		= 60;
        myArr[0]	= 60;
    }
}	