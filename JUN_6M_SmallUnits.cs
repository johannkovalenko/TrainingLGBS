/* Questions
	1) True or false?
		a) Many units (classes and methods) are better than few units
		b) Many units together with private methods and/or variables decrease encapsulation
		c) Many units without private methods/variables is only the half way to a high level of encapsulation
		d) Small/many units are not needed to achieve encapsulation
		e) Small units is the mother of all rules regarding clean code.
		f) Unit testing and Small units are unrelated topics
		g) Units should have only one task. This is called the Single Responsibility Principle.
		h) Sometimes it is just not possible to keep a unit short
	
	2) Johann says:
		a) classes should not have more than 80 lines
		b) methods should not have more than 20 lines
		c) the method main can have more than 20 lines
		d) every method can be reduced to 20 lines or below
		e) a line should not have more than 100 signs (including tabulator. every tabulator = 4 signs)
		f) "_" in VBA is ugly
		
	3) True or false? When our method has too many lines then its a good strategy to:
		a) remove blank lines so that the methods look more compact
		b) make one-line "if" blocks
		c) define more than one variable in one line
		d) move parts of the method to another method
		e) have more than one instruction per line (which is possible in C#)
		f) do string concatenations in one line (producing extra long lines)
		
	4) True or false? Signs that the Single Responsibility Principle is breached:
		a) we declare more than five variables inside the method
		b) the same variable is filled in the upper part of the method, then reset, and in the lower filled again with other values
		c) the method name contains more than one verb
		d) the method has more than two layers of nesting (= intents = wcięcia)
		e) the method contains sections (very often the programmer marks them with a comment, or two or more blank lines)
		f) the method receives more than two parameters of different types
		g) there is the need to reset variables (x = "")
		h) there is the need to code variables (i.E. "strMyVar" instead of simple "myVar")
*/



//Indicate the bad practice and deliver a better approach

class MainClass
{
	static void Main
	{
		Step1(); //Connect
		Step2(); //Process
	}
	
	static void Step1
	{
		//Here we connect to the database
		
		// do ..
	}
	
	static void Step2
	{
		//Here we process data
		
		// do something
	}
}