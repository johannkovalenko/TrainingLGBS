Attribute VB_Name = "Module1"
Option Explicit

Public Sub Main()

    '''
    ' Add reference "Microsoft Scripting Runtime"
    '''

    Dim myIntStringDict As Dictionary
    Dim myNestedDictionary As Dictionary

    CreateAndFillDictionary

    Set myIntStringDict = CreateAndFillDictionaryAndReturnIt
    
    GetValueOfKey

    OverwriteWhenItemExists

    LoopThroughAllElementsOfList (myIntStringDict)
    
    Set myNestedDictionary = CreateAndFillNestedDictionary

    LoopThroughAllElementsOfNestedDictionary (myNestedDictionary)

    OverwriteWhenItemExistsNested (myNestedDictionary)
    ManipulateValueWhenItemExistsNested (myNestedDictionary)

    Exercise_CountAppearances

    Pitfall_1
    Solution_Pitfall_1

    Pitfall_2
    Solution_Pitfall_2

    Pitfall_3
    Solution_Pitfall_3
End Sub


Public Sub CreateAndFillDictionary()

    Dim i
    Dim myIntStringDict As New Dictionary
    Dim myStringIntDict As New Dictionary

    If Not myIntStringDict.Exists(34) Then
        myIntStringDict.add 34, "abc"
    End If

    If Not myIntStringDict.Exists(34) Then
        myIntStringDict.add 34, "abc"
    End If

    For i = 35 To 49
        If Not myIntStringDict.Exists(i) Then
            myIntStringDict.add i, "abc"
        End If
    Next i
    
    If Not myStringIntDict.Exists("34") Then
        myStringIntDict.add "34", 111
    End If

    If Not myStringIntDict.Exists("34") Then
        myStringIntDict.add "34", 111
    End If

    For i = 35 To 49
        If Not myStringIntDict.Exists(CStr(i)) Then
            myStringIntDict.add CStr(i), 111
        End If
    Next i
    
End Sub


Public Function CreateAndFillDictionaryAndReturnIt() As Dictionary

    Dim myIntStringDict As New Dictionary
    Dim i

    If Not myIntStringDict.Exists(34) Then
        myIntStringDict.add 34, "abc"
    End If

    If Not myIntStringDict.Exists(34) Then
        myIntStringDict.add 34, "abc"
    End If

    For i = 35 To 49
        If Not myIntStringDict.Exists(i) Then
            myIntStringDict.add i, "abc"
        End If
    Next i

    Set CreateAndFillDictionaryAndReturnIt = myIntStringDict
    
End Function

Public Sub GetValueOfKey()

    Dim myIntStringDict As New Dictionary
    Dim myString As String

    myIntStringDict.add 34, "abc"

    If myIntStringDict.Exists(34) Then
        myString = myIntStringDict(34)
        Debug.Print myString
    End If
  
End Sub

Public Sub OverwriteWhenItemExists()

    Dim myIntIntDict As New Dictionary
    
    myIntIntDict.add 45, 1

    If myIntIntDict.Exists(45) Then
        myIntIntDict(45) = 2
    Else
        myIntIntDict.add 45, 2
    End If

    Debug.Print myIntIntDict(45)
    
End Sub

Public Sub LoopThroughAllElementsOfList(myIntStringDict As Dictionary)

    Dim item
    Dim pair
    Dim keyArray
    Dim i

    Debug.Print "Approach 1:"

    For Each item In myIntStringDict.Keys
        Debug.Print "Key: " & item & vbTab & "Value: " & myIntStringDict(item)
    Next item

    Debug.Print (vbCrLf & "Approach 2:")
    

    For i = 0 To myIntStringDict.Count - 1
        Debug.Print "Key: " & myIntStringDict.Keys(i) & vbTab & "Value: " & myIntStringDict.Items(i)
    Next i


    Debug.Print (vbCrLf & "Approach 3:")
    
    keyArray = myIntStringDict.Keys
    
    For Each item In keyArray
        Debug.Print "Key: " & item & vbTab & "Value: " & myIntStringDict(item)
    Next item

End Sub


Public Function CreateAndFillNestedDictionary() As Dictionary

'in this form not possible, because it is not possible to create instances of arrays
'in order to make the program work, I use "Collection" instead of instances of arrays

    Dim myNestedDictionary As New Dictionary

    Dim tempColl As Object
    Dim testCounter As Integer
    Dim i
    Dim j
    
    testCounter = 0

    For i = 35 To 49
    
        tempColl = New Collection

        For j = 0 To 9
            testCounter = testCounter + 1
            tempColl.add testCounter
        Next j

        myNestedDictionary.add i, tempColl
    Next i
    

    Set CreateAndFillNestedDictionary = myNestedDictionary
    
End Function

Public Sub LoopThroughAllElementsOfNestedDictionary(myNestedDictionary As Dictionary)

    Dim key
    Dim item

    For Each key In myNestedDictionary.Keys
        For Each item In myNestedDictionary(key)
            Debug.Print item
        Next item
    Next key
    
End Sub

Public Sub OverwriteWhenItemExistsNested(myNestedDictionary As Dictionary)

    Dim tempColl As Object
    
    Dim intList()
    Dim singleInt
    Dim testInt
    
    intList = Array(3, 5, 6, 3, 2, 3)

    If myNestedDictionary.Exists(40) Then
    
        Set tempColl = New Collection
        
        For Each singleInt In intList
            tempColl.add singleInt
        Next singleInt
        
        myNestedDictionary(40) = tempInt
    End If

    For Each testInt In myNestedDictionary(40)
        Debug.Print testInt
    Next testInt
