

/*
	Questions
	1) Which loop would you use (for, foreach, while)?
	
		a) loop through all elements in a collection
		b) loop through every second element in a collection
		c) loop through all elements backwards in a collection
		d) loop through all elements in a collection, the iterator (i) information is needed.
		e) the exit condition is not related to the iterator
		f) the iterator is likely to be incremented and/or decremented in a manner not known at design time

	2) Which statements regarding "continue" and "break" are true?
		a) "continue" is a proper technique in order to keep as many code as possible outside the "if"-block
		b) "continue" at the end of the loop block is senseless
		c) "break" in the "switch"-block exits the method, "return" exits only the switch-block.
		d) "break" is indispensible, when having a infinite loop "while (true)"
		e) "exit for" is the VBA equivalent of "break"
		f) "exit sub" is the VBA equivalent of "break"
		g) VBA does not have an equivalent for "continue"
	
	
	3) Sort below approaches to exit a nested loop from the best to the worst.
		a) "break 2"
		b) manipulate the iterators
		c) set a flag when exiting the inner loop
		d) have the inner loop in a separate function that returns true or false 
		e) use "goto"
*/


// Exercise 1:

	//Number of loops.
	//If more than one loop: Nested or consecutive?

	// 1) find maximum value of int array.
	// 2) sort int array
	// 3) find average of numbers in int array
	// 4) read out worksheet range A1:C10  a:1:3;b:3:5;c:4:5
	// 5) find the most frequently appearing number in an int array
	// 6) find the number of appearances of all numbers in an int array
	// 7) find maximum values of two different int arrays
	// 8) find the number of appearances of all numbers in an int array and print them



// Exercise 2:

	// Write an algorithm that calculates and prints all prime numbers from 2 to 100

	// Expected Result:
		// 2 3 5 7 11 13 17 19 23 ...


// Exercise 3:

	// You are given a FIXED array (always 5 elements)
	// display all possible sums of the array elements:

	// int[] arr = {10, 20, 30, 40, 50};

	// Expected Result: 32 combinations 2^5
		// 10 + 20 + 30 + 40 + 50 = 150
		// 20 + 30 + 40 + 50 = 140
		// 10 + 30 + 40 + 50 = 130
		// ... plus 29 more combinations


/// Please decide, if below loops are used properly
/// If proper use: additionally consider how you would write the same code in UIPath and VBA (if they support the given functionality)
/// scroll down to the end of the document to see the answers

class App
{
	static void Main()
	{
	}
	
	void Loop1
	{
		int[] arr = {3, 4, 5, 6};
		
		int sum = 0;
		
		for (int i=0; i<3; i++)
			sum += arr[i];
		
		Console.WriteLine(sum);
	}
	
	void Loop2
	{
		int[] arr = {3, 4, 5, 6};
		
		int sum = 0;
		
		for (int i=0; i<arr.Length; i++)
			sum += arr[i];
		
		Console.WriteLine(sum);
	}
	
	void Loop3
	{
		//hint: i+=2 is ok
		
		int[] arr = {3, 4, 5, 6, 7, 8};
		
		int sum = 0;
		
		for (int i=0; i<arr.Length; i+=2)
			sum += arr[i];
		
		Console.WriteLine(sum);
	}
	
	void Loop4
	{
		int[] arr = {3, 4, 5, 6, 7, 8};
		
		int sum = 0;
		
		for (int i=arr.Length-1; i>=0; i--)
			sum += arr[i];
		
		Console.WriteLine(sum);
	}
	
	void Loop4a
	{
		int[] arr = {3, 4, 5, 6, 7, 8};
		
		int sum = 0;
		
		for (int i=arr.Length-1; i>=0; i--)
		{
			sum += arr[i];
			
			if (sum > 10)
			{
				Console.WriteLine(sum);
				break;
			}
		}
	}

	void Loop5
	{
		int[] arr = {3, 4, 5, 6, 7, 8};
		
		for (int i=0; i<arr.Length; i++)
			if (arr[i] > 4)
				Console.WriteLine(i + " " + arr[i]);
	}

	void Loop6
	{
		int[] arr = {3, 4, 5, 6, 7, 8};
		
		int counter = 0;
		foreach (int num in arr)
		{
			counter++;
			
			if (num > 4)
				Console.WriteLine(counter + " " + num);
		}
	}
	
	void Loop7
	{
		int[] arr = {3, 4, 5, 6};
		
		int sum = 0;
		
		foreach (int num in arr)
			sum += arr;
		
		Console.WriteLine(sum);
	}
	
	void Loop8
	{
		int[] arr = {3, 4, 5, 6};
		int i = 0;
		int sum = 0;
		
		while (i < arr.Length)
		{
			i++;
			sum += arr[i];
		}
		
		Console.WriteLine(sum);
	}
	
