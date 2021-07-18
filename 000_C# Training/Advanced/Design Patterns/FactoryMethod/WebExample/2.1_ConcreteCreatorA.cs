class ConcreteCreatorA : IFactory
{
    public IClass BuildClass()
    {
        return new ConcreteClass1();
    }
}