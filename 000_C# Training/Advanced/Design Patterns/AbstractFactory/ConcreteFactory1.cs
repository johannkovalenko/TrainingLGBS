public class ConcreteFactory1 : IFactory
{
    public IClassOne BuildClassOne()
    {
        return new ConcreteClassOne1();
    } 
}