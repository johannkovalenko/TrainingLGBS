Attribute VB_Name = "Module1"
Option Explicit

Dim globalString As String

Public Sub Main()

    PassAndReturnTypeByValue
    PassAndReturnSeveralSameTypesByValue
    PassAndReturnDifferentTypesByValue

    ReturnTypesByOut

    PassAndReturnTypesByRef_DeFactoGlobal

    GlobalStringMethod

    Pitfall_PassComplexTypeByValue
    Solution_Pitfall_PassComplexTypeByValue

    Obsolete_PassComplexTypeByRef
    
End Sub

Public Sub PassAndReturnTypeByValue()

    Dim myString As String

    myString = PassAndReturnTypeByValue_Helper("ABC")
    
    Debug.Print myString
End Sub

Public Function PassAndReturnTypeByValue_Helper(myString As String) As String

    PassAndReturnTypeByValue_Helper = "DEF"
End Function

Public Sub PassAndReturnSeveralSameTypesByValue()
    
    Dim myStrings() As String
    
    myStrings = PassAndReturnSeveralSameTypesByValue_Helper("ABC", "DEF")
    
    Debug.Print myStrings(0) & " " & myStrings(1)
End Sub

Public Function PassAndReturnSeveralSameTypesByValue_Helper(myString As String, myString2 As String) As String()
    
    myString = "GHI"
    myString2 = "JKL"

    Dim myStrings(1) As String
    myStrings(0) = myString
    myStrings(1) = myString2
    
    PassAndReturnSeveralSameTypesByValue_Helper = myStrings
End Function

Public Sub PassAndReturnDifferentTypesByValue()

    Dim myclass As myclass
    
    Set myclass = PassAndReturnDifferentTypesByValue_Helper("ABC", 1)
    
    Debug.Print myclass.myString & " " & myclass.myInt
End Sub

Public Function PassAndReturnDifferentTypesByValue_Helper(myString As String, myInt As Integer) As myclass

    Dim myclass As New myclass

    myclass.myString = myString & "DEF"
    myclass.myInt = myInt + 2

    Set PassAndReturnDifferentTypesByValue_Helper = myclass
End Function

Public Sub ReturnTypesByOut()

    '   "out" does not exist in VBA
    
End Sub


Public Sub PassAndReturnTypesByRef_DeFactoGlobal()

    Dim myString As String
    Dim myInt As Integer
    
    myString = "aaa"
    myInt = 0
    
    PassAndReturnTypesByRef_DeFactoGlobal_Helper myString, myInt
    
    Debug.Print myString & " " & myInt
End Sub

Public Sub PassAndReturnTypesByRef_DeFactoGlobal_Helper(ByRef myString As String, ByRef myInt As Integer)

   myString = "ABC"
   myInt = 22
End Sub


Public Sub GlobalStringMethod()

    GlobalString_Helper
    
    Debug.Print globalString
End Sub

Public Sub GlobalString_Helper()

    globalString = "DEF"
End Sub

Public Sub Pitfall_PassComplexTypeByValue()

    Dim myDict As New Dictionary
    
    myDict.Add 1, 10

    Dim myInts(0) As Integer
    myInts(0) = 5
    
    Pitfall_PassComplexTypeByValue_Helper myDict, myInts

    Debug.Print myDict(1) & " " & myInts(0)

    'Expected Value:   10 5
    'Real Value:       50 20

    'Explanation: Complex Data Types cannot be passed by value. (ByValue = making a copy)
    'When passing an complex type, we pass in fact its start address.
    'So any change done in the called function is a change on the original element
End Sub


Public Sub Pitfall_PassComplexTypeByValue_Helper(myDict As Dictionary, myInts() As Integer)

    myDict(1) = 50
    myInts(0) = 20
End Sub

Public Sub Solution_Pitfall_PassComplexTypeByValue()

    Dim myDict As New Dictionary
    myDict.Add 1, 10

    Dim myInts(0) As Integer
    myInts(0) = 5

    Solution_Pitfall_PassComplexTypeByValue_Helper myDict, myInts

    Debug.Print myDict(1) & " " & myInts(0)

    'Expected Value:   10 5
    'Real Value:       10 5

    'Explanation: a deep copy (dictionary) or clone (array) creates a copy of the complex type
    'and puts it to a new address. now every change under the new address has no effect to the object under the old address

    'Attention: although this solution solves the problem, it is not recommended to pass complex types
    ' by clone/deep copy, because it is very uneconomical.
End Sub

Public Sub Solution_Pitfall_PassComplexTypeByValue_Helper(myDict As Dictionary, myInts() As Integer)

    Dim myCopiedDict As New Dictionary
    Dim key
    Dim i
    
    For Each key In myDict.Keys
        myCopiedDict.Add key, myDict(key)
    Next key
    
    
    Dim myClonedInts() As Integer
    ReDim myClonedInts(UBound(myInts))

    For i = 0 To UBound(myInts)
        myClonedInts(i) = myInts(i)
    Next i


    myCopiedDict(1) = 50
    myClonedInts(0) = 20
End Sub

Public Sub Obsolete_PassComplexTypeByRef()

    Dim myDict As New Dictionary
    myDict.Add 1, 10

    Dim myInts(0) As Integer
    myInts(0) = 5

    Obsolete_PassComplexTypeByRef_Helper myDict, myInts

    Debug.Print myDict(1) & " " & myInts(0)

    'Explanation: ref is obsolete here, because all complex types are by default passed by reference
End Sub

Public Sub Obsolete_PassComplexTypeByRef_Helper(ByRef myDict As Dictionary, ByRef myInts() As Integer)

    myDict(1) = 50
    myInts(0) = 20
End Sub




