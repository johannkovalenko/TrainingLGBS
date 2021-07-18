/* Accessors
	True or false? Robert Martin (Uncle Bob) says:
		a) We love Accessors
		b) We want to achieve Quasi Encapsulation
		c) When using an object, we want to make the variables inaccessible from outside. An accessor is a potential breach to this rule.
		d) An accessor that blindly (without checking or further logic) exposes private variables causes quasi encapsulation. We want to avoid quasi encapsulation by all means
		e) An accessor should have as little logic as possible and should expose the orginal value of the private variable
		
	True or false? Johann says:
		a) Accessors are an important tool of a programmer
		b) Accessors should be used as little as possible
	
*/


/*
	Quotes:
	Robert C. Martin, Czysty Kod, Podręcznik dobrego programisty, 2009 Pearson Education, 2014 Polish edition by Helion S.A.
	
	Page 113:
	"ISTNIEJE POWÓD, DLA KTÓREGO korzystamy ze zmiennych prywatnych. Nie chcemy, aby ktokolwiek
	na nich polegał. Chcemy zachować sobie swobodę zmian ich typu lub implementacji. Dlaczego
	więc tak wielu programistów automatycznie dodaje gettery i settery do swoich obiektów, udostępniając
	zmienne prywatne tak, jakby były one publiczne?"
	
	Page 114:
	"Ukrywanie implementacji nie sprowadza się do dodawania warstwy funkcji nad zmiennymi.
	Ukrywanie implementacji polega na tworzeniu abstrakcji! Klasa nie powinna po prostu przepychać
	zmiennych przez gettery i settery. Zamiast tego powinna udostępniać interfejs pozwalający użytkownikom
	na manipulowanie istotą danych bez konieczności znajomości jej implementacji."
*/
	

/* 
	Keywords: 
		object ok, data structure ok, hybrid not ok
		"Tell, don't ask" principle => no micromanagement
*/

class MainClass
{
	/* 
		An object should not expose any data (= no public variables).
		Getters and setters de facto expose private data. 
		Fun fact: Java does not have get/set, it uses getter and setters method, but they also expose private data)
		Solution: move the "if"-part within the class. 
		If this approach results in a too big class, use a data structure (=public variables, no methods)
		conclusion: getters and setters de facto create Hybrids which Uncle Bob disapproves (either object or data structure, not both)
	*/
	
	static void Main()
	{
		Savings savings = new Savings();
		
		savings.Add(40);
		
		if (savings.Cumulated > 30)
		{
			// ...
		}
		
		if (savings.Getter() > 30)
		{
			// ...
		}
	}
}

class Savings
{
	private int cumulated;
	
	public int Cumulated
	{
		get {return cumulated;}
		set {cumulated = value;}
	}
	
	public void Add(int amount)
	{
		cumulated += amount;
	}
	
	public int Getter()
	{
		return cumulated;
	}
}

/*
	Improved code Version 1:
	
	When you don't need the if-body in the higher abstraction layer (in this case the main function)
*/

class MainClass
{	
	static void Main()
	{
		Savings savings = new Savings();
		
		savings.Add(40);
	}
}

class Savings
{
	private int cumulated;
	
	public void Add(int amount)
	{
		cumulated += amount;
		
		if (cumulated > 30)
		{
			// ...
		}
	}
}

/*
	Improved code Version 2:
	
	When you need the if-body in the higher abstraction layer, try not to expose the real data
*/

class MainClass
{	
	static void Main()
	{
		Savings savings = new Savings();
		
		if (savings.Add(40))
		{
			// ..
		}
	}
}

class Savings
{
	private int cumulated;
	
	public bool Add(int amount)
	{
		cumulated += amount;
		
		if (cumulated > 30)
		{
			// ...
			return true;
		}
		else return false;
	}
}