from datetime import datetime
from employee import Employee
from empshort import EmpShort
from taxcode import TaxCode

employee = Employee()

employee.personal.name  = "Paul"
employee.personal.age   = 25
employee.salary.raise1  = False
employee.salary.taxCode = TaxCode.MIDDLEINCOME

empShort = EmpShort("Mike", datetime(1989, 1, 30), 4000.00)
empShort.net    = 3000.00
empShort.gross  = 4050.00
