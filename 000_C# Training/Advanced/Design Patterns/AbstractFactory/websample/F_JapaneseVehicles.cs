class JapaneseVehicles : IVehicles
{
    public ICar BuildCar()
    {
        return new Toyota();
    }

    public IMotocycle BuildMotocycle()
    {
        return new Yamaha();
    }
}