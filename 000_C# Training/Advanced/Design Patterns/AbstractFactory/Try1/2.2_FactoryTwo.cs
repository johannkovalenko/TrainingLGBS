public class FactoryTwo : IFactory
{
    public IClassOne GetClassOne()
    {
        return new RealClassB();
    }
}