End Sub


Public Sub ManipulateValueWhenItemExistsNested(myNestedDictionary As Dictionary)

    Dim tempColl As Object
    Dim testInt

    If myNestedDictionary.Exists(40) Then
    
        Set tempColl = myNestedDictionary(40)
        tempColl(4) = 555
        myNestedDictionary(40) = tempColl
    End If

    For Each testInt In myNestedDictionary(40)
        Debug.Print testInt
    Next testInt
    
End Sub


Public Sub Exercise_CountAppearances()

    Dim inputNames()
    Dim name
    
    inputNames = Array("Pat", "Ann", "Paul", "Paul", "Joe", "Mike", "Pat", "Paul")
    
    Dim outputDict As New Dictionary

    For Each name In inputNames
        If Not outputDict.Exists(name) Then
            outputDict.add name, 1
        Else
            outputDict(name) = outputDict(name) + 1
        End If
    Next name

    For Each name In outputDict.Keys
        Debug.Print name & vbTab & outputDict(name)
    Next name
End Sub


Public Sub Pitfall_1()

    'Most problems connected to Dictionaries are due to the fact that dictionaries link by reference

    Dim tempInt(0) As Integer
    Dim i
    Dim key

    Dim myDict As New Dictionary

    For i = 0 To 2
    
        tempInt(0) = i
        myDict.add i, tempInt

        For Each key In myDict.Keys
            Debug.Print myDict(key)(0)
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

    Dim myDict As New Dictionary
    Dim tempColl As Object
    
    Dim i
    Dim key

    For i = 0 To 2
    
        Set tempColl = New Collection
        tempColl.add i
        myDict.add i, tempColl

        For Each key In myDict.Keys
            Debug.Print myDict(key)(0)
        Next key
    Next i

    'Expected output:  0, 0 1, 0 1 2
    'Real output:      0, 0 1, 0 1 2

    'Explanation: now there are three addresses (three instances) of "tempColl"
    'so any change in one instance of "tempColl" does not affect the rest of instances
End Sub


Public Sub Pitfall_2()

    Dim myDict As New Dictionary

    myDict.add 0, Array(0)
    myDict.add 1, Array(1)

    Debug.Print myDict(0)(0)
    Debug.Print myDict(1)(0)

    myDict(1) = myDict(0)

    Debug.Print myDict(0)(0)
    Debug.Print myDict(1)(0)

    myDict(0)(0) = 9

    Debug.Print myDict(0)(0)
    Debug.Print myDict(1)(0)

    myDict(1)(0) = 8

    Debug.Print myDict(0)(0)
    Debug.Print myDict(1)(0)

    'Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
    'Real outputs:         0   1   |   0   0   |   9   9   |   8   8

    'When copying one entry to another, suddenly every further change in ANY value affects both entries.
    'Explanation: when copying one entry to another, we ONLY copy the address
    ' -> both entries now point to the same address in memory
    ' -> any change in the address pointed to affects both entries.
End Sub


Public Sub Solution_Pitfall_2()

    Dim myDict As New Dictionary
    Dim tempColl As Object
    
    Set tempColl = New Collection
    tempColl.add 0
    
    myDict.add 0, tempColl
    
    Set tempColl = New Collection
    tempColl.add 1
    myDict.add 1, tempColl

    Debug.Print myDict(0)(0)
    Debug.Print myDict(1)(0)

    myDict(1) = (int())myDict(0).Clone()

    Debug.Print (myDict(0)(0))
    Debug.Print (myDict(1)(0))

    myDict(0)(0) = 9

    Debug.Print (myDict(0)(0))
    Debug.Print (myDict(1)(0))

    myDict(1)(0) = 8

    Debug.Print (myDict(0)(0))
    Debug.Print (myDict(1)(0))

    'Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
    'Real outputs:         0   1   |   0   0   |   9   0   |   9   8

    'Explanation: when cloning an array, a copy of the array under a NEW ADDRESS is created
    ' -> every entries now points to a different address in memory
    ' -> any change in one address does not affect the other address.
End Sub


Public Sub Pitfall_3()

    Dictionary<int, int()> myDict = new Dictionary<int, int()>()

    myDict.add 0, new int() 0)

    Debug.Print (myDict(0)(0))
    
    Pitfall_3_Helper (myDict)

    Debug.Print (myDict(0)(0))

    'Expected outputs:     0   0
    'Real output:          0   9

    'When calling a function with parameter (which is NOT by reference), we expect no change in the original dictionary
    'But the dictionary calls to the address of the int()
    'so no matter where we change the int(), it will always affect the whole dictionary
    '(which is actually a very good behavior, nobodys wants to copy dictionaries)
End Sub


Public Sub Solution_Pitfall_3()

    Dictionary<int, int()> myDict       = new Dictionary<int, int()>()
    Dictionary<int, int()> myDictCopy   = new Dictionary<int, int()>(myDict)

    myDict.add 0, new int() 0)

    Debug.Print (myDict(0)(0))
    
    Pitfall_3_Helper (myDictCopy)

    Debug.Print (myDict(0)(0))

    'Expected outputs:     0   0
    'Real output:          0   0

    'By copying the whole dictionary, a second address is created
    'a change in one address does not affect the second address
End Sub

public sub Pitfall_3_Helper(Dictionary<int, int()> myDict)

    myDict(0) = new int() 9
End Sub

