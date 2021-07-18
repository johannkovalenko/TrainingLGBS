class app
{
    static void Main()
    {
        //Level 1: Inheritance wins
        new Composition1.Main().Run();
        new Inheritance1.Main().Run();

        //Level 2: Composition wins
        new Composition2.Main().Run();
        new Inheritance2.Main().Run();
    }
}