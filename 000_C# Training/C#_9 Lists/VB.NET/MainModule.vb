Option Strict

Imports System.Collections.Generic

Public Module MainModule
    Public Sub Main()
        Dim myIntList As List(Of Integer)
        Dim myNestedIntList As List(Of Integer())

        CreateAndFillList
        
        myIntList = CreateAndFillListAndReturnIt

        CheckIfItemExists

        LoopThroughAllElementsOfList(myIntList)
        
        myNestedIntList = CreateAndFillNestedList

        LoopThroughAllElementsOfNestedList(myNestedIntList)

        Exercise_EliminateDoubleAppearances 

        Console.ReadLine() 
    End Sub

    Public Sub CreateAndFillList()
        Dim myIntList As New List(Of Integer)
        Dim myStringList As New List(Of String)
        Dim i As Integer

        myIntList.Add(34)
        myIntList.Add(34)

        For i = 5 To 7
            myIntList.Add(i)
        Next i

        myStringList.Add("34")
        myStringList.Add("34")

        For i = 5 To 7
            myStringList.Add(CStr(i))
        Next i
    End Sub

    Public Function CreateAndFillListAndReturnIt() As List(Of Integer)
        Dim myIntList As New List(Of Integer)
        Dim i As Integer

        myIntList.Add(34)
        myIntList.Add(34)

        For i = 5 To 7
            myIntList.Add(i)
        Next i

        CreateAndFillListAndReturnIt = myIntList 
    End Function

    Public Sub CheckIfItemExists()
        Dim myIntList As New List(Of Integer)

        If Not myIntList.Contains(45) Then
            myIntList.Add(45)
        End If   
    End Sub

    Public Sub LoopThroughAllElementsOfList(myIntList As List(Of Integer))
        Dim item As Integer
        Dim i As Integer
        
        For Each item In myIntList
            Console.WriteLine(item)
        Next item

        For i = 0 To myIntList.Count - 1
            Console.WriteLine(myIntList(i))
        Next i
    End Sub

    Public Function CreateAndFillNestedList() As List(Of Integer())
        Dim myIntList As New List(Of Integer())

        Dim testCounter As Integer
        Dim i As Integer
        Dim j As Integer

        testCounter = 0

        For i = 5 To 7
            Dim tempArray(9) As Integer

            For j = 0 To 9
                testCounter = testCounter + 1
                tempArray(j) = testCounter
            Next j

            myIntList.Add(tempArray)
        Next i

        CreateAndFillNestedList = myIntList    
    End Function

    Public Sub LoopThroughAllElementsOfNestedList(myNestedIntList As List(Of Integer()))    
        Dim itemArray() As Integer
        Dim item As Integer
        Dim i As Integer
        Dim j As Integer

        For Each itemArray In myNestedIntList
            For Each item In itemArray
                Console.WriteLine(item)
            Next item
        Next itemArray

        For j = 0 To myNestedIntList.Count - 1
            For i = 0 To Ubound(myNestedIntList(j))
                Console.WriteLine(myNestedIntList(j)(i))
            Next i
        Next j    
    End Sub

    Public Sub Exercise_EliminateDoubleAppearances()
        Dim inputNumbers() As Integer = {3, 7, 5, 5, 4, 3, 2, 7}
        Dim number As Integer

        Dim outputList As New List(Of Integer)

        For Each number In inputNumbers
            If Not outputList.Contains(number) Then
                outputList.Add(number)
            End If
        Next number

        For Each number In outputList
            Console.WriteLine(number)
        Next number
    End Sub
End Module
