Option Strict

Public Module MainModule
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

        Console.ReadLine()
    End Sub

    Public Sub ForLoop_ZeroToNine()
        Dim i As Integer
        
        For i = 0 To 9
            Console.WriteLine(i)
        Next i  
    End Sub


    Public Sub ForLoop_OneToTen()
        Dim i As Integer
        
        For i = 1 To 10
            Console.WriteLine(i)
        Next i  
    End Sub

    Public Sub ForLoop_NineToZero()
        Dim i As Integer
        
        For i = 9 To 0 Step -1
            Console.WriteLine(i)
        Next i 
    End Sub

    Public Sub ForLoop_JumpTwo()
        Dim i As Integer
        
        For i = 0 To 9 Step 2
            Console.WriteLine(i)
        Next i
    End Sub

    Public Sub LoopWhile()
        Dim i As Integer = 0

        Do While i < 10
            Console.WriteLine(i)
            i = i + 1
        Loop    
    End Sub

    Public Sub LoopWhile_AtLeastOneIteration()
        Dim i As Integer = 10

        Do
            Console.WriteLine(i)
            i = i + 1
        Loop While i < 10
    End Sub

    Public Sub EndlessLoopWithEmergencyExit()
        Dim i As Integer = 0

        Do While True
            i = i + 1
            Console.WriteLine(i)
            
            If i > 100 Then
                Exit Do
            End If
        Loop 
    End Sub

    Public Sub ForEach()
        Dim myArray() As String = {"abc", "def", "ghi", "jkl"}
        Dim mySingleString As String

        For Each mySingleString In myArray
            Console.WriteLine(mySingleString)
        Next mySingleString
    End Sub

    Public Sub DeFactoForEach()
        Dim myArray() As String = {"abc", "def", "ghi", "jkl"}
        Dim i As Integer

        For i = 0 To UBound(myArray)
            Console.WriteLine(myArray(i))
        Next i    
    End Sub

    Public Sub ForEachCharInString()
        Dim myString As String = "LGBSMNLKRK"
        Dim singleChar as Char

        for each singleChar in myString
            Console.WriteLine(singleChar)
        next singleChar        
    End Sub

    Public Sub DeFactoForEachCharInString()

        Dim myString As String = "LGBSMNLKRK"
        Dim i as Integer

        For i = 0 To Len(myString) - 1
            Console.WriteLine(myString(i))
        Next i
    End Sub

End Module
