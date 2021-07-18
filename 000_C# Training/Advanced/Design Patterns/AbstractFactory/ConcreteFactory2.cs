public class ConcreteFactory2 : IFactory
{
    public IClassOne BuildClassOne()
    {
        return new ConcreteClassOne2();
    } 
}