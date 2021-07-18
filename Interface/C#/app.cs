using BirdChant;

class App
{
    static void Main()
    {
        IBird myBird = FactoryMethod(0);
        myBird.Sing();

        IBird[] birds = {new Sparrow(), new Mockingbird()};

        foreach (IBird bird in birds)
            bird.Sing();
    }

    private static IBird FactoryMethod(int number)
    {
        switch(number)
        {
            case 0:
                return new Sparrow();
            case 1:
                return new Mockingbird();
            default:
                return new Sparrow();
        }
    }
}

