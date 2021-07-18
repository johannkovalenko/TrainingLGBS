using System.Collections.Generic;

class facade
{
    private List<int> list = new List<int>();

    private Step1 step1 = new Step1();
    private Step2 step2 = new Step2();

    public void Step1()
    {
        step1.Run(list);
    }

    public void Step2()
    {
        step2.Run(list);
    }

}

class Step1
{
    public void Run(List<int> list)
    {
        list.Add(1);
    }
}

class Step2
{
    public void Run(List<int> list)
    {
        list.Add(2);
    }
}