class ItalianVehicles : IVehicles
{
    public ICar BuildCar()
    {
        return new AlfaRomeo();
    }

    public IMotocycle BuildMotocycle()
    {
        return new Ducati();
    }
}