// C:\Windows\Microsoft.NET\Framework64\v4.0.30319

using System;

static class MainClass
{
    public static void Main()
    {
        int[] wynagrodzenieJohann = new int[10]; // dziesięć elementów
        int[] wynagrodzenieMagda = new int[10];


        // wynagrodzenieJohann :        adres 100 + 10 * 64
        // wynagrodzenieMagda:          adres 740 + 10 * 64

        // C++: wynagrodzenieJohann[10] = 25: 100 + 10 * 64 = adres 740 = 25

        //Coś bardzo głupiego:
        wynagrodzenieJohann[10] = 25; // jedennasty element, bo zaczynamy o 0 -> CLR nam wyrzuci błąd


        // x x x x x    x x x x x  
        // 0 1 2 3 4    5 6 7 8 9


        Console.WriteLine("Hello World");
    }

    private static string SubProcess1()
    {
        return "ABC";
    }
}

class Employee
{   
    public string name = "";
    public int age = 0;
    public bool married = false;
    public double salary = 0.00;
}



// C# jest case-sensitive (czuły na wielkość liter)
// word-wrap (zawijanie linijek)
// Sub vs. Function (Sub nie zwraca wartości, Function zwraca wartość)

// Sub Main() -> void Main()
// Function SubProcess1() as String

// Module -> statyczny (istnieje tylko RAZ od momentu uruchomienia) -> static class (+ metody + zmienne)
// Klasa -> niestatyczna (wymaga instancji żeby zaistnieć, ale możemy tworzyć n instancji) -> class/metoda/zmienna (brak słowa "static")

// SubProcess1 = "ABC" -> return "ABC"


// debug.print -> Console.WriteLine()

// compiled vs. interpreted language:
// Kompilator tłumaczy kod i tworzy plik exe. exe się składa już z zer i jedynek. .... Użytkownik uruchamia zera i jedynki. (1 raz tłumaczenia)
// Zaleta kompilacji: bezpieczeństwo, łatwiej do przeniesienia, szybciej, usuwa więcej błędów na wcześniejszym etapie
// Wada: proces wytwarzania trochę dłuższy
// C++, C.
// C#, Java -> Just in time compilation. 


// Interpretor tłumaczy kod na żywo. nie twórzy pliku, od razu wysyła świeżo tłumaczoną linijkę do procesora. (n razy tłumaczenia) 
// VBA jest językiem interpretowanym
// Zaleta: Debugowanie (zatrzymywanie kodu w dowolnym miejscu)


// 1. Pokolenia: machine kod: programiści pisali instrukcje dla procesora ręcznie: 0,1
// 2. Pokolenie: assembler: programiści pisali instrukcj dla procesora: ale juz nie 0,1, mieli już gotowe instrukcja: (ADD 1, miejsce)
// 3. Pokolenie: 
    //C (ładna składnia pętla, funkcje, if) (Java, C#, C++ mają składnie od C)
    //C++ (roszszerzenie C). Object Oriented C (Polimorfizm, Dziedziczenie) -> prawdziwe skompilowane języki.
        // kompilator tworzył program dla danego komputera (procesora)
    // Java: JIT compilation, dodatkowe uproszczenie -> działa na wszystkich komputerach (java.exe)
    // C#: składniowo i funkcjonalnie to kopia Javy. Też JIT compilation. Wymaga CLR (Common Language Runtime) żeby działać. (Microsoft wcześniej miał tylko język BASIC. Visual Basic for Application, VB6 -> VB.net)

// C++: zaleta: szybki, samowystarczalny (wszystkie systemy operacyjne i sterowniki są pisane w C++, większość jezyków programistycznych)
// wada: program, mimo że samowystarczalny działa tylko na konkretnym procesorze






