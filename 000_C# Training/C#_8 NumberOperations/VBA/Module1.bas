Attribute VB_Name = "Module1"
Option Explicit

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

End Sub

Public Sub PowerOfNumber()

    Dim myInt As Integer
    Dim myPowerOfTwo As Integer
    Dim myPowerOfThree As Integer

    myInt = 5
    myPowerOfTwo = myInt ^ 2
    
    Debug.Print myPowerOfTwo

    myPowerOfThree = myInt ^ 3
    
    Debug.Print myPowerOfThree
    
End Sub

Public Sub RootOfNumber()
    
    Dim myInt As Integer
    Dim mySquareRoot As Double
    Dim myCubicRoot As Double
    
    myInt = 81
    mySquareRoot = Sqr(myInt)
    
    Debug.Print mySquareRoot

    myInt = 125
    myCubicRoot = myInt ^ (1 / 3)
    
    Debug.Print myCubicRoot
End Sub

Public Sub ModuloOfDivision()
    
    Dim modulo As Integer

    modulo = 83 Mod 9
    
    Debug.Print modulo
    
End Sub

Public Sub ModuloPerformJumpsOfSeven()

    Dim modulo As Integer
    Dim i

    modulo = 0

    For i = 0 To 49
        modulo = i Mod 7

        If modulo = 0 Then
            Debug.Print (i)
        Else
            Debug.Print "x"
        End If
    Next i
    
End Sub


Public Sub GetDecimalPartOfNumber()
    
    Dim myDouble As Double
    Dim integerOfDouble As Integer
    Dim myDecimalPart As Double

    myDouble = 7.39596
    integerOfDouble = Int(myDouble)

    myDecimalPart = myDouble - integerOfDouble

    Debug.Print integerOfDouble
    Debug.Print myDecimalPart
    
End Sub

Public Sub RoundingNumbers()

    Dim myDouble As Double
    Dim roundedDouble As Integer
    
    myDouble = 7.49
    roundedDouble = Int(myDouble + 0.5)

    Debug.Print roundedDouble

    myDouble = 7.5
    roundedDouble = Int(myDouble + 0.5)

    Debug.Print roundedDouble
End Sub

Public Sub AlwaysRoundDown()

    Dim myDouble As Double
    Dim roundedDouble As Integer
    
    myDouble = 7.49
    roundedDouble = Int(myDouble)

    Debug.Print roundedDouble

    myDouble = 7.5
    roundedDouble = Int(myDouble)

    Debug.Print roundedDouble
    
End Sub

Public Sub AlwaysRoundUp()

    Dim myDouble As Double
    Dim roundedDouble As Integer
    
    myDouble = 7.49
    roundedDouble = Int(myDouble + 1)

    Debug.Print roundedDouble

    myDouble = 7.5
    roundedDouble = Int(myDouble + 1)

    Debug.Print roundedDouble
    
End Sub

Public Sub RoundToFirstDecimalPart()

    Dim myDouble As Double
    Dim roundedDouble As Double
    Dim temp As Double
    
    myDouble = 7.349
    temp = myDouble * 10 + 0.5
    roundedDouble = Int(temp) / 10
    
    Debug.Print roundedDouble

    myDouble = 7.35
    temp = myDouble * 10 + 0.5
    roundedDouble = Int(temp) / 10
    
    Debug.Print roundedDouble
    
End Sub

Public Sub UsingSinusAndCosinus()

    ' When walking 1 unit from the center with a 45 degree angle,
    ' your karthesian coordinates will be 0.71/0.71 and not 1/1!!
    
    Dim PI As Double
    Dim xCoor As Double
    Dim yCoor As Double
        
    PI = 4 * Atn(1) 'I did not find any prefined PI function

    xCoor = Sin(PI * 45 / 180)
    yCoor = Cos(PI * 45 / 180)

    Debug.Print (xCoor & Chr(9) & yCoor)

    xCoor = Sin(PI * 90 / 180)
    yCoor = Cos(PI * 90 / 180)

    Debug.Print (xCoor & Chr(9) & yCoor)
    
End Sub

Public Sub Pythagoras()

    ' The distance from the point 0/0 to the point 2/2 is not 2, it is 2.83
    Dim xCoor As Integer
    Dim yCoor As Integer
    Dim distance As Double
    
    xCoor = 2
    yCoor = 2

    distance = Sqr(xCoor ^ 2 + yCoor ^ 2)
    
    Debug.Print distance
    
End Sub


Public Sub AbsoluteValue()

    Dim myDouble As Double
    Dim myAbsoluteDouble As Double
    
    myDouble = -45.45
    myAbsoluteDouble = Abs(myDouble)

    Debug.Print myAbsoluteDouble
    
End Sub


