Option Strict

Public Module HomeModule
    Public globalVariableInHomeModule As String

    Public Sub Main()
        MyStrings
        MyInts
        MyArray
        AccessGlobalVariables

        Console.ReadLine()
    End Sub

    Public Sub MyStrings()
        Dim myString1 As String
        Dim myString2 As String
        Dim myString3 As String
        
        myString1 = "ABC"
        myString2 = "DEF"
        myString3 = myString1 + myString2
        Console.WriteLine(myString3)
    End Sub

    Public Sub MyInts()
        Dim myInt1 As Integer
        Dim myInt2 As Integer
        Dim myInt3 As Integer
        
        myInt1 = 7
        myInt2 = 5
        myInt3 = myInt1 * myInt2
        Console.WriteLine(myInt3)
    End Sub

    Public Sub MyArray()
        
        Dim myStringArray() As String
        Dim myString As String
        
        myStringArray = {"abc", "def", "ghi"}

        myString = myStringArray(2)
        Console.WriteLine(myString)

        Dim myStringArray2(2) As String
        
        myStringArray2(0) = "abc"
        myStringArray2(1) = "def"
        myStringArray2(2) = "ghi"
        Console.WriteLine(myStringArray2(2))

    End Sub

    Public Sub AccessGlobalVariables()
        Dim myConcatString As String
        
        globalVariableInHomeModule = "DEF"
        OtherModule.globalVariableInOtherModule = "ABC"
        
        myConcatString = globalVariableInHomeModule + OtherModule.globalVariableInOtherModule
        
        Console.WriteLine(myConcatString)
    End Sub
End Module

Public Module OtherModule
    Public globalVariableInOtherModule As String
End Module