Attribute VB_Name = "Module1"
Public Sub Main()
    IfInstruction
    IfInstruction2
    IfShort_OnlyWhenOneLiners
    IfAndOr
    NotEqual
    Not_Instruction
    Not_Instruction2
    Not_Instruction3
    Switch_Instruction

End Sub

Public Sub IfInstruction()
    Dim x As String
    Dim y As String
    
    x = "abc"
    y = ""

    If x = "abc" Then
        y = "Good"
    ElseIf x = "def" Then
        y = "Not Good"
    Else
        y = "Indifferent"
    End If
    
    Debug.Print y

End Sub

Public Sub IfInstruction2()
    Dim x As Integer
    Dim y As Integer
    
    x = 23
    y = 0

    If x <= 30 Then
        y = x * 2
    ElseIf x <= 50 Then
        y = x * 3
    Else
        y = x * 4
    End If

    Debug.Print y

End Sub


Public Sub IfShort_OnlyWhenOneLiners()
    'not relevant in VBA
    
    Dim x As String
    Dim y As String
    
    x = "abc"
    y = ""

    If x = "abc" Then
        y = "Good"
    ElseIf x = "def" Then
        y = "Not Good"
    ElseIf x = "ghi" Then
        x = x & "jkl"
        y = x
    Else
        y = "Indifferent"
    End If

    Debug.Print y

End Sub

Public Sub IfAndOr()
    Dim x As Integer
    Dim y As Integer
    
    x = 20
    y = 30

    If x = 20 And y = 40 Then
        Debug.Print "TRUE"
    Else
        Debug.Print "FALSE"
    End If

    If x = 20 Or y = 40 Then
        Debug.Print "TRUE"
    Else
        Debug.Print "FALSE"
    End If

End Sub

Public Sub NotEqual()
    Dim x As Integer

    x = 20

    If x <> 20 Then
        Debug.Print "TRUE"
    Else
        Debug.Print "FALSE"
    End If

End Sub

Public Sub Not_Instruction()
    Dim x As Boolean
    
    x = True

    If x = True Then Debug.Print "a"

    If x Then Debug.Print "a"

    If x = False Then Debug.Print "b"
    
    If Not x Then Debug.Print "b"

End Sub

Public Sub Not_Instruction2()
    Dim x As String
    
    x = "abc"

    If InStr(x, "b") Then Debug.Print "a"

    If Not InStr(x, "f") Then Debug.Print "b"
    
End Sub


Public Sub Not_Instruction3()
    Dim x As String
    Dim trueFalse As Boolean
    
    x = "abc"

    trueFalse = x = "abc"

    If trueFalse Then Debug.Print "a"

    If Not trueFalse Then Debug.Print "b"
    
End Sub

Public Sub Switch_Instruction()
    Dim y As Integer
    
    y = 30

    Select Case y
        Case 24:
            Debug.Print "Is 24"
        Case 30:
            Debug.Print "Is 30"
        Case 35, 36:
            Debug.Print "Is 35 or 36"
        Case Else:
            Debug.Print "Is something else"
    End Select
End Sub
    


