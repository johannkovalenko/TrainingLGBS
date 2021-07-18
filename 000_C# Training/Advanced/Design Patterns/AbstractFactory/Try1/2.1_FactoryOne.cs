public class FactoryOne : IFactory
{
    public IClassOne GetClassOne()
    {
        return new RealClassA();
    }
}