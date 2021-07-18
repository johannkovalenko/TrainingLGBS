def ForLoop_ZeroToNine
    for i in 0..9    
        puts i
    end

    (0..9).each do |i|
        puts i
    end
end

def ForLoop_OneToTen
    (1..10).each do |i| 
        puts i
    end
end

def ForLoop_NineToZero
    (9..0).each do |i|
        puts i
    end
end

def ForLoop_JumpTwo
    (0..9).step(2) do |i|
        puts i
    end
end

def LoopWhile
    i = 0

    while i < 10 do
        puts i
        i += 1  
    end
end

def LoopWhile_AtLeastOneIteration
    i = 10

    begin
        puts i
        i += 1  
    end while i < 10
end

def EndlessLoopWithEmergencyExit
    i = 0

    while true do
        i += 1
        puts i
        
        if i > 100
            break
        end
    end
end

def ForEach
    myArray = Array["abc", "def", "ghi", "jkl"]

    myArray.each do |mySingleString|
        puts mySingleString
    end    
end

def DeFactoForEach
    myArray = Array["abc", "def", "ghi", "jkl"]

    for i in 0..(myArray.length - 1) 
        puts myArray[i]
    end
end

def ForEachCharInString
    myString = "LGBSMNLKRK"

    myString.each_char do |singleChar|
        puts singleChar
    end
end

def DefactoForEachCharInString
    myString = "LGBSMNLKRK"

    for i in 0..(myString.length - 1)
        puts myString[i].chr
    end
end

# ForLoop_ZeroToNine()
# ForLoop_OneToTen()
# ForLoop_NineToZero()
# ForLoop_JumpTwo()
# LoopWhile()
# LoopWhile_AtLeastOneIteration()
# EndlessLoopWithEmergencyExit()
# ForEach()
# DeFactoForEach()
ForEachCharInString()
# DefactoForEachCharInString()

gets.chomp