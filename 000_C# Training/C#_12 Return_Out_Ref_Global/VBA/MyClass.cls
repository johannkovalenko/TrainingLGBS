VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "MyClass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False


Private pMyString As String
Private pMyInt As Integer

Public Property Get myString() As String
    myString = pMyString
End Property

Public Property Let myString(Value As String)
    pMyString = Value
End Property

Public Property Get myInt() As Integer
    myInt = pMyInt
End Property

Public Property Let myInt(Value As Integer)
    pMyInt = Value
End Property
