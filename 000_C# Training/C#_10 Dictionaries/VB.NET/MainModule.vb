Option Strict

Imports System.Collections.Generic

Public Module MainModule
    Public Sub Main()

        Dim myIntStringDict As Dictionary(Of Integer, String)
        Dim myNestedDictionary As Dictionary(Of Integer, Integer())

        CreateAndFillDictionary

        myIntStringDict = CreateAndFillDictionaryAndReturnIt
        
        GetValueOfKey

        OverwriteWhenItemExists

        LoopThroughAllElementsOfList(myIntStringDict)
        
        myNestedDictionary = CreateAndFillNestedDictionary

        LoopThroughAllElementsOfNestedDictionary(myNestedDictionary)

        OverwriteWhenItemExistsNested(myNestedDictionary)
        ManipulateValueWhenItemExistsNested(myNestedDictionary)

        Exercise_CountAppearances

        Pitfall_1
        Solution_Pitfall_1

        Pitfall_2
        Solution_Pitfall_2

        Pitfall_3
        Solution_Pitfall_3

        Console.ReadLine()
    End Sub

    Public Sub CreateAndFillDictionary()
        Dim i As Integer
        Dim myIntStringDict As New Dictionary(Of Integer, String)
        Dim myStringIntDict As New Dictionary(Of String, Integer)

        If Not myIntStringDict.ContainsKey(34) Then
            myIntStringDict.Add(34, "abc")
        End If

        If Not myIntStringDict.ContainsKey(34) Then
            myIntStringDict.Add(34, "abc")
        End If

        For i = 5 To 7
            If Not myIntStringDict.ContainsKey(i) Then
                myIntStringDict.Add(i, "abc")
            End If
        Next i
        
        If Not myStringIntDict.ContainsKey("34") Then
            myStringIntDict.Add("34", 111)
        End If

        If Not myStringIntDict.ContainsKey("34") Then
            myStringIntDict.Add("34", 111)
        End If

        For i = 5 To 7
            If Not myStringIntDict.ContainsKey(CStr(i)) Then
                myStringIntDict.Add(CStr(i), 111)
            End If
        Next i
    End Sub

    Public Function CreateAndFillDictionaryAndReturnIt() As Dictionary(Of Integer, String)
        Dim myIntStringDict As New Dictionary(Of Integer, String)
        Dim i as Integer

        If Not myIntStringDict.ContainsKey(34) Then
            myIntStringDict.Add(34, "abc")
        End If

        If Not myIntStringDict.ContainsKey(34) Then
            myIntStringDict.Add(34, "abc")
        End If

        For i = 5 To 7
            If Not myIntStringDict.ContainsKey(i) Then
                myIntStringDict.Add(i, "abc")
            End If
        Next i

        CreateAndFillDictionaryAndReturnIt = myIntStringDict 
    End Function

    Public Sub GetValueOfKey()
        Dim myIntStringDict As New Dictionary(Of Integer, String)
        Dim myString As String

        myIntStringDict.Add(34, "abc")

        If myIntStringDict.ContainsKey(34) Then
            myString = myIntStringDict(34)
            Console.WriteLine(myString)
        End If
    End Sub

    Public Sub OverwriteWhenItemExists()
        Dim myIntIntDict As New Dictionary(Of Integer, Integer)
        
        myIntIntDict.Add(45, 1)

        If myIntIntDict.ContainsKey(45) Then
            myIntIntDict(45) = 2
        Else
            myIntIntDict.Add(45, 2)
        End If

        Console.WriteLine(myIntIntDict(45))
    End Sub

    Public Sub LoopThroughAllElementsOfList(myIntStringDict As Dictionary(Of Integer, String))
        Dim item As Integer
        Dim pair As KeyValuePair(Of Integer, String)
        Dim keyCollection As Dictionary(Of Integer, String).KeyCollection
        Dim i As Integer

        Console.WriteLine("Approach 1:")
        For Each item In myIntStringDict.Keys
            Console.WriteLine("Key: " & item & Chr(9) & "Value: " & myIntStringDict(item))
        Next item

        Console.WriteLine((vbCrLf & "Approach 2:"))
        For Each pair In myIntStringDict
            Console.WriteLine("Key: " & pair.Key & Chr(9) & "Value: " & pair.Value)
        Next pair        

        Console.WriteLine(vbCrLf & "Approach 3:")
        For i = 0 To myIntStringDict.Count - 1
            Console.WriteLine("Key: " & myIntStringDict.Keys(i) & vbTab & "Value: " & myIntStringDict.Values(i))
        Next i

        Console.WriteLine(vbCrLf & "Approach 4:")
        keyCollection = myIntStringDict.Keys
        
        For Each item In keyCollection
            Console.WriteLine("Key: " & item & vbTab & "Value: " & myIntStringDict(item))
        Next item
    End Sub

    Public Function CreateAndFillNestedDictionary() As Dictionary(Of Integer, Integer())
        Dim myNestedDictionary As New Dictionary(Of Integer, Integer())

        Dim testCounter As Integer = 0
        Dim i As Integer
        Dim j As Integer

        For i = 5 To 7
            Dim tempArray(9) As Integer

            For j = 0 To 9
                testCounter = testCounter + 1
                tempArray(j) = testCounter
            Next j

            myNestedDictionary.Add(i, tempArray)
        Next i
        
        CreateAndFillNestedDictionary = myNestedDictionary
    End Function

    Public Sub LoopThroughAllElementsOfNestedDictionary(myNestedDictionary As Dictionary(Of Integer, Integer()))
        Dim key As Integer
        Dim item As Integer

        For Each key In myNestedDictionary.Keys
            For Each item In myNestedDictionary(key)
                Console.WriteLine(item)
            Next item
        Next key
    End Sub

    Public Sub OverwriteWhenItemExistsNested(myNestedDictionary As Dictionary(Of Integer, Integer()))
        Dim testInt As Integer
        
        If myNestedDictionary.ContainsKey(5) Then
            Dim tempInt() As Integer = {3, 5, 6, 3, 2, 3}            
            myNestedDictionary(5) = tempInt
        End If

        For Each testInt In myNestedDictionary(5)
            Console.WriteLine(testInt)
        Next testInt
    End Sub

    Public Sub ManipulateValueWhenItemExistsNested(myNestedDictionary As Dictionary(Of Integer, Integer()))
        Dim tempArray() As Integer
        Dim testInt As Integer

        If myNestedDictionary.ContainsKey(5) Then
            tempArray = myNestedDictionary(5)
            tempArray(4) = 555
            myNestedDictionary(5) = tempArray
        End If

        For Each testInt In myNestedDictionary(5)
            Console.WriteLine(testInt)
        Next testInt   
    End Sub

    Public Sub Exercise_CountAppearances()
        Dim inputNames() As String = {"Pat", "Ann", "Paul", "Paul", "Joe", "Mike", "Pat", "Paul"}
        Dim name As String
        
        Dim outputDict As New Dictionary(Of String, Integer)

        For Each name In inputNames
            If Not outputDict.ContainsKey(name) Then
                outputDict.Add(name, 1)
            Else
                outputDict(name) += 1
            End If
        Next name

        For Each name In outputDict.Keys
            Console.WriteLine(name & vbTab & outputDict(name))
        Next name
    End Sub

    Public Sub Pitfall_1()
        'Most problems connected to Dictionaries are due to the fact that dictionaries link by reference

        Dim tempInt(0) As Integer
        Dim i As Integer
        Dim key As Integer

        Dim myDict As New Dictionary(Of Integer, Integer())

        For i = 0 To 2
            tempInt(0) = i
            myDict.Add(i, tempInt)

            For Each key In myDict.Keys
                Console.WriteLine(myDict(key)(0))
            Next key
        Next i

        'Expected output:  0, 0 1, 0 1 2
        'Real output:      0, 1 1, 2 2 2

        'Explanation: the dictionary links to the address of "tempInt"
        'the adddress of "tempInt" never changes though (= there is only one instance of "tempInt"
        'every item of myDict points to the same address of "tempInt"
        'hence every change of "tempInt" results in the change of every value of "myDict"
    End Sub

    Public Sub Solution_Pitfall_1()
        Dim i As Integer
        Dim key As Integer

        Dim myDict As New Dictionary(Of Integer, Integer())

        For i = 0 To 2
            Dim tempInt(0) As Integer
            tempInt(0) = i
            myDict.Add(i, tempInt)

            For Each key In myDict.Keys
                Console.WriteLine(myDict(key)(0))
            Next key
        Next i

        'Expected output:  0, 0 1, 0 1 2
        'Real output:      0, 0 1, 0 1 2

        'Explanation: now there are three addresses (three instances) of "tempArray"
        'so any change in one instance of "tempArray" does not affect the rest of instances
    End Sub


    Public Sub Pitfall_2()
        Dim myDict As New Dictionary(Of Integer, Integer())

        myDict.Add(0, New Integer(){0})
        myDict.Add(1, New Integer(){1})

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        myDict(1) = myDict(0)

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        myDict(0)(0) = 9

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        myDict(1)(0) = 8

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        'Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
        'Real outputs:         0   1   |   0   0   |   9   9   |   8   8

        'When copying one entry to another, suddenly every further change in ANY value affects both entries.
        'Explanation: when copying one entry to another, we ONLY copy the address
        ' -> both entries now point to the same address in memory
        ' -> any change in the address pointed to affects both entries.
    End Sub

    Public Sub Solution_Pitfall_2()
        Dim myDict As New Dictionary(Of Integer, Integer())

        myDict.Add(0, New Integer(){0})
        myDict.Add(1, New Integer(){1})

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        Array.Copy(myDict(0), myDict(1), myDict(0).Length)

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        myDict(0)(0) = 9

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        myDict(1)(0) = 8

        Console.WriteLine(myDict(0)(0))
        Console.WriteLine(myDict(1)(0))

        'Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
        'Real outputs:         0   1   |   0   0   |   9   0   |   9   8

        'Explanation: when cloning an array, a copy of the array under a NEW ADDRESS is created
        ' -> every entries now points to a different address in memory
        ' -> any change in one address does not affect the other address.
    End Sub

    Public Sub Pitfall_3()
        Dim myDict As New Dictionary(Of Integer, Integer())

        myDict.Add(0, New Integer(){0})

        Console.WriteLine(myDict(0)(0))
        
        Pitfall_3_Helper(myDict)

        Console.WriteLine(myDict(0)(0))

        'Expected outputs:     0   0
        'Real output:          0   9

        'When calling a function with parameter (which is NOT by reference), we expect no change in the original dictionary
        'But the dictionary calls to the address of the int()
        'so no matter where we change the int(), it will always affect the whole dictionary
        '(which is actually a very good behavior, nobodys wants to copy dictionaries)
    End Sub

    Public Sub Solution_Pitfall_3()
        Dim myDict As New Dictionary(Of Integer, Integer())
        Dim myDictCopy As New Dictionary(Of Integer, Integer())(myDict)

        myDict.Add(0, New Integer(){0})

        Console.WriteLine(myDict(0)(0))
        
        Pitfall_3_Helper(myDictCopy)

        Console.WriteLine(myDict(0)(0))

        'Expected outputs:     0   0
        'Real output:          0   0

        'By copying the whole dictionary, a second address is created
        'a change in one address does not affect the second address
    End Sub

    public sub Pitfall_3_Helper(myDict As Dictionary(Of Integer, Integer()))
        myDict(0) = New Integer(){9}
    End Sub
End Module
