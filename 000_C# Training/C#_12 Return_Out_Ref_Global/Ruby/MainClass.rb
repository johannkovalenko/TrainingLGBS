$globalString = ""

class MyClass
    def myString
        @myString
    end

    def myString=value
        @myString = value
    end

    def myInt
        @myInt
    end

    def myInt=value
        @myInt = value
    end
end

def PassAndReturnTypeByValue
    myString = PassAndReturnTypeByValue_Helper("ABC")
    puts myString
end

def PassAndReturnTypeByValue_Helper(myString)
    myString = "DEF"
end

def PassAndReturnSeveralSameTypesByValue
    myStrings = PassAndReturnSeveralSameTypesByValue_Helper("ABC", "DEF")
    puts "#{myStrings[0]} #{myStrings[1]}"
end

def PassAndReturnSeveralSameTypesByValue_Helper(myString, myString2)
    myString = "GHI"
    myString2 = "JKL"

    myStrings = Array[myString, myString2]
end

def PassAndReturnDifferentTypesByValue
    myClass = PassAndReturnDifferentTypesByValue_Helper("ABC", 1)
    puts "#{myClass.myString} #{myClass.myInt}"

    # Ruby is a weakly typed language, hence it is possible to put two different types into one array
    myTypes = PassAndReturnDifferentTypesByValue_HelperRuby("ABC", 1)
    puts "#{myTypes[0]} #{myTypes[1]}"
end

def PassAndReturnDifferentTypesByValue_Helper(myString, myInt)
    myClass = MyClass.new

    myClass.myString = myString + "DEF"
    myClass.myInt = myInt + 2

    return myClass
end

def PassAndReturnDifferentTypesByValue_HelperRuby(myString, myInt)
    myString += "DEF"
    myInt += 2

    myTypes = Array[myString, myInt]
end

def ReturnTypesByOut
    # not possible and obsolete
end

def PassAndReturnTypesByRef_DeFactoGlobal
    # in ruby parameters can't be passed by reference
end

def GlobalString
    GlobalString_Helper()
    puts $globalString
end

def GlobalString_Helper
    $globalString = "DEF"
end

def Pitfall_PassComplexTypeByValue

    myDict = Hash.new
    myDict[1] = 10

    myInts = Array[5]

    Pitfall_PassComplexTypeByValue_Helper(myDict, myInts)

    puts "#{myDict[1]} #{myInts[0]}"

    #Expected Value:   10 5
    #Real Value:       50 20

    #Explanation: Complex Data Types cannot be passed by value. (ByValue = making a copy)
    #When passing an complex type, we pass in fact its start address.
    #So any change done in the called function is a change on the original element 

end

def Pitfall_PassComplexTypeByValue_Helper(myDict, myInts)
    myDict[1] = 50
    myInts[0] = 20
end

def Solution_Pitfall_PassComplexTypeByValue

    myDict = Hash.new
    myDict[1] = 10

    myInts = Array[5]

    Solution_Pitfall_PassComplexTypeByValue_Helper(myDict, myInts)

    puts "#{myDict[1]} #{myInts[0]}"

    #Expected Value:   10 5
    #Real Value:       10 5

    #Explanation: a deep copy (dictionary) or clone (array) creates a copy of the complex type
    #and puts it to a new address. now every change under the new address has no effect to the object under the old address

    #Attention: although this solution solves the problem, it is not recommended to pass complex types
    # by clone/deep copy, because it is very uneconomical.
end

def Solution_Pitfall_PassComplexTypeByValue_Helper(myDict, myInts)

    myCopiedDict = myDict.clone
    myClonedInts = myInts.clone

    myCopiedDict[1] = 50
    myClonedInts[0] = 20
end

def Obsolete_PassComplexTypeByRef
    #not possible in ruby
end

PassAndReturnTypeByValue()
PassAndReturnSeveralSameTypesByValue()
PassAndReturnDifferentTypesByValue()

ReturnTypesByOut() #not possible
PassAndReturnTypesByRef_DeFactoGlobal() #not possible

GlobalString() 

Pitfall_PassComplexTypeByValue()
Solution_Pitfall_PassComplexTypeByValue()

Obsolete_PassComplexTypeByRef() #not possible

gets.chomp

