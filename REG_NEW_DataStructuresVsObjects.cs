/* Questions
	True or false? Robert Martin (Uncle Bob) says:
		a) A data structure is a class that has public variables and no methods
		b) An object is a class that has public methods and maximum 2 public variables
		c) An object is a class that has public methods and no public variables
		d) We have to decide if we want to have a data structure or an object, both are legitimate
		e) We must not mix the characteristics of a data structure and an object.
		f) A class with public methods and public variables is a Hybrid.
		g) Hybrids are good
		h) The use of hybrids is a sign that the programmer is inexperienced
		i) Avoiding hybrids reduces the interdependence of classes and hence increases the maintenability of the code
*/



// My explanations at the bottom

/*
	Quotes:
	Robert C. Martin, Czysty Kod, Podręcznik dobrego programisty, 2009 Pearson Education, 2014 Polish edition by Helion S.A.
	
	Page 115:
	"Obiekty ukrywają dane, tworząc abstrakcje, i udostępniają funkcje operujące na tych danych. Struktury
	danych udostępniają ich dane i nie mają znaczących funkcji."
	
	Page 115/116:
	"Kod proceduralny (kod korzystający ze struktur danych) ułatwia dodawanie nowych funkcji
	bez zmiany istniejących struktur danych. Z kolei kod obiektowy ułatwia dodawanie nowych klas
	bez zmiany istniejących funkcji.

	Prawdziwe jest również stwierdzenie odwrotne:
	Kod proceduralny utrudnia dodawanie nowych struktur danych, ponieważ muszą zostać
	zmienione wszystkie funkcje. Kod obiektowy utrudnia dodawanie nowych funkcji, ponieważ
	muszą zostać zmienione wszystkie klasy."
	
	Page 116:
	"Doświadczeni programiści wiedzą, że twierdzenie, iż wszystko jest obiektem, to mit. Czasami faktycznie
	warto zastosować proste struktury danych z operującymi na nich procedurami."
	
	Page 118:
	"[...] struktur hybrydowych będących w połowie obiektami, a w połowie strukturami danych. Mają one funkcje wykonujące ważne operacje, ale
	mają również zmienne publiczne lub publiczne akcesory i mutatory, które oprócz tego, że realizują
	zamierzone operacje, udostępniają zmienne prywatne, co pozwala zewnętrznym funkcjom na użycie
	tych zmiennych w sposób, w jaki programy proceduralne używają struktur danych
	
	Takie hybrydy utrudniają dodawanie nowych funkcji, jak również utrudniają dodawanie nowych
	struktur danych. Mają najgorsze cechy z obu światów. Należy unikać ich tworzenia. Są one charakterystyczne
	dla tych projektów, w których autorzy nie są pewni — lub co gorsza, nie mają pojęcia
	— czy potrzebują ochrony funkcji, czy typów."
*/

class App
{
	static void Main()
	{
		
	}
}

class Object_OK
{
	private int myInt;
	private string myString;
	
	public void MyMethod()
	{
		MySubMethod();
	}
	
	private void MySubMethod()
	{
		
	}
}

class DataStructure_OK //= Custom Type 
{
	public int myInt;
	public int myInt2;
	public int myInt3;
}

class Hybrid_Not_OK
{		
	public int myInt;
	private int myInt2;
	
	public void MyMethod()
	{
		MySubMethod();
	}
	
	private void MySubMethod()
	{
		
	}
}

class Object_GodObject_Not_OK
{
	private int myInt;
	private string myString;
	
	public void ChangeMyInt1()
	{
		// 20 lines
	}

	public void ChangeMyInt2()
	{
		// 20 lines
	}

	public void ChangeMyInt3()
	{
		// 20 lines
	}	
	
	public void ChangeMyString1()
	{
		// 20 lines
	}

	public void ChangeMyString2()
	{
		// 20 lines
	}

	public void ChangeMyString3()
	{
		// 20 lines
	}
}

class Object_Constructor_OK
{
	private int myInt;
	private string myString;
	
	public Object_Constructor_OK()
	{
		// 20 lines
	}
	
	public void MyMethod()
	{
		MySubMethod();
	}
	
	private void MySubMethod()
	{
		
	}	
}

class DataStructure_Constructor_OK
{	
	public int myInt;
	public int myInt2;
	public int myInt3;
	
	public DataStructure_Constructor_OK()
	{
		
	}
}

class Object_QuasiEncapsulation_Not_OK
{
	private int myInt;
	private string myString;
	
	public int MyInt
	{
		get { return myInt;}
		set { myInt = value;}
	}
	
	public void SetMyString(string myString)
	{
		this.myString = myString;
	}
	
	public string GetMyString()
	{
		return myString;
	}
	
	public void MyMethod()
	{
		MySubMethod();
	}
	
	private void MySubMethod()
	{
		
	}	
}

class Object_Indirect_Manipulation_OK
{
	private string myStatus;
	
	public void ChangeStatus(string factor1, string factor2)
	{
		if (factor1 == "a" && factor2 == "b")
			myStatus = "ok";
	}
	
	public bool Check(string fragment)
	{
		return myStatus.Contains(fragment);
	}
	
	public void MyMethod()
	{
		MySubMethod();
	}
	
	private void MySubMethod()
	{
		
	}	
}

/*
	Object_OK:
		The ideal type in Object Oriented Programming. Only private variables, one (max three) public methods. 
		But attention, keep in mind: Your class should not be longer than 80 lines and should not have more than two public methods. Avoid God Objects
		
	DataStructure_OK:
		No methods at all, public variables. It is good practice to use data structures.
		Two typical use cases:
		1) you want to return more than one information from a method.
		2) You have a two-dimensional data structure. One dimension is fixed and has different types, and the second dimension is variable. Here it is ideal to use: List<MyDataStructure>
		
	Hybrid_Not_OK:
		avoid classes that have public variables and public methods. It increases the complexity of your code. You have to decide: either object or data structure, no hybrids.
		
	Object_GodObject_Not_OK:
		God objects can be a result of frantically avoiding data structures. Because then any code that manipulates the data, has to be moved into the object. When your object gets bigger than 80 lines and has more than two public methods, you should reconsider your approach. Either make use of data structure, or split your object into several smaller objects. 
		
	Object_Constructor_OK:
		A constructor is not a method, because it is executed only once (there is no possiblity to execute a constructor a second time). So your object can have one (max three) public methods, plus one additional constructor.
		
	DataStructure_Constructor_OK:
		as a constructor is not a method, a data structure can of course have a constructor
		
	Object_QuasiEncapsulation_Not_OK:
		this is cheating ;-) you pretend that the outer world has no direct access to the private variable, but de facto is has. 
		
		The outer world can have only INDIRECT influence to your private variable. 
		PS: C# has the key word "get" and "set". Java doesn't. So "MyInt" is the C# approach, and SetMyString() and GetMyString() would be the Java approach.
		
		the C# approach with "get" and "set" is misused very often. A good "get", "set" needs a complex structure checking many conditions. If you do that, than it has the advantange, that you keep the number of public entry points low.
		the Java approach has rather many methods with less conditioning, keep the methods simple, but on the other hand creating to many public entry points.
		Choose wisely case by case.
		
		But what is undoubtely always wrong is a getter and setter without conditioning. Avoid direct manipulation of private variable from outside.
		
	Object_Indirect_Manipulation_OK: (but with the risk of creating to many public methods)
		this is ok, because here the influence on the private variable is indirect. We see in the getter method, that bool is returned and not string. In the setter method, several conditions are checked, before the variable is changed, and the actual value that is assigned ("ok" is this case), does not come from the outer world.
		
*/
