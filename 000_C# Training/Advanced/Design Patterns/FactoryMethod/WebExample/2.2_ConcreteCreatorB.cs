class ConcreteCreatorB : IFactory
{
    public IClass BuildClass()
    {
        return new ConcreteClass2();
    }
}