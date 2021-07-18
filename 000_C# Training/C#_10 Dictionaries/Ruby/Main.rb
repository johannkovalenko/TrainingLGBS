# Ruby (as Java) uses Hashes instead of Dictionary
# The main difference is that Hashes overwrite automatically existing values

def CreateAndFillDictionary
    myIntStringDict = Hash.new
    myStringIntDict = Hash.new

    myIntStringDict[34] = "abc"   
    myIntStringDict[34] = "abc" 

    (5..7).each do |i|
        myIntStringDict[i] = "abc"
    end
    
    myStringIntDict["34"] = 111
    myStringIntDict["34"] = 111     

    (5..7).each do |i|
        myStringIntDict[i.to_s] = 111
    end
end

def CreateAndFillDictionaryAndReturnIt
    myIntStringDict = Hash.new

    myIntStringDict[34] = "abc"
    myIntStringDict[34] = "abc"

    (5..7).each do |i|
        myIntStringDict[i] = "abc"
    end

    return myIntStringDict
end

def GetValueOfKey
    myIntStringDict = Hash.new

    myIntStringDict[34] = "abc"

    if myIntStringDict.include? 34
        myString = myIntStringDict[34]
        puts myString
    end

    return myIntStringDict
end

def OverwriteWhenItemExists
    # obsolete, because Hash automatically overwrites
    # below example just shows how to check if key exists

    myIntIntDict = Hash.new

    myIntIntDict[45] = 1

    if myIntIntDict.include? 45
        myIntIntDict[45] = 2
    else
        myIntIntDict[45] = 2
    end

    puts myIntIntDict[45]
end

def LoopThroughAllElementsOfList(myIntStringDict)
    puts "Approach 1:"

    myIntStringDict.each_key do |key|
        puts "Key: #{key}\tValue: #{myIntStringDict[key]}"
    end

    puts "\r\nApproach 2:"

    myIntStringDict.each do |key, value|
        puts "Key: #{key}\tValue: #{value}"
    end

    puts "\r\nApproach 3:"

    keyArray = myIntStringDict.keys

    keyArray.each do |key|
        puts "Key: #{key}\tValue: #{myIntStringDict[key]}"
    end

end

def CreateAndFillNestedDictionary

    myNestedDictionary = Hash.new

    testCounter = 0

    (5..7).each do |i|
        tempInt = Array.new(10)

        (0..9).each do |j|
            testCounter += 1
            tempInt[j] = testCounter
        end

        myNestedDictionary[i] = tempInt
    end

    return myNestedDictionary
end

def LoopThroughAllElementsOfNestedDictionary(myNestedDictionary)
    myNestedDictionary.each do |key, value|
        value.each do |item|
            puts item
        end
    end
end

def OverwriteWhenItemExistsNested(myNestedDictionary)
    if myNestedDictionary.include? 5
        tempInt = Array[3, 5, 6, 3, 2]
        myNestedDictionary[5] = tempInt

        myNestedDictionary[5].each do |testInt|
            puts testInt
        end
    end
end

def ManipulateValueWhenItemExistsNested(myNestedDictionary)

    if myNestedDictionary.include? 5
        tempInt = myNestedDictionary[5]
        tempInt[4] = 555
        myNestedDictionary[5] = tempInt

        myNestedDictionary[5].each do |testInt|
            puts testInt
        end
    end
end

def Exercise_CountAppearances

    inputNames = Array["Pat", "Ann", "Paul", "Paul", "Joe", "Mike", "Pat", "Paul"]
    outputDict = Hash.new

    inputNames.each do |name|
        if !outputDict.include? name
            outputDict[name] = 1
        else
            outputDict[name] += 1
        end
    end

    outputDict.each do |key, value|
        puts "#{key}\t#{value}"
    end
end

def Pitfall_1

    #Most problems connected to Dictionaries are due to the fact that dictionaries link by reference 

    myDict = Hash.new
    tempInt = Array.new(1)

    (0..2).each do |i|
        tempInt[0] = i
        myDict[i] = tempInt

        puts ""

        myDict.each_value do |value|
            puts value[0]
        end

        #Expected output:  0, 0 1, 0 1 2
        #Real output:      0, 1 1, 2 2 2

        #Explanation: the dictionary links to the address of "tempInt"
        #the adddress of "tempInt" never changes though (= there is only one instance of "tempInt"
        #every item of myDict points to the same address of "tempInt"
        #hence every change of "tempInt" results in the change of every value of "myDict"
    end
