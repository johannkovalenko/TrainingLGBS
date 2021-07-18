def IfInstruction
    x = "abc"
    y = ""

    if x == "abc"
        y = "Good"
    elsif x == "def"
        y = "Not Good"
    else
        y = "Indifferent"
    end

    puts y
end

def IfInstruction2
    x = 23
    y = 0

    if x <= 30
        y = x * 2
    elsif x <= 50
        y = x * 3
    else
        y = x * 4
    end

    puts y
end

def IfShort_OnlyWhenOneLiners
    # not relevant in Ruby
end

def IfAndOr
    x = 20
    y = 30

    if x == 20 && y == 40
        puts "TRUE"
    else
        puts "FALSE"
    end

    if x == 20 || y == 40
        puts "TRUE"
    else
        puts "FALSE"
    end
end

def NotEqual
    x = 20

    if x != 20
        puts "TRUE"
    else
        puts "FALSE"
    end
end

def Not_Instruction
    x = true

    if x == true
        puts "a"
    end

    if x
        puts "a"
    end

    if x == false
        puts "b"
    end
    
    if !x
        puts "b"
    end
end

def Not_Instruction2
    x = "abc"

    if x.include? "b"
        puts "a"
    end

    if !x.include? "f"
        puts "b"
    end
end

def Not_Instruction3

    x = "abc"

    trueFalse = x == "abc"

    if trueFalse
        puts "a"
    end

    if !trueFalse
        puts "b"
    end
end

def Switch_Instruction

    y = 30

    case y
    when 24
        puts "Is 24"
    when 30
        puts "Is 30"
    when 35, 36
        puts "Is 35 or 36"
    when 37..40
        puts "Is between 37 and 40"
    else
        puts "Is something else"
    end
end

IfInstruction()
IfInstruction2()
IfShort_OnlyWhenOneLiners() # not relevant in ruby
IfAndOr()
NotEqual()
Not_Instruction()
Not_Instruction2()
Not_Instruction3()
Switch_Instruction()

gets.chomp