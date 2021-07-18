Attribute VB_Name = "Module1"
Option Explicit

Public Sub Main()

    ForLoop_ZeroToNine
    ForLoop_OneToTen
    ForLoop_NineToZero
    ForLoop_JumpTwo
    LoopWhile
    LoopWhile_AtLeastOneIteration
    EndlessLoopWithEmergencyExit
    ForEach
    DeFactoForEach
    ForEachCharInString
    DeFactoForEachCharInString

End Sub

Public Sub ForLoop_ZeroToNine()
    Dim i
    
    For i = 0 To 9
        Debug.Print i
    Next i
    
End Sub


Public Sub ForLoop_OneToTen()
    Dim i
    
    For i = 1 To 10
        Debug.Print i
    Next i
    
End Sub

Public Sub ForLoop_NineToZero()
    Dim i
    
    For i = 9 To 0 Step -1
        Debug.Print i
    Next i
    
End Sub

Public Sub ForLoop_JumpTwo()

    Dim i
    
    For i = 0 To 9 Step 2
        Debug.Print i
    Next i
    
End Sub

Public Sub LoopWhile()

    Dim i As Integer
    i = 0

    Do While i < 10
        Debug.Print i
        i = i + 1
    Loop
    
End Sub

Public Sub LoopWhile_AtLeastOneIteration()
    
    Dim i As Integer
    i = 10

    Do
        Debug.Print i
        i = i + 1
    Loop While i < 10
    
End Sub

Public Sub EndlessLoopWithEmergencyExit()

    Dim i As Integer
    i = 0

    Do While True
        i = i + 1
        Debug.Print i
        
        If i > 100 Then
            Exit Do
        End If
    Loop
    
End Sub


Public Sub ForEach()

    Dim myArray()
    Dim mySingleString
    
    'attention, Array() creates a variant array, not a string array
    myArray = Array("abc", "def", "ghi", "jkl")

    For Each mySingleString In myArray
        Debug.Print mySingleString
    Next mySingleString

End Sub

Public Sub DeFactoForEach()

    Dim myArray()
    Dim i
    
    'attention, Array() creates a variant array, not a string array
    myArray = Array("abc", "def", "ghi", "jkl")

    For i = 0 To UBound(myArray)
        Debug.Print myArray(i)
    Next i
        
End Sub

Public Sub ForEachCharInString()

    'not possible in VBA, consult DeFactoForEachCharInString()
    
End Sub

Public Sub DeFactoForEachCharInString()

    Dim myString As String
    myString = "LGBSMNLKRK"
    Dim i

    For i = 1 To Len(myString)
        Debug.Print Mid(myString, i, 1)
    Next i
End Sub
