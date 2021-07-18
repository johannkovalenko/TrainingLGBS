Option Strict

Imports System.Collections.Generic
Imports System.IO

Module MainModule
    Public Sub Main()
        
        DeclareWriteAndRead
        SaveclassInstanceForFurtherUse_List
        SaveclassInstanceForFurtherUse_Array
        Inherit_ExtendFunctionalityOfClass
        Initializer
        GetterSetter

        Console.ReadLine()
    End Sub

    Public Sub DeclareWriteAndRead()
        MyModule.myStaticVariable = 66

        'Attention: MyClass is a reserved word in VB.net. it's the equivalent of "this" in C#
        'So don't call you class "MyClass"

        Dim first As New MojaClass
        Dim second As New MojaClass

        first.myNonStaticVariable = 99
        first.myNonStaticVariable2 = 77

        second.myNonStaticVariable = 88
        second.myNonStaticVariable2 = 55        

        Console.WriteLine(MyModule.myStaticVariable)
        Console.WriteLine(first.myNonStaticVariable)
        Console.WriteLine(first.myNonStaticVariable2)
        Console.WriteLine(second.myNonStaticVariable)
        Console.WriteLine(second.myNonStaticVariable2) 
    End Sub

    Public Sub SaveclassInstanceForFurtherUse_List()
        Dim myList As New List(Of MojaClass)

        Dim first As New MojaClass
        Dim second As New MojaClass

        first.myNonStaticVariable = 99
        first.myNonStaticVariable2 = 77

        second.myNonStaticVariable = 88
        second.myNonStaticVariable2 = 55 

        myList.Add(first)
        myList.Add(second)

        'Further use:
        Dim classInstance As MojaClass

        for each classInstance in myList
            Console.WriteLine(classInstance.myNonStaticVariable)
            Console.WriteLine(classInstance.myNonStaticVariable2)
        next classInstance
    End Sub

    Public Sub SaveclassInstanceForFurtherUse_Array()
        Dim myArray(1) As MojaClass

        Dim first As New MojaClass
        Dim second As New MojaClass

        first.myNonStaticVariable = 99
        first.myNonStaticVariable2 = 77

        second.myNonStaticVariable = 88
        second.myNonStaticVariable2 = 55 

        myArray(0) = first
        myArray(1) = second

        'Further use:
        Dim i As Integer

        for i = 0 to UBound(myArray)
            Console.WriteLine(myArray(i).myNonStaticVariable)
            Console.WriteLine(myArray(i).myNonStaticVariable2)
        next i
    End Sub

    Public Sub Inherit_ExtendFunctionalityOfClass()
        'Take all functionality of List<int> but add own (hopefully better) functionality to it.

        dim list as new ListJK(New Integer() {6, 5, 3, 2, 5, 6, 9, 8})
        list.Add(1)
        list.Add(15)

        if list.Contains(5) then
            Console.WriteLine("Contains 5")
        end if

        list.SortJK()
        list.PrintJK()
    End Sub

    Public Sub Initializer()
        Dim myClass2 As New MyClass2(32, "Johann")
        Console.WriteLine(myClass2.myInt)
        Console.WriteLine(myClass2.myString)
    End Sub

    Public Sub GetterSetter()
        ' C# and VB.net do not require Getters and Setters, Java does not have them, Ruby and VBA require them
        Dim myClass3 As New MyClass3()
        myClass3.myInt = 1
        Console.WriteLine(myClass3.myInt)
    End Sub
End Module

Module MyModule
    Public myStaticVariable As Integer
End Module

public Class MojaClass
    Public myNonStaticVariable As Integer
    Public myNonStaticVariable2 As Integer
End Class

public Class MyClass2
    Public Sub New(myInt As Integer, myString As String)
        MyClass.myInt = myInt
        MyClass.myString = myString
    End Sub

    Public myInt As Integer
    Public myString As String
End Class

public Class MyClass3
    Private _myInt As Integer

    Public Property myInt() As Integer
        Get
            Return _myInt + 5
        End Get
        
        Set
            _myInt = value + 5
        End Set
    End Property
End Class

public Class ListJK
    Inherits List(Of Integer)
    
    Public Sub New()
    
    End Sub

    Public Sub New (input As Integer())
        Dim singleInt as Integer

        for each singleInt in input
            MyBase.Add(singleInt)
        next singleInt
    End Sub

    Public Sub SortJK()
        dim maximumNumber as integer = 0
        dim finalCounter as integer = 0
        dim i as integer
        dim j as integer

        for i = 0 to MyBase.Count - 1
            if MyBase.Item(i) > maximumNumber then
                maximumNumber = MyBase.Item(i)
            end if
        next i

        dim finalArray(maximumNumber) as integer

        for i = 0 to MyBase.Count - 1
            finalArray(MyBase.Item(i)) += 1
        next i

        for i = 0 to ubound(finalArray)
            for j = 0 to finalArray(i) - 1
                MyBase.Item(finalCounter) = i
                finalCounter += 1
            next j
        next i
    End Sub

    Public Sub PrintJK()
        dim i as integer

        for i = 0 to MyBase.Count - 1
            Console.Write(MyBase.Item(i) & " ")
        next i
        Console.WriteLine()
    End Sub
End Class
