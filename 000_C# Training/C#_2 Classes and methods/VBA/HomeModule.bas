Attribute VB_Name = "HomeModule"
Option Explicit

Public Sub Main()
    MethodInTheSameModule
    OtherModule.MethodInAnotherModule
    
    Dim returnValue As String
    returnValue = MethodReturningValue()
    MsgBox returnValue
    
    MethodReceivingValue "XYZ"

End Sub


Public Sub MethodInTheSameModule()
    MsgBox "Hello, i am the method in the same module. I don't return anything, that's why I am called 'Sub' in VBA. My C# counterpart would be 'static void'"
End Sub

Public Function MethodReturningValue() As String
    MsgBox "Hello, I return a string, that's why I am called 'Function' in VBA. My C# counterpart would be 'static string'"

    MethodReturningValue = "ABC"
End Function

Public Sub MethodReceivingValue(receivedString As String)
    MsgBox "Hello, I received the string " & receivedString & "."
End Sub

