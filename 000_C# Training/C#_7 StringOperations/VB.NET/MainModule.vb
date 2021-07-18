Option Strict

Public Module MainModule
    Public Sub Main()

        CompareStrings_Convenient
        CompareStrings_Correct
        CompareString_CaseInsensitive
        ConcatenateStrings
        ConcatenateStringIteratively
        LengthOfString
        SplitStringBySingleChar
        SplitStringByString
        GetFirstFourSigns
        GetFirstFourSigns_Safe
        GetLastFourSigns
        GetLastFourSigns_Safe
        GetSignsBetween
        CheckIfStringContainsSubstring
        GetPositionWhereSubsubstringAppearsInString
        GetPositionWhereSubsubstringAppearsInString_FromRight
        RestOfStringAfterKeyWord
        ReplaceStringWithSubstring
        DateToStringWithFormat
        NumberToStringWithLeadingZeros
        CreateStringWithEnterAndCarriageReturn

        Console.ReadLine()
    End Sub

    Public Sub CompareStrings_Convenient()
        Dim myString As String = "abc"
        Dim myString2 As String = "aef"

        If myString = myString2 Then
            Console.WriteLine("Strings are equal")
        Else
            Console.WriteLine("Strings are not equal")
        End If
        
        'Attention, in Java and C++, this approach would not work
        'See CompareStrings_Correct()
    End Sub

    Public Sub CompareStrings_Correct()
        Dim myString As String = "abc"
        Dim myString2 As String = "aef"

        If StrComp(myString, myString2) = 0 Then
            Console.WriteLine("Strings are equal")
        Else
            Console.WriteLine("Strings are not equal")
        End If
    End Sub

    Public Sub CompareString_CaseInsensitive()
        Dim myString As String = "AbCDeF"
        Dim myString2 As String = "abcdef"

        If LCase(myString) = LCase(myString2) Then
            Console.WriteLine("Strings are equal")
        Else
            Console.WriteLine("Strings are not equal")
        End If

        If UCase(myString) = UCase(myString2) Then
            Console.WriteLine("Strings are equal")
        Else
            Console.WriteLine("Strings are not equal")
        End If
    End Sub

    Public Sub ConcatenateStrings()
        Dim myString As String = "Lgbs"
        Dim myString2 As String = "Mnl"
        Dim myString3 As String = "Krk"
        Dim myString4 As String = "We work at " + myString + " " + myString2 + " and " + myString3
        
        'You can use either "+" or "&" to concatenate strings
        Console.WriteLine(myString4)
    End Sub

    Public Sub ConcatenateStringIteratively()
        Dim myArray() As String = {"abc", "def", "ghi", "jkl"}
        Dim singleString As String
        Dim myFinalString As String = ""

        For Each singleString In myArray
            myFinalString &= singleString & "__"
        Next singleString

        Console.WriteLine(myFinalString)
    End Sub

    Public Sub LengthOfString()
        Dim myString As String = "LgbsMnlKrk"
        Dim length1 As Integer = Len(myString)
        
        Console.WriteLine(length1)
    End Sub

    Public Sub SplitStringBySingleChar()
        Dim myString As String = "abc;def;ghi;jkl"
        Dim mySplitString() As String = myString.Split(New Char() {";"c})
        'mySplitString = Split(myString, ";") 'also possible
        Dim singleString As String
        
        For Each singleString In mySplitString
            Console.WriteLine(singleString)
        Next singleString
    End Sub

    Public Sub SplitStringByString()
        Dim myString As String = "abc;_def;_ghi;_jkl"

        Dim mySplitString() As String = Split(myString, ";_")

        For Each singleString In mySplitString
            Console.WriteLine(singleString)
        Next singleString
    End Sub

    Public Sub GetFirstFourSigns()
        Dim myString As String = "LgbsKrkMnl"
        Dim leftFourSigns As String = Left(myString, 4)
        
        Console.WriteLine(leftFourSigns)
        
        'Attention, when myString has less than four signs, no error will be thrown.
    End Sub

    Public Sub GetFirstFourSigns_Safe()

        'not needed, code just for comparison reasons
        Dim myString As String
        Dim leftFourSigns As String
        
        myString = "LgbsKrkMnl"
        leftFourSigns = ""

        If Len(myString) >= 4 Then
            leftFourSigns = Left(myString, 4)
        Else
            'do something else

        Console.WriteLine(leftFourSigns

    End Sub

    Public Sub GetLastFourSigns()

        Dim myString As String
        Dim rightFourSigns As String
        
        myString = "LgbsKrkMnl"
        rightFourSigns = Right(myString, 4)
        Console.WriteLine(rightFourSigns

    End Sub

    Public Sub GetLastFourSigns_Safe()

        'not needed, code just for comparison reasons
        Dim myString As String
        Dim rightFourSigns As String
        
        myString = "LgbsKrkMnl"
        rightFourSigns = ""

        If Len(myString) >= 4 Then
            rightFourSigns = Right(myString, 4)
        Else
            'do something else
        End If

        Console.WriteLine(rightFourSigns

    End Sub

    Public Sub GetSignsBetween()

        Dim myString As String
        Dim thirdToFifthSign As String
        
        myString = "LgbsKrkMnl"
        thirdToFifthSign = Mid(myString, 3, 3)
        
        Console.WriteLine(thirdToFifthSign

    End Sub

    Public Sub CheckIfStringContainsSubstring()

        Dim myString As String
        Dim mySubstring As String
        
        myString = "LgbsKrkMnl"
        mySubstring = "Krk"

        If InStr(myString, mySubstring) Then
            Console.WriteLine("Contains"
        Else
            Console.WriteLine("Does not contain"
        End If

    End Sub

    Public Sub GetPositionWhereSubsubstringAppearsInString()

        Dim myString As String
        Dim mySubstring As String
        Dim pos As Integer
        
        myString = "LgbsKrkMnl"
        mySubstring = "Krk"
        
        pos = InStr(myString, mySubstring)
        
        Console.WriteLine(pos
    End Sub

    Public Sub GetPositionWhereSubsubstringAppearsInString_FromRight()

        Dim myString As String
        Dim mySubstring As String
        Dim pos As Integer
        
        myString = "LgbsKrkMnlKrk"
        mySubstring = "Krk"
        
        pos = InStrRev(myString, mySubstring)
        
        Console.WriteLine(pos
    End Sub


    Public Sub RestOfStringAfterKeyWord()

        Dim myString As String
        Dim mySubstring As String
        Dim restOfString As String
        Dim firstSign As Integer
        
        myString = "LgbsKrkMnl"
        mySubstring = "Krk"
        restOfString = ""

        firstSign = InStr(myString, mySubstring)

        If firstSign = 0 Then
            firstSign = 1
        Else
            firstSign = firstSign + 3
        End If

        restOfString = Mid(myString, firstSign)

        Console.WriteLine(restOfString

    End Sub

    Public Sub ReplaceStringWithSubstring()

        Dim myString As String
        Dim replaceWhat As String
        Dim tobeReplacedWith As String
        
        myString = "LgbsKrkMnl"
        replaceWhat = "Krk"
        tobeReplacedWith = "hoho"

        myString = Replace(myString, replaceWhat, tobeReplacedWith)

        Console.WriteLine(myString

    End Sub

    Public Sub DateToStringWithFormat()
        
        Dim myDate As Date
        Dim myString As String

        myDate = Now
        myString = Format(myDate, "dd.MM.yyyy HH:mm:ss")
        
        Console.WriteLine(myString

    End Sub

    Public Sub NumberToStringWithLeadingZeros()

        Dim myInt As Integer
        Dim myInt2 As Integer
        Dim myString As String
        
        myString = ""
        myInt = 33
        myInt2 = 3
        
        myString = "000" & CStr(myInt)
        myString = Right(myString, 3)
        
        Console.WriteLine(myString

        myString = "000" & CStr(myInt2)
        myString = Right(myString, 3)
        
        Console.WriteLine(myString

    End Sub

    Public Sub CreateStringWithEnterAndCarriageReturn()

        Dim myString As String
        
        myString = "abc" & vbNewLine & "def" & vbNewLine & "ghi"
        Console.WriteLine(myString

        myString = "abc" & Chr(13) & Chr(10) & "def" & Chr(13) & Chr(10) & "ghi"
        Console.WriteLine(myString

    End Sub
End Module