end

def Solution_Pitfall_1

    myDict = Hash.new

    (0..2).each do |i|
        tempInt = Array.new(1)

        tempInt[0] = i
        myDict[i] = tempInt

        puts ""

        myDict.each_value do |value|
            puts value[0]
        end

        #Expected output:  0, 0 1, 0 1 2
        #Real output:      0, 0 1, 0 1 2

        #Explanation: now there are three addresses (three instances) of "tempInt"
        #so any change in one instance of "tempInt" does not affect the rest of instances
    end
end

def Pitfall_2

    myDict = Hash.new

    myDict[0] = Array[0]
    myDict[1] = Array[1]

    puts myDict[0][0]
    puts myDict[1][0]

    myDict[1] = myDict[0]

    puts myDict[0][0]
    puts myDict[1][0]

    myDict[0][0] = 9       

    puts myDict[0][0]
    puts myDict[1][0]

    myDict[1][0] = 8

    puts myDict[0][0]
    puts myDict[1][0]

    #Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
    #Real outputs:         0   1   |   0   0   |   9   9   |   8   8

    #When copying one entry to another, suddenly every further change in ANY value affects both entries.
    #Explanation: when copying one entry to another, we ONLY copy the address
    # -> both entries now point to the same address in memory
    # -> any change in the address pointed to affects both entries. 

end

def Solution_Pitfall_2

    myDict = Hash.new

    myDict[0] = Array[0]
    myDict[1] = Array[1]

    puts myDict[0][0]
    puts myDict[1][0]

    myDict[1] = myDict[0].clone

    puts myDict[0][0]
    puts myDict[1][0]

    myDict[0][0] = 9       

    puts myDict[0][0]
    puts myDict[1][0]

    myDict[1][0] = 8

    puts myDict[0][0]
    puts myDict[1][0]

    #Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
    #Real outputs:         0   1   |   0   0   |   9   0   |   9   8

    #Explanation: when cloning an array, a copy of the array under a NEW ADDRESS is created
    # -> every entries now points to a different address in memory
    # -> any change in one address does not affect the other address. 

end

def Pitfall_3

    myDict = Hash.new

    myDict[0] = Array[0]

    puts myDict[0][0]
    
    Pitfall_3_Helper(myDict)

    puts myDict[0][0]

    #Expected outputs:     0   0
    #Real output:          0   9

    #When calling a function with parameter (which is NOT by reference), we expect no change in the original dictionary
    #But the dictionary calls to the address of the int[]
    #so no matter where we change the int[], it will always affect the whole dictionary
    #(which is actually a very good behavior, nobodys wants to copy dictionaries)

end

def Solution_Pitfall_3
    myDict       = Hash.new
    myDictCopy   = myDict.clone

    myDict[0] = Array[0]

    puts myDict[0][0]
    
    Pitfall_3_Helper(myDictCopy)

    puts myDict[0][0]

    #Expected outputs:     0   0
    #Real output:          0   0

    #By copying the whole dictionary, a second address is created
    #a change in one address does not affect the second address
end

def Pitfall_3_Helper(myDict)
    myDict[0] = Array[9]
end

CreateAndFillDictionary()
myIntStringDict = CreateAndFillDictionaryAndReturnIt()
GetValueOfKey()
OverwriteWhenItemExists()
LoopThroughAllElementsOfList(myIntStringDict)
myNestedDictionary = CreateAndFillNestedDictionary()
LoopThroughAllElementsOfNestedDictionary(myNestedDictionary)
OverwriteWhenItemExistsNested(myNestedDictionary)
ManipulateValueWhenItemExistsNested(myNestedDictionary)
Exercise_CountAppearances()
Pitfall_1()
Solution_Pitfall_1()
Pitfall_2()
Solution_Pitfall_2()
Pitfall_3()
Solution_Pitfall_3()

gets.chomp