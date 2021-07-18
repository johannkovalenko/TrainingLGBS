Attribute VB_Name = "Module1"
Option Explicit

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

End Sub


Public Sub CompareStrings_Convenient()

    Dim myString As String
    Dim myString2 As String
    
    myString = "abc"
    myString2 = "aef"

    If myString = myString2 Then
        Debug.Print "Strings are equal"
    Else
        Debug.Print "Strings are not equal"
    End If
    
    'Attention, in Java and C++, this approach would not work
    'See CompareStrings_Correct()

End Sub

Public Sub CompareStrings_Correct()

    Dim myString As String
    Dim myString2 As String
    
    myString = "abc"
    myString2 = "aef"

    If StrComp(myString, myString2) = 0 Then
        Debug.Print "Strings are equal"
    Else
        Debug.Print "Strings are not equal"
    End If
End Sub

Public Sub CompareString_CaseInsensitive()

    Dim myString As String
    Dim myString2 As String
    
    myString = "AbCDeF"
    myString2 = "abcdef"

    If LCase(myString) = LCase(myString2) Then
        Debug.Print "Strings are equal"
    Else
        Debug.Print "Strings are not equal"
    End If

    If UCase(myString) = UCase(myString2) Then
        Debug.Print "Strings are equal"
    Else
        Debug.Print "Strings are not equal"
    End If
End Sub


Public Sub ConcatenateStrings()

    Dim myString As String
    Dim myString2 As String
    Dim myString3 As String
    Dim myString4 As String
    
    myString = "Lgbs"
    myString2 = "Mnl"
    myString3 = "Krk"

    myString4 = "We work at " & myString & " " & myString2 & " and " & myString3
    
    Debug.Print myString4

End Sub

Public Sub ConcatenateStringIteratively()

    Dim myArray()
    Dim singleString
    Dim myFinalString As String
    
    myFinalString = ""

    myArray = Array("abc", "def", "ghi", "jkl")
    
    For Each singleString In myArray
        myFinalString = myFinalString & singleString & "__"
    Next singleString

    Debug.Print myFinalString

End Sub

Public Sub LengthOfString()

    Dim myString As String
    Dim length1 As Integer
    
    myString = "LgbsMnlKrk"
    length1 = Len(myString)
    
    Debug.Print length1

End Sub

Public Sub SplitStringBySingleChar()

    Dim myString As String
    Dim mySplitString()
    Dim singleString
    
    myString = "abc;def;ghi;jkl"

    mySplitString = Split(myString, ";")

    For Each singleString In mySplitString
        Debug.Print singleString
    Next singleString

End Sub

Public Sub SplitStringByString()

    Dim myString As String
    
    myString = "abc;_def;_ghi;_jkl"

    mySplitString = Split(myString, ";_")

    For Each singleString In mySplitString
        Debug.Print singleString
    Next singleString

End Sub

Public Sub GetFirstFourSigns()

    Dim myString As String
    Dim leftFourSigns As String
    
    myString = "LgbsKrkMnl"
    leftFourSigns = Left(myString, 4)
    
    Debug.Print leftFourSigns
    
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

    Debug.Print leftFourSigns

End Sub

Public Sub GetLastFourSigns()

    Dim myString As String
    Dim rightFourSigns As String
    
    myString = "LgbsKrkMnl"
    rightFourSigns = Right(myString, 4)
    Debug.Print rightFourSigns

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

    Debug.Print rightFourSigns

End Sub

Public Sub GetSignsBetween()

    Dim myString As String
    Dim thirdToFifthSign As String
    
    myString = "LgbsKrkMnl"
    thirdToFifthSign = Mid(myString, 3, 3)
    
    Debug.Print thirdToFifthSign

End Sub

Public Sub CheckIfStringContainsSubstring()

    Dim myString As String
    Dim mySubstring As String
    
    myString = "LgbsKrkMnl"
    mySubstring = "Krk"

    If InStr(myString, mySubstring) Then
        Debug.Print "Contains"
    Else
        Debug.Print "Does not contain"
    End If

End Sub

Public Sub GetPositionWhereSubsubstringAppearsInString()

    Dim myString As String
    Dim mySubstring As String
    Dim pos As Integer
    
    myString = "LgbsKrkMnl"
    mySubstring = "Krk"
    
    pos = InStr(myString, mySubstring)
    
    Debug.Print pos
End Sub

Public Sub GetPositionWhereSubsubstringAppearsInString_FromRight()

    Dim myString As String
    Dim mySubstring As String
    Dim pos As Integer
    
    myString = "LgbsKrkMnlKrk"
    mySubstring = "Krk"
    
    pos = InStrRev(myString, mySubstring)
    
    Debug.Print pos
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

    Debug.Print restOfString

End Sub

Public Sub ReplaceStringWithSubstring()

    Dim myString As String
    Dim replaceWhat As String
    Dim tobeReplacedWith As String
    
    myString = "LgbsKrkMnl"
    replaceWhat = "Krk"
    tobeReplacedWith = "hoho"

    myString = Replace(myString, replaceWhat, tobeReplacedWith)

    Debug.Print myString

End Sub

Public Sub DateToStringWithFormat()
    
    Dim myDate As Date
    Dim myString As String

    myDate = Now
    myString = Format(myDate, "dd.MM.yyyy HH:mm:ss")
    
    Debug.Print myString

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
    
    Debug.Print myString

    myString = "000" & CStr(myInt2)
    myString = Right(myString, 3)
    
    Debug.Print myString

End Sub

Public Sub CreateStringWithEnterAndCarriageReturn()

    Dim myString As String
    
    myString = "abc" & vbNewLine & "def" & vbNewLine & "ghi"
    Debug.Print myString

    myString = "abc" & Chr(13) & Chr(10) & "def" & Chr(13) & Chr(10) & "ghi"
    Debug.Print myString

End Sub

