Option Strict

Public Module MainModule
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

        Console.ReadLine()
    End Sub

    Public Sub IfInstruction()
        Dim x As String = "abc"
        Dim y As String = ""
        
        If x = "abc" Then
            y = "Good"
        ElseIf x = "def" Then
            y = "Not Good"
        Else
            y = "Indifferent"
        End If
        
        Console.WriteLine(y)
    End Sub

    Public Sub IfInstruction2()
        Dim x As Integer = 23
        Dim y As Integer = 0
        
        If x <= 30 Then
            y = x * 2
        ElseIf x <= 50 Then
            y = x * 3
        Else
            y = x * 4
        End If

        Console.WriteLine(y)
    End Sub


    Public Sub IfShort_OnlyWhenOneLiners()
        'not relevant in VBA
        
        Dim x As String = "abc"
        Dim y As String = ""
        
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

        Console.WriteLine(y)
    End Sub

    Public Sub IfAndOr()
        Dim x As Integer = 20
        Dim y As Integer = 30
        
        If x = 20 And y = 40 Then
            Console.WriteLine("TRUE")
        Else
            Console.WriteLine("FALSE")
        End If

        If x = 20 Or y = 40 Then
            Console.WriteLine("TRUE")
        Else
            Console.WriteLine("FALSE")
        End If
    End Sub

    Public Sub NotEqual()
        Dim x As Integer = 20

        If x <> 20 Then
            Console.WriteLine("TRUE")
        Else
            Console.WriteLine("FALSE")
        End If
    End Sub

    Public Sub Not_Instruction()
        Dim x As Boolean = True

        If x = True Then Console.WriteLine("a")

        If x Then Console.WriteLine("a")

        If x = False Then Console.WriteLine("b")
        
        If Not x Then Console.WriteLine("b")
    End Sub

    Public Sub Not_Instruction2()
        Dim x As String = "abc"

        If x.Contains("b") Then Console.WriteLine("a")

        If Not x.Contains("f") Then Console.WriteLine("b")
    End Sub

    Public Sub Not_Instruction3()
        Dim x As String = "abc"
        Dim trueFalse As Boolean
        
        trueFalse = x = "abc"

        If trueFalse Then Console.WriteLine("a")

        If Not trueFalse Then Console.WriteLine("b")
    End Sub

    Public Sub Switch_Instruction()
        Dim y As Integer = 30

        Select Case y
            Case 24:
                Console.WriteLine("Is 24")
            Case 30:
                Console.WriteLine("Is 30")
            Case 35, 36:
                Console.WriteLine("Is 35 or 36")
            Case Else:
                Console.WriteLine("Is something else")
        End Select
    End Sub
End Module
