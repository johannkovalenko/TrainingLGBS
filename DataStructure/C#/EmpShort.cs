class EmpShort
{
    public readonly string  name; 
    public readonly DateTime birthdate;
    public double gross;
    public double net = 0.00;

    public EmpShort(string name, DateTime birthdate, double gross)
    {
        this.name = name;
        this.birthdate = birthdate;
        this.gross = gross;
    }
}