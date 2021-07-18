$globalVariableInHomeClass = "DEF"

def MyStrings()
    myString1 = "ABC"
    myString2 = "DEF"
    myString3 = myString1 + myString2
    puts myString3
end 

def MyInts()
    myInt1 = 7
    myInt2 = 5
    myInt3 = myInt1 * myInt2
    puts myInt3
end

def MyArray()
    myStringArray = Array["abc", "def", "ghi"]
    myString = myStringArray[2]
    puts myString

    myStringArray2 = Array.new(3)
    myStringArray2[0] = "abc"
    myStringArray2[1] = "def"
    myStringArray2[2] = "ghi"
    puts myStringArray2[2]
end

def AccessGlobalVariables()
    myConcatString = $globalVariableInHomeClass + OtherClass.globalVariableInOtherClass
    puts myConcatString
end

class OtherClass
    @@globalVariableInOtherClass = "ABC"

    def self.globalVariableInOtherClass=value
        @@globalVariableInOtherClass = value
    end
    
    def self.globalVariableInOtherClass
        @@globalVariableInOtherClass
    end
end

MyStrings()
MyInts()
MyArray()
AccessGlobalVariables()

gets.chomp
