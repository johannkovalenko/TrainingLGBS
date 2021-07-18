def PowerOfNumber
    myInt = 5
    myPowerOfTwo = myInt ** 2
    puts myPowerOfTwo

    myPowerOfThree = myInt ** 3
    puts myPowerOfThree
end

def RootOfNumber
    myInt = 81

    mySquareRoot = Math.sqrt(myInt)
    puts mySquareRoot

    myInt = 125

    myCubicRoot = myInt ** (1/3)
    puts myCubicRoot
end 

def ModuloOfDivision
    modulo = 83 % 9
    puts modulo
end

def ModuloPerformJumpsOfSeven
    modulo = 0

    (0..49).each do |i|
        modulo = i % 7

        if modulo == 0
            puts i
        else
            puts "x"
        end
    end
end

def GetDecimalPartOfNumber
    myDouble = 7.39596
    integerOfDouble = myDouble.to_i

    myDecimalPart = myDouble - integerOfDouble

    puts integerOfDouble
    puts myDecimalPart
end

def RoundingNumbers

    myDouble = 7.49

    roundedDouble = (myDouble + 0.5).to_i

    puts roundedDouble

    myDouble = 7.50

    roundedDouble = (myDouble + 0.5).to_i

    puts roundedDouble
end

def AlwaysRoundDown

    myDouble = 7.49

    roundedDouble = myDouble.to_i

    puts roundedDouble

    myDouble = 7.50

    roundedDouble = myDouble.to_i

    puts roundedDouble
end

def AlwaysRoundUp

    myDouble = 7.49

    roundedDouble = (myDouble + 1).to_i

    puts roundedDouble

    myDouble = 7.50

    roundedDouble = (myDouble + 1).to_i

    puts roundedDouble
end

def RoundToFirstDecimalPart

    myDouble = 7.349

    roundedDouble = ((myDouble * 10 + 0.5).to_i).to_f / 10
    puts roundedDouble

    myDouble = 7.350

    roundedDouble = ((myDouble * 10 + 0.5).to_i).to_f / 10
    puts roundedDouble
end

def UsingSinusAndCosinus

    # When walking 1 unit from the center with a 45 degree angle, 
    # your karthesian coordinates will be 0.71/0.71 and not 1/1!!

    xCoor = Math.sin(Math::PI * 45 / 180.0)
    yCoor = Math.cos(Math::PI * 45 / 180.0)

    puts "#{xCoor}\t#{yCoor}"

    xCoor = Math.sin(Math::PI * 90 / 180.0)
    yCoor = Math.cos(Math::PI * 90 / 180.0)

    puts "#{xCoor}\t#{yCoor}"
end

def Pythagoras
    # The distance from the point 0/0 to the point 2/2 is not 2, it is 2.83
    
    xCoor = 2
    yCoor = 2

    distance = Math.sqrt(xCoor ** 2 + yCoor ** 2)
    puts distance
end

def AbsoluteValue
    myDouble = -45.45
    myAbsoluteDouble = myDouble.abs

    puts myAbsoluteDouble
end

PowerOfNumber()
RootOfNumber()
ModuloOfDivision()
ModuloPerformJumpsOfSeven()
GetDecimalPartOfNumber()
RoundingNumbers()
AlwaysRoundDown()
AlwaysRoundUp()
RoundToFirstDecimalPart()
UsingSinusAndCosinus()
Pythagoras()
AbsoluteValue()

gets.chomp
