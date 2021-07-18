// Modify the code so that that both main methods ("CaseA" and "CaseB") comply to the Open-Closed Principle, when we add a new car manufacturer


class SEN_1Y_B
{
    public void Run()
    {
        CaseA("Renault");
        CaseB();
    }

    private void CaseA(string choice)
    {
        switch (userInput)
        {
            case "Renault":
                new Renault().Build();
                return;
            case "Nissan":
                new Nissan().Build();
                return;
        }
    }

    private void CaseB()
    {
        var renault = new Renault();
        var Nissan = new Nissan();


        renault.Build();
        renault.Build();
        nissan.Build();
        renault.Build();
        nissan.Build();
        nissan.Build();
    }
}

class Renault
{
    public void Build()
    {}
}

class Nissan
{
    public void Build()
    {}
}