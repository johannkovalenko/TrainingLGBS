Option Strict

Public Module MainModule
    Public Sub Main()
        PowerOfNumber
        RootOfNumber
        ModuloOfDivision
        ModuloPerformJumpsOfSeven
        GetDecimalPartOfNumber
        RoundingNumbers
        AlwaysRoundDown
        AlwaysRoundUp
        RoundToFirstDecimalPart
        UsingSinusAndCosinus
        Pythagoras
        AbsoluteValue

        Console.ReadLine()
    End Sub

    Public Sub PowerOfNumber()
        Dim myInt As Integer = 5
        Dim myPowerOfTwo As Integer
        Dim myPowerOfThree As Integer

        myPowerOfTwo = CInt(myInt ^ 2)
        
        Console.WriteLine(myPowerOfTwo)

        myPowerOfThree = CInt(myInt ^ 3)
        
        Console.WriteLine(myPowerOfThree)
    End Sub

    Public Sub RootOfNumber()
        Dim myInt As Integer
        Dim mySquareRoot As Double
        Dim myCubicRoot As Double
        
        myInt = 81
        mySquareRoot = Math.Sqrt(myInt)
        
        Console.WriteLine(mySquareRoot)

        myInt = 125
        myCubicRoot = myInt ^ (1 / 3)
        
        Console.WriteLine(myCubicRoot)
    End Sub

    Public Sub ModuloOfDivision()
        Dim modulo As Integer

        modulo = 83 Mod 9
        
        Console.WriteLine(modulo)
    End Sub

    Public Sub ModuloPerformJumpsOfSeven()
        Dim modulo As Integer = 0
        Dim i As Integer

        For i = 0 To 49
            modulo = i Mod 7

            If modulo = 0 Then
                Console.WriteLine(i)
            Else
                Console.WriteLine("x")
            End If
        Next i
    End Sub

    Public Sub GetDecimalPartOfNumber()
        Dim myDouble As Double
        Dim integerOfDouble As Integer
        Dim myDecimalPart As Double

        myDouble = 7.39596
        integerOfDouble = CInt(Fix(myDouble))

        myDecimalPart = myDouble - integerOfDouble

        Console.WriteLine(integerOfDouble)
        Console.WriteLine(myDecimalPart)
    End Sub

    Public Sub RoundingNumbers()
        Dim myDouble As Double
        Dim roundedDouble As Integer
        
        'Attention CINt in VB.net is not the same as (int) in C#.
        'CInt always rounds up or down automatically

        myDouble = 7.49
        roundedDouble = CInt(myDouble)
        'roundedDouble = CInt(Fix(myDouble + 0.5)) ' also possible

        Console.WriteLine(roundedDouble)

        myDouble = 7.5
        roundedDouble = CInt(myDouble)

        Console.WriteLine(roundedDouble)
    End Sub

    Public Sub AlwaysRoundDown()
        Dim myDouble As Double
        Dim roundedDouble As Integer
        
        myDouble = 7.49
        roundedDouble = CInt(Fix(myDouble))

        Console.WriteLine(roundedDouble)

        myDouble = 7.5
        roundedDouble = CInt(Fix(myDouble))

        Console.WriteLine(roundedDouble)  
    End Sub

    Public Sub AlwaysRoundUp()
        Dim myDouble As Double
        Dim roundedDouble As Integer
        
        myDouble = 7.49
        roundedDouble = CInt(Fix(myDouble + 1))

        Console.WriteLine(roundedDouble)

        myDouble = 7.5
        roundedDouble = CInt(Fix(myDouble + 1))

        Console.WriteLine(roundedDouble)
    End Sub

    Public Sub RoundToFirstDecimalPart()
        Dim myDouble As Double
        Dim roundedDouble As Double
        Dim temp As Double
        
        myDouble = 7.349
        temp = myDouble * 10
        roundedDouble = CInt(temp) / 10
        
        Console.WriteLine(roundedDouble)

        myDouble = 7.35
        temp = myDouble * 10
        roundedDouble = CInt(temp) / 10
        
        Console.WriteLine(roundedDouble)
    End Sub

    Public Sub UsingSinusAndCosinus()
        ' When walking 1 unit from the center with a 45 degree angle,
        ' your karthesian coordinates will be 0.71/0.71 and not 1/1!!
        
        Dim xCoor As Double
        Dim yCoor As Double
            
        xCoor = Math.Sin(Math.PI * 45 / 180)
        yCoor = Math.Cos(Math.PI * 45 / 180)

        Console.WriteLine(xCoor & Chr(9) & yCoor)

        xCoor = Math.Sin(Math.PI * 90 / 180)
        yCoor = Math.Cos(Math.PI * 90 / 180)

        Console.WriteLine(xCoor & Chr(9) & yCoor)
    End Sub

    Public Sub Pythagoras()
        ' The distance from the point 0/0 to the point 2/2 is not 2, it is 2.83
        Dim xCoor As Integer
        Dim yCoor As Integer
        Dim distance As Double
        
        xCoor = 2
        yCoor = 2

        distance = Math.Sqrt(xCoor ^ 2 + yCoor ^ 2)
        
        Console.WriteLine(distance)
    End Sub

    Public Sub AbsoluteValue()
        Dim myDouble As Double
        Dim myAbsoluteDouble As Double
        
        myDouble = -45.45
        myAbsoluteDouble = Math.Abs(myDouble)

        Console.WriteLine(myAbsoluteDouble)
    End Sub
End Module
