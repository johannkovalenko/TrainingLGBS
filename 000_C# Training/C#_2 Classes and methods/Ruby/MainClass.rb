def MethodInTheSameClass
    puts "Hello, i am the method in the same class"
end

def MethodReturningValue
    puts "Hello, I return a string. I automatically return the value from the last line, or everything after the keyword 'return'"
    returnValue = "ABC"
    # or return "ABC"
end

def MethodReceivingValue(receivedString)
    puts "Hello, I received the string " + receivedString + "."
end

class OtherClass
    def self.MethodInAnotherClass()
        puts "Hello, I am the static method in another class"
    end
end
    
MethodInTheSameClass()
OtherClass.MethodInAnotherClass()
returnValue = MethodReturningValue()
puts returnValue

MethodReceivingValue("XYZ")

gets.chomp