import java.time.LocalDate;

data class EmpShort (val name : String, val birthdate : LocalDate, var gross : Double) {
    var net : Double = 0.00;
}