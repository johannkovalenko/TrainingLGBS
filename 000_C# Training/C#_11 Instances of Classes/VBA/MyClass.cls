VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "MyClass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Private pMyNonStaticVariable As Integer
Private pMyNonStaticVariable2 As Integer


' there are no static class variables in VBA, so "myStaticVariable" is off

Public Property Get myNonStaticVariable() As Integer
    myNonStaticVariable = pMyNonStaticVariable
End Property
    
Public Property Let myNonStaticVariable(Value As Integer)
    pMyNonStaticVariable = Value
End Property

Public Property Get myNonStaticVariable2() As Integer
    myNonStaticVariable2 = pMyNonStaticVariable2
End Property

Public Property Let myNonStaticVariable2(Value As Integer)
    pMyNonStaticVariable2 = Value
End Property

