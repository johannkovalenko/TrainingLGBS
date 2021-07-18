def CompareStrings_Convenient
    myString = "abc"
    myString2 = "aef"

    if myString == myString2
        puts "Strings are equal"
    else
        puts "Strings are not equal"
    end
    #Attention, in Java and C++, this approach would not work
    #See CompareStrings_Correct
end

def CompareStrings_Correct
    myString = "abc"
    myString2 = "aef"

    if myString.eql? myString2
        puts "Strings are equal"
    else
        puts "Strings are not equal"
    end
end        

def CompareString_CaseInsensitive
    myString = "AbCDeF"
    myString2 = "abcdef"

    if myString.downcase == myString2.downcase
        puts "Strings are equal"
    else
        puts "Strings are not equal"
    end

    if myString.upcase == myString2.upcase
        puts "Strings are equal"
    else
        puts "Strings are not equal"        
    end
end

def ConcatenateStrings
    myString = "Lgbs"
    myString2 = "Mnl"
    myString3 = "Krk"

    myString4 = "We work at " + myString + " " + myString2 + " and " + myString3
    
    puts myString4
end

def ConcatenateStringIteratively
    myArray = Array["abc", "def", "ghi", "jkl"]
    myFinalString = ""

    myArray.each do |singleString|
        myFinalString += singleString + "__"
    end

    puts myFinalString
end

def LengthOfString
    myString = "LgbsMnlKrk"
    length = myString.length
    puts length
end

def SplitStringBySingleChar
    myString = "abc;def;ghi;jkl"

    mySplitString = myString.split(";")

    mySplitString.each do |singleString|
        puts singleString
    end
end

def SplitStringByString
    myString = "abc;_def;_ghi;_jkl"

    mySplitString = myString.split(";_")

    mySplitString.each do |singleString|
        puts singleString
    end       
end

def GetFirstFourSigns
    myString = "LgbsKrkMnl"
    leftFourSigns = myString[0..3]
    puts leftFourSigns

    leftFourSigns = myString[0, 4]
    puts leftFourSigns

    # when myString has less than four signs, NO error will be thrown. 
    # GetFirstFourSigns_Safe is obsolete
end

def GetFirstFourSigns_Safe
    # obsolete
end

def GetLastFourSigns
    myString = "LgbsKrkMnl"
    rightFourSigns = myString[myString.length - 4, 4]
    puts rightFourSigns

    rightFourSigns = myString[(myString.length - 4)..-1]
    puts rightFourSigns
end

def GetLastFourSigns_Safe
    # obsolete
end

def GetSignsBetween
    myString = "LgbsKrkMnl"
    thirdToFifthSign = myString[2, 3]
    puts thirdToFifthSign
end

def CheckIfStringContainsSubstring
    myString = "LgbsKrkMnl"
    mySubstring = "Krk"

    if myString[mySubstring]
        puts "Contains"
    else
        puts "Does not contain"
    end
end

def GetPositionWhereSubsubstringAppearsInString
    myString = "LgbsKrkMnl"
    mySubstring = "Krk"

    pos = myString.index(mySubstring)

    puts pos
end

def GetPositionWhereSubsubstringAppearsInString_FromRight
    myString = "LgbsKrkMnlKrk"
    mySubstring = "Krk"

    pos = myString.rindex(mySubstring)

    puts pos
end

def RestOfStringAfterKeyWord

    myString = "LgbsKrkMnl"
    mySubstring = "jKrk"
    restOfString = ""

    firstSign = myString.index(mySubstring)

    if firstSign == nil
        firstSign = 0
    else
        firstSign = firstSign + 3
    end

    restOfString = myString[firstSign..-1]

    puts restOfString
end

def ReplaceStringWithSubstring

    myString = "LgbsKrkMnl"
    replaceWhat = "Krk"
    tobeReplacedWith = "hoho"

    myString = myString.gsub(replaceWhat, tobeReplacedWith)

    puts myString
end

def DateToStringWithFormat

    myDate = Time.now
    myString = myDate.strftime("%d.%m.%Y %H:%M:%S")
    puts myString
end

def NumberToStringWithLeadingZeros

    myInt = 33
    myInt2 = 3
    myString = ""
    
    myString = "000" + myInt.to_s
    myString = myString[(myString.length - 3)..-1]
    puts myString

    myString = "000" + myInt2.to_s
    myString = myString[(myString.length - 3)..-1]
    puts myString        
end

def CreateStringWithEnterAndCarriageReturn

    myString = "abc\r\ndef\r\nghi"
    puts myString

    myString = "abc" + 13.chr + 10.chr + "def" + 13.chr + 10.chr + "ghi"
    puts myString
end

CompareStrings_Convenient()
CompareStrings_Correct()
CompareString_CaseInsensitive()
ConcatenateStrings()
ConcatenateStringIteratively()
LengthOfString()
SplitStringBySingleChar()
SplitStringByString()
GetFirstFourSigns()
GetFirstFourSigns_Safe() # obsolete
GetLastFourSigns()
GetLastFourSigns_Safe() # obsolete
GetSignsBetween()
CheckIfStringContainsSubstring()
GetPositionWhereSubsubstringAppearsInString()
GetPositionWhereSubsubstringAppearsInString_FromRight()
RestOfStringAfterKeyWord()
ReplaceStringWithSubstring()
DateToStringWithFormat()
NumberToStringWithLeadingZeros()
CreateStringWithEnterAndCarriageReturn()

gets.chomp

