# Lists are obsolete in Ruby, every array behaves like a list 

def CreateAndFillList
    myIntList = Array.new
    myStringList = Array.new

    myIntList.push(34) 
    myIntList << 34
    # .push and << do the same

    (5..7).each do |i|
        myIntList << i
    end
    
    myStringList << "34"
    myStringList << "34"

    (5..7).each do |i|
        myStringList << i.to_s
    end
end

def CreateAndFillListAndReturnIt
    myIntList = Array.new

    myIntList << 34
    myIntList << 34

    (5..7).each do |i|
        myIntList << i
    end

    return myIntList
end

def CheckIfItemExists
    myIntList = Array.new

    if !myIntList.include? 45
        myIntList << 45
    end
end

def LoopThroughAllElementsOfList(myIntList)
    myIntList.each do |item|
        puts item
    end

    (0..(myIntList.length - 1)).each do |i|
        puts myIntList[i]
    end
end

def CreateAndFillNestedList
    myIntList = Array.new

    testCounter = 0

    (5..7).each do |i|
    
        tempInt = Array.new(10)

        (0..9).each do |j|
            testCounter += 1
            tempInt[j] = testCounter
        end

        myIntList << tempInt
    end

    return myIntList
end

def LoopThroughAllElementsOfNestedList(myNestedIntList)

    myNestedIntList.each do |itemArray|
        itemArray.each do |item|
            puts item
        end
    end

    (0..(myNestedIntList.length - 1)).each do |j|
        (0..(myNestedIntList[j].length - 1)).each do |i|
            puts myNestedIntList[j][i]
        end
    end
end

def Exercise_EliminateDoubleAppearances
    inputNumbers = Array[3, 7, 5, 5, 4, 3, 2, 7]
    outputList = Array.new

    inputNumbers.each do |number|
        if !outputList.include? number
            outputList << number
        end
    end

    outputList.each do |number|
        puts number
    end
end

def Pitfall_1

    myList = Array.new

    myList << 100
    myList << 200

    #OK
    puts myList[0]
    puts myList[1]

    #This will cause NO error, BUT return an empty value
    puts myList[100]
    puts myList[200]
end

CreateAndFillList()

myIntList = CreateAndFillListAndReturnIt()

CheckIfItemExists()

LoopThroughAllElementsOfList(myIntList)

myNestedIntList = CreateAndFillNestedList()

LoopThroughAllElementsOfNestedList(myNestedIntList)

Exercise_EliminateDoubleAppearances()

Pitfall_1()

gets.chomp
