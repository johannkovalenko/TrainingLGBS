Attribute VB_Name = "Module1"
Option Explicit

Public Sub AddReference()

    ThisWorkbook.VBProject.References.AddFromFile "C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\mscorlib.tlb"

End Sub

Public Sub Main()

    Dim myIntList As ArrayList
    Dim myNestedIntList As ArrayList

    CreateAndFillList
    
    Set myIntList = CreateAndFillListAndReturnIt

    CheckIfItemExists

    LoopThroughAllElementsOfList myIntList
    
    Set myNestedIntList = CreateAndFillNestedList

    LoopThroughAllElementsOfNestedList myNestedIntList

    Exercise_EliminateDoubleAppearances
    
End Sub


Public Sub CreateAndFillList()

    Dim myIntList As New ArrayList
    Dim myStringList As New ArrayList
    Dim i

    myIntList.Add 34
    myIntList.Add 34

    For i = 35 To 49
        myIntList.Add i
    Next i

    
    myStringList.Add "34"
    myStringList.Add "34"

    For i = 35 To 49
        myStringList.Add CStr(i)
    Next i
    
End Sub

Public Function CreateAndFillListAndReturnIt() As ArrayList

    Dim myIntList As New ArrayList
    Dim i

    myIntList.Add 34
    myIntList.Add 34

    For i = 35 To 49
        myIntList.Add i
    Next i

    Set CreateAndFillListAndReturnIt = myIntList
    
End Function

Public Sub CheckIfItemExists()

    Dim myIntList As New ArrayList

    If Not myIntList.Contains(45) Then
        myIntList.Add 45
    End If
    
End Sub

Public Sub LoopThroughAllElementsOfList(myIntList As ArrayList)

    Dim item
    Dim i
    
    For Each item In myIntList
        Debug.Print item
    Next item

    For i = 0 To myIntList.Count - 1
        Debug.Print myIntList(i)
    Next i
End Sub

Public Function CreateAndFillNestedList() As ArrayList

'in this form not possible, because it is not possible to create instances of arrays
'in order to make the program work, I use "Collection" instead of instances of arrays

    Dim myIntList As New ArrayList

    Dim tempCollection As Object
    Dim testCounter As Integer
    Dim i
    Dim j

    testCounter = 0

    For i = 35 To 49

        Set tempCollection = New Collection


        For j = 0 To 9

            testCounter = testCounter + 1
            tempCollection.Add testCounter
        Next j

        myIntList.Add tempCollection
    Next i

    Set CreateAndFillNestedList = myIntList
    
End Function

Public Sub LoopThroughAllElementsOfNestedList(myNestedIntList As ArrayList)
    
    Dim itemArray
    Dim item
    Dim i
    Dim j

    For Each itemArray In myNestedIntList
        For Each item In itemArray
            Debug.Print item
        Next item
    Next itemArray

    For j = 0 To myNestedIntList.Count - 1
        For i = 1 To myNestedIntList(j).Count
            Debug.Print myNestedIntList(j)(i)
        Next i
    Next j
    
End Sub

Public Sub Exercise_EliminateDoubleAppearances()

    Dim inputNumbers()
    Dim number

    inputNumbers = Array(3, 7, 5, 5, 4, 3, 2, 7)
    
    Dim outputList As New ArrayList

    For Each number In inputNumbers
        If Not outputList.Contains(number) Then
            outputList.Add number
        End If
    Next number

    For Each number In outputList
        Debug.Print number
    Next number
End Sub
    




