// What is the bad practice here?
// Think about the motto "the lowest possible scope of our state"
// Introduce a design pattern to get rid of the bad practice

using System.Collections.Generic;

class REG_1Y_A
{
    private List<string> children = new List<string>();
    private List<string> adults = new List<string>();

    public void Run()
    {
        Kindergarten();
        Playground();
        Theatre();
        Stadium();
    }

    private void Kindergarten()
    {
        children.Add("Mike");
        //plus 30 lines of code
    }

    private void Playground()
    {
        children.Add("Joe");
        //plus 30 lines of code
    }

    private void Theatre()
    {
        adults.Add("Sue");
        //plus 30 lines of code
    }

    private void Stadium()
    {
        adults.Add("Pam");
        //plus 30 lines of code
    }
}