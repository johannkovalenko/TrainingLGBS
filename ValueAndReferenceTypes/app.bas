Attribute VB_Name = "Module1"
Public Sub Main()
    Dim myInt As Integer
    Dim myArr As Variant
    
    myInt = 50
    myArr = Array(100, 150, 200)
    
    Change myInt, myArr
    
    Debug.Print myInt
    Debug.Print myArr(0)
End Sub

Private Sub Change(myInt As Integer, myArr As Variant)
    myInt = 60
    myArr(0) = 60
End Sub
