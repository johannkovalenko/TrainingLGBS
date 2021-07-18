import java.time.LocalDate;

class EmpShort {
    public final String  name; 
    public final LocalDate birthdate;
    public double gross;
    public double net = 0.00;

    public EmpShort(String name, LocalDate birthdate, double gross) {
        this.name = name;
        this.birthdate = birthdate;
        this.gross = gross;
    }
}