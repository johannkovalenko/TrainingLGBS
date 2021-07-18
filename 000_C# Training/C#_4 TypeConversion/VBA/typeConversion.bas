Attribute VB_Name = "Module1"
Public Sub Main()
    IntDouble
    ByteToChar
    IntByte
    IntToString
    StringToInt
    StringToByteArray
    ByteArrayToString
    StringToDate
    DateToString
End Sub

Public Sub IntDouble()
    Dim myInt As Integer
    Dim myDouble As Double
    
    myInt = 32
    myDouble = CDbl(myInt)

    MsgBox myDouble

    myInt = CInt(myDouble)

    MsgBox myInt
End Sub

Public Sub ByteToChar()
    Dim myDecimal As Byte
    Dim myChar As String
    
    myDecimal = 65
    myChar = Chr(65)
    
    MsgBox myChar
End Sub
Public Sub IntByte()
    Dim myInt As Integer
    Dim myByte As Byte
    
    myInt = 257
    myByte = CByte(myInt) 'this will produce an error, because Byte contains only 256 signs

    MsgBox myByte
End Sub


Public Sub IntToString()
    Dim myInt As Integer
    Dim myString As String
    
    myInt = 257
    myString = CStr(myInt)

    MsgBox myString
End Sub


Public Sub StringToInt()
    Dim myString As String
    Dim myInt As Integer
    
    myString = "2i57"

    If IsNumeric(myString) Then
        myInt = CInt(myString)
        MsgBox myInt
    Else
        MsgBox "NOT A NUMBER"
    End If
End Sub

Public Sub StringToByteArray()
    Dim myString As String
    Dim myByteArray() As Byte
    Dim myByte
    
    myString = "2i57"
    myByteArray = StrConv(myString, vbFromUnicode)
    
    For Each myByte In myByteArray
        MsgBox myByte & "    " & Chr(myByte)
    Next myByte
End Sub

Public Sub ByteArrayToString()
    Dim myByteArray(7) As Byte
    Dim myString As String
    
    myByteArray(0) = 222
    myByteArray(1) = 0
    myByteArray(2) = 22
    myByteArray(3) = 0
    myByteArray(4) = 167
    myByteArray(5) = 0
    myByteArray(6) = 34
    myByteArray(7) = 0
    

    myString = StrConv(myByteArray, vbUnicode)

    MsgBox myString
End Sub

Public Sub StringToDate()
    Dim myDateString As String
    Dim myDate As Date
    Dim sukces As Boolean
    
    myDateString = "22.03.1986 10:32"
    
    Dim f As Integer
    f = Application.International(xlDateOrder)
    
    myDate = CDate(format(myDateString, "00.00.00 00:00"))
    'if isdate(myDateString)
    
    'bool sukces = DateTime.TryParseExact(myDateString, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out myDate);

    MsgBox myDate & Chr(9) & sukces
End Sub

Public Sub DateToString()
    Dim myDate As Date
    Dim myString As String
    
    myDate = Now()
    myString = Format(myDate, "dd.MM.yyyy HH:mm:ss")
    MsgBox (myString)
End Sub

