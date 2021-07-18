Option Strict

Imports System.Text

Public Module MainModule
    Public Sub Main()
        IntDouble
        ByteToChar
        'IntByte
        IntToString
        StringToInt
        StringToByteArray
        ByteArrayToString
        StringToDate
        DateToString

        Console.ReadLine()
    End Sub

    Public Sub IntDouble()
        Dim myInt As Integer = 32
        Dim myDouble As Double = CDbl(myInt)

        Console.WriteLine(myDouble)

        myInt = CInt(myDouble)

        Console.WriteLine(myInt)
    End Sub

    Public Sub ByteToChar()
        Dim myDecimal As Byte = 65
        Dim myChar As String = Chr(65)
        
        Console.WriteLine(myChar)
    End Sub

    Public Sub IntByte()
        Dim myInt As Integer = 257
        Dim myByte As Byte = CByte(myInt) 'this will produce an error, because Byte contains only 256 signs

        Console.WriteLine(myByte)
    End Sub

    Public Sub IntToString()
        Dim myInt As Integer = 257
        Dim myString As String = CStr(myInt)

        Console.WriteLine(myString)
    End Sub

    Public Sub StringToInt()
        Dim myString As String = "2i57"
        Dim myInt As Integer

        If IsNumeric(myString) Then
            myInt = CInt(myString)
            Console.WriteLine(myInt)
        Else
            Console.WriteLine("NOT A NUMBER")
        End If
    End Sub

    Public Sub StringToByteArray()
        Dim myString As String = "2i57"
        Dim myByte As Byte
        
        Dim myByteArray() As Byte = Encoding.ASCII.GetBytes(myString)
        
        For Each myByte In myByteArray
            Console.WriteLine(myByte & "    " & Chr(myByte))
        Next myByte
    End Sub

    Public Sub ByteArrayToString()
        Dim myByteArray() As Byte = {222, 0, 22, 0, 167, 0, 34, 0}
        Dim myString As String = Encoding.ASCII.GetString(myByteArray)

        Console.WriteLine(myString)
    End Sub

    Public Sub StringToDate()
        Dim myDateString As String = "22.03.1986 10:32"
        Dim myDate As Date
        Dim sukces As Boolean = DateTime.TryParseExact(myDateString, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, myDate)

        Console.WriteLine(myDate & Chr(9) & sukces)
    End Sub

    Public Sub DateToString()
        Dim myDate As Date = Now()
        Dim myString As String = myDate.ToString("dd.MM.yyyy HH:mm:ss")
        'myString = Format(myDate, "dd.MM.yyyy HH:mm:ss") 'also possible
        Console.WriteLine(myString)
    End Sub
End Module
