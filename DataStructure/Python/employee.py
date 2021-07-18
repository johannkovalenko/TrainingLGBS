from taxcode import TaxCode

class Employee:
    def __init__(self):
        self.personal = self.Personal()
        self.salary = self.Salary()

    class Personal:
        def __init__(self):
            self.name = ""
            self.age = 0

    class Salary:
        def __init__(self):
            self.raise1 = False # raise is a reserved word
            self.taxCode = TaxCode.LOWINCOME