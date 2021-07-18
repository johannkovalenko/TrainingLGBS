class MyClass

    # getters and setters are obligatory in Ruby (in VBA too, in C# not)

    @@myStaticVariable = nil

    def self.myStaticVariable
        return @@myStaticVariable
    end

    def self.myStaticVariable=value
        @@myStaticVariable = value
    end

    def myNonStaticVariable
        @myNonStaticVariable
    end

    def myNonStaticVariable=value
        @myNonStaticVariable = value
    end

    def myNonStaticVariable2
        @myNonStaticVariable2
    end

    def myNonStaticVariable2=value
        @myNonStaticVariable2 = value
    end
end

class MyClass2
    def initialize(myInt, myString)
        @myInt = myInt
        @myString = myString
    end

    def myInt
        @myInt
    end

    def myInt=value
        @myInt = value
    end

    def myString
        @myString
    end

    def myString=value
        @myString = value
    end 
end

class MyClass3
    def myInt       
        @myInt + 5
    end
    
    def myInt=value
        @myInt = value + 5
    end
end

def DeclareWriteAndRead()

    MyClass.myStaticVariable = 66

    first = MyClass.new
    second = MyClass.new

    first.myNonStaticVariable = 99
    first.myNonStaticVariable2 = 77

    second.myNonStaticVariable = 88
    second.myNonStaticVariable2 = 55        

    puts MyClass.myStaticVariable
    puts first.myNonStaticVariable
    puts first.myNonStaticVariable2
    puts second.myNonStaticVariable
    puts second.myNonStaticVariable2
end

def SaveClassInstanceForFurtherUse_List()
    # not relevant, in Ruby arrays are lists and lists and arrays
    # consult SaveClassInstanceForFurtherUse_Array()
end

def SaveClassInstanceForFurtherUse_Array()
    myList = Array.new(2)

    first = MyClass.new
    second = MyClass.new

    first.myNonStaticVariable = 99
    first.myNonStaticVariable2 = 77

    second.myNonStaticVariable = 88
    second.myNonStaticVariable2 = 55

    myList.push(first)
    myList.push(second)

    # Further use:

    myList.each do |classInstance|
        puts classInstance.myNonStaticVariable
        puts classInstance.myNonStaticVariable2
    end
end

def Initializer
    myClass2 = MyClass2.new(32, "Johann")
    puts myClass2.myInt
    puts myClass2.myString
end

def GetterSetter
    # C# does not require Getters and Setters, Java does not have them, Ruby and VBA require them
    myClass3 = MyClass3.new
    myClass3.myInt = 1
    puts myClass3.myInt
end

DeclareWriteAndRead()
SaveClassInstanceForFurtherUse_List() #obsolete
SaveClassInstanceForFurtherUse_Array()
Initializer()
GetterSetter()
