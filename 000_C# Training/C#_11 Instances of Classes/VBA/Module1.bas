Attribute VB_Name = "Module1"
Option Explicit

Public Sub Main()
    DeclareWriteAndRead
    SaveClassInstanceForFurtherUse_Collection
    SaveClassInstanceForFurtherUse_Array 'not possible
    Inherit_ExtendFunctionalityOfClass 'not possible
End Sub

Public Sub DeclareWriteAndRead()

    ' there are no static class variables in VBA, so "myStaticVariable" is off

    Dim first As New MyClass
    Dim second As New MyClass

    first.myNonStaticVariable = 99
    first.myNonStaticVariable2 = 77

    second.myNonStaticVariable = 88
    second.myNonStaticVariable2 = 55

    Debug.Print first.myNonStaticVariable
    Debug.Print first.myNonStaticVariable2
    Debug.Print second.myNonStaticVariable
    Debug.Print second.myNonStaticVariable2
   
End Sub

Public Sub SaveClassInstanceForFurtherUse_Collection()

    Dim myColl As Object
    Dim classInstance
    
    Set myColl = New Collection
    
    Dim first As New MyClass
    Dim second As New MyClass

    first.myNonStaticVariable = 99
    first.myNonStaticVariable2 = 77

    second.myNonStaticVariable = 88
    second.myNonStaticVariable2 = 55

    myColl.Add first
    myColl.Add second

    'Further use:

    For Each classInstance In myColl
        Debug.Print classInstance.myNonStaticVariable
        Debug.Print classInstance.myNonStaticVariable2
    Next classInstance
End Sub

Public Sub SaveClassInstanceForFurtherUse_Array()
    'not possible in VBA
    'consult SaveClassInstanceForFurtherUse_Collection
End Sub


Public Sub Inherit_ExtendFunctionalityOfClass()
    'VBA does not support inheritance
End Sub
    
End Sub
