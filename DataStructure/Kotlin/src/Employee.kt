class Employee {
    public val personal    = Personal()
    public val salary      = Salary()

    class Personal {
        public var name : String = ""
        public var age : Int = 0
    }

    class Salary {
        public var raise : Boolean = false
        public var taxCode : TaxCode = TaxCode.LOWINCOME
    }
}