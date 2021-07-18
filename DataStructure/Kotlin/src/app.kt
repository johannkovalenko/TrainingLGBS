import java.time.LocalDate;

fun main() {
    val employee = Employee()
    
    employee.personal.name  = "Paul"
    employee.personal.age   = 25
    employee.salary.raise   = true
    employee.salary.taxCode = TaxCode.MIDDLEINCOME

    val empShort = EmpShort("Mike", LocalDate.of(1989, 1, 30), 4000.00);
    empShort.net    = 3000.00;
    empShort.gross  = 4050.00;
}