	void Loop9
	{
		string answer = "";
		int sum = 0;
		
		while (answer != "exit")
		{
			answer = Console.ReadLine();
			
			if (answer != "exit")
				sum += int.Parse(answer);
		}
		
		Console.WriteLine(sum);
	}
	
	void Loop10
	{
		string answer = "";
		int sum = 0;
		
		while (true)
		{
			answer = Console.ReadLine();
			
			if (answer == "exit")
				break;
			
			sum += int.Parse(answer);
		}
		
		Console.WriteLine(sum);
	}
	
	void Loop11
	{
		boolean goOn = false;
		
		while (goOn)
		{
			goOn = DecideIfToGoOn();
		
			// do something
		}
	}

	void Loop12
	{
		boolean goOn = false;
		
		do
		{
			goOn = DecideIfToGoOn();
		
			// do something
		}
		while (goOn);
	}
	
	void Loop13
	{
		int sum = 0;
		
		for (int i=0; i<100; i++)
		{			
			sum += int.Parse(Console.ReadLine());
			
			if (sum > 400)
				break;
		}
		
		Console.WriteLine(sum);
	}
	
	void Loop14
	{
		int[] arr = {3, 4, 5, 6};
		
		int sum = 0;
		
		foreach (int num in arr)
			if (num > 5)
				sum += num;
			else continue;
		
		Console.WriteLine(sum);
	}
	
	void Loop15
	{
		int[] arr = {3, 4, 5, 6};
		
		foreach (int num in arr)
			if (num > 5)
			{
				// two lines;
			}
			else
			{
				// 10 lines;
			}
	}

	void Loop16
	{
		int[] arr = {3, 4, 5, 6};
		
		foreach (int num in arr)
		{
			if (num > 5)
			{
				// two lines;
				continue;
			}

			// 10 lines;
		}
	}
	
	void Loop17
	{
		int[] arr = {3, 4, 5, 6};
		
		foreach (int num in arr)
			if (num > 5)
			{
				// 10 lines;
			}
			else
			{
				// two lines;
			}
	}
	
	void Loop18
	{
		// exit nested loop
		
		for (int i=0; i<10; i++)
			for (int j=0; j<10; j++)
				if (i * j > 50)
					break 2;
		
		// 10 lines;
	} 
	
	void Loop19
	{
		// exit nested loop
		
		for (int i=0; i<10; i++)
			for (int j=0; j<10; j++)
				if (i * j > 50)
				{
					i = 10;
					break;					
				}

		
		// 10 lines;
	} 
	
	void Loop19a // Thank you Lukasz for the input
    {
        // exit nested loop
        bool exit = false;
        
        for (int i=0; i<10; i++)
        {
            for (int j=0; j<10; j++)
                if (i * j > 50)
                {
                    exit = true;
                    break;
                }
				
            if (exit)
                break;
        }
        
        // 10 lines;
    } 


	void Loop20
	{
		// exit nested loop
		
		for (int i=0; i<10; i++)
			for (int j=0; j<10; j++)
				if (i * j > 50)
					goto exitLabel;
		
		exitLabel:
		// 10 lines;
	} 
	
	void Loop21
	{
		// exit nested loop
		
		Loop21a();
		
		// 10 lines;
	} 
	
	void Loop21a
	{
		for (int i=0; i<10; i++)
			for (int j=0; j<10; j++)
				if (i * j > 50)
					return;		
	}
	
	void Loop22()
	{
		int sum = 0;
		while (true)
		{
			sum += int.Parse(Console.ReadLine());
			Console.WriteLine(sum);
		}
	}

	void Loop23()
	{
		int sum = 0;
		while (true)
		{
			sum += 5;
			Console.WriteLine(sum);
		}
	}
	
	void Loop24()
	{
		int sum = 0;
		
		for (int i=0; i<50; i++)
		{
			sum += i;
			
			if (sum > 10)
			{
				sum -= 5;
				i -= 1;
			}
		}
	}
	
	void Loop25()
	{
		int sum = 0;
		
		while (sum < 20)
		{
			sum++;
			
			if (sum > 10)
				sum -= 5;
		}
	}
	
	
	void Loop26() // Thank you Adrian for the input
	{
		bool[] skipLine = {false, false, true, false, true, false};
		
		for (int line=0; line<skipLine.Length; line++)
		{
			if (skipLine(line))
				line += int.Parse(Console.ReadLine());
		}
	}

	void Loop26a() // Thank you Adrian for the input
	{
		bool[] skipLine = {false, false, true, false, true, false};
		
		int line = 0;
		
		while (line<skipLine.Length)
		{
			if (skipLine(line))
				line += int.Parse(Console.ReadLine());
			
			
			line++;
		}
	}	

