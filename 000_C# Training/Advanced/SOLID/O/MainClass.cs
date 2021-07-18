using System;

class MainClass
{
    static void Main()
    {
        AntiPattern("case1");
        
        OKPattern(new Case1());
        OKPatternOverride(new Case1_O());
    }

    static void AntiPattern(string mCase)
    {
        MyAntiClass myAntiClass = new MyAntiClass();

        if (mCase == "case1")
            myAntiClass.Case1();
        else if (mCase == "case2")
            myAntiClass.Case2();
        else if (mCase == "case3")
            myAntiClass.Case3();
    }

    static void OKPattern(ICase mCase)
    {
        mCase.Run();
    }

    static void OKPatternOverride(BaseClass mCase)
    {
        mCase.Run();
    }
}