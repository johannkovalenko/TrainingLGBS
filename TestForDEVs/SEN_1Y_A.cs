// Below code shows the Factory pattern. 
// Modify the code so that it presents the Strategy pattern.

class SEN_1Y_A
{
    public void Run()
    {
        bool mode = true;

        ICar car = Initialize(mode);

        car.Run();
    }

    private ICar Initialize(bool mode)
    {
        switch (mode)
        {
            case true:
                return new Hyundai();
            default:
                return new Kia();
        }
    }
}

interface ICar
{
    void Run();
}

class Hyundai : ICar
{
    public void Run() 
    {
        System.Console.WriteLine("Hyundai");
    }
}


class Kia : ICar
{
    public void Run() 
    {
        System.Console.WriteLine("Kia");
    }
}