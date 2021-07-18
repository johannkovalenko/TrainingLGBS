require 'date'

def IntDouble
    myInt = 32
    myDouble = myInt.to_f

    puts myDouble

    myInt = myDouble.to_i

    puts myInt
end

def ByteToChar
    myDecimal = 65
    myChar = myDecimal.chr
    puts myChar
end

def IntByte
    # not relevant in ruby
end

def IntToString
    myInt = 257
    myString = myInt.to_s
    puts myString
end

def StringToInt
    myString = "2i57"
    
    if myString.is_a?(Numeric)
        myInt = myString.to_i
        puts myInt  
    else
        puts "NOT A NUMBER"
    end
end

def StringToByteArray
    myString = "2i57"
    myByteArray = myString.bytes

    myByteArray.each do |myByte|
        puts "#{myByte}   #{myByte.chr}"
    end
end

def ByteArrayToString
    myByteArray = Array[222, 0, 22, 0, 167, 0, 34, 0]
    myString = myByteArray.pack("C*")
    puts myString
end

def StringToDate

    myDateString = "22.03.1986 10:32"

    myDate = DateTime.strptime(myDateString, "%d.%m.%Y %H:%M")

    puts myDate
end

def DateToString
    myDate = Time.now
    myString = myDate.strftime("%d.%m.%Y %H:%M:%S")
    puts myString
end

IntDouble()
ByteToChar()
IntByte() # not relevant in Ruby
IntToString()
StringToInt()
StringToByteArray()
ByteArrayToString()
StringToDate()
DateToString()

gets.chomp