	void Loop27()
	{
		// What will be the value of "counter" at the end of the function?
		// Tip: beware of the indents
		
		int counter = 0;
		
		for (int i=0;i<10;i++)
			for (int j=6;j<10;j+=2)
				if (i>=4)
					++counter;
			for (int k=2;k<50;k*=5)
				++counter;
		
		Console.WriteLine(counter);
		Console.ReadLine();
	}
}


/* Solutions:

Loop1: 
	not ok: do not hard-code the iterator (i), when you use it as an index (arr[i]).
		instead of i<3 use i<arr.Length
		
Loop2:
	not ok: do not use a for loop to iterate through every element of a collection, when there is no use for the iterator.
		i is unused. better use foreach 
		
Loop3:
	ok: although i is unused, a foreach loop would not allow us to skip elements (i+=2)
	
Loop4:
	not ok: in general, "for" is the choice when we want to iterate reversely, but in this case reverse iteration give the same result as normal iteration.
		better use foreach
		
Loop4:
	ok: here, the reverse iteration is justified, because it would give another result than standard iteration. reverse iteration cannot be done by "foreach", so "for" is the correct choice

Loop5:
	ok: as we need the iterator for further actions, "for" is the preferred choice over "foreach"
	
Loop6:
	not ok: avoid "foreach" with a counter. the better choice is "for"
	
Loop7:
	ok: "foreach" is the ideal choice, when we want to iterate over every element of a collection, and the iterator is not needed
	
Loop8:
	not ok: do not use "while", when the condition is as simple as checking if the iterator is below a certain number. Therefore we have the "for" loop. Additionally in this case, we want to iterate through every element of the collection, so the correct choice is "foreach"
	
Loop9:
	not ok: although "while" is justified as the condition is more complex other than "i < x", the solution is not ideal, because it requires the same condition two times. 
		the correct soluton is while(true). See Loop10
		
Loop10:
	ok: the correct solution of the problem in Loop9. while(true) and "break".
	
Loop11:
	not ok: in general, "while" is ok for boolean conditions, but here the mistake is that the program will never enter the loop. 
		"do - while" is the correct solution, as is allow the loop to be run at least once. See Loop12
		
Loop12:
	ok: the correct solution of the problem in loop11
	
Loop13:
	ok: a very efficient way of avoiding infinite loops. "for" sets the maximum iterations (emergency exit), and the "break" is the main condition.
	
Loop 14:
	not ok: misuse of "continue", which is use to jump early to the next iteration omitting the remaining part of the current iteration. "continue" at the end of the iteration makes no sense.
	
Loop15:
	not ok: in general, it is ofcourse ok to use "if - else", but here it is better to use "continue", as it will allow the larger "else" part to be outside the "if". This increases code readability by reducing indents. See Loop16
	
Loop16: 
	ok: the correct solution of Loop15
	
Loop17:
	not ok: this one is tricky. formulate your "if" condition so, that the "if" part is smaller, because than you can use "continue", and leave the larger part outside the "if"
	
Loop18:
	not ok: this unfortuneately does not compile in C#. (But in Java it does)
	
Loop19:
	not ok: as a general rule, do not manipulate the "for" iterator. This is a dirty solution.
	
Loop19a:
	ok: it is ok to use a flag, but Loop21 is the better solution.
	
Loop20:
	ok (but not ideal): some say, that this is the only case, where "goto" is allowed (trying to leave a nested loop). But Loop21 is the better solution.
	
Loop21:
	ok: the best solution to exit a nested loop. Put the loop into a separate method. This solves two problems at once. Exit a nested loop with only "return" and complying to the Single Responsibility principle (= small units that have only one task).
	
Loop22:
	not ok: in general, every infinite "while (true)" loop should have an exit condition. There are cases where a true infinite loop is acceptable (for example a server), but still it is better to have an exit solution. Loop22 is not a vicious as Loop23, because it has a Console.ReadLine() which stops code execution until an action of the user.
	
Loop23:
	not ok: this is a classical infinite loop. Especially toxic in VBA, where Excel crashes and you lose your unsaved data. In C# it is at least easy to kill the process.
	
Loop24:
	not ok: do not manipulate the iterator of a "for" loop, as you run the risk to create an infinite loop.
	
Loop25:
	not ok: this is a little bit better than Loop24 (because "while" in general allows the manipulation of counter), but still far from ok. Changing counters into two directions is risky, as it easily produces an infinite loop
	
Loop26:
	not ok: do not manipulate the iterator of a "for" loop. When you do not know the iterator jumps on design-time, use the while-loop (Loop26a)
		
Loop26a:
	ok
*/
