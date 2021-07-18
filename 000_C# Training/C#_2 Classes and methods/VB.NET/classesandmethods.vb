Option Strict

Public Module HomeModule
    Public Sub Main()
        MethodInTheSameModule
        OtherModule.MethodInAnotherModule
        
        Dim returnValue As String
        returnValue = MethodReturningValue()
        Console.WriteLine(returnValue)
        
        MethodReceivingValue("XYZ")

        Console.ReadLine()
    End Sub

    Public Sub MethodInTheSameModule()
        Console.WriteLine("Hello, i am the method in the same module. I don't return anything, that's why I am called 'Sub' in VBA. My C# counterpart would be 'static void'")
    End Sub

    Public Function MethodReturningValue() As String
        Console.WriteLine("Hello, I return a string, that's why I am called 'Function' in VBA. My C# counterpart would be 'static string'")

        MethodReturningValue = "ABC"
    End Function

    Public Sub MethodReceivingValue(receivedString As String)
        Console.WriteLine("Hello, I received the string " + receivedString + ".")
    End Sub
End Module

Public Module OtherModule
    Public Sub MethodInAnotherModule()
        Console.WriteLine("Hello, I am the method in another module")
    End Sub
End Module