class MainClass_BadPractice
{
	private int myIntForStep1a;
	private int myIntForStep1b;
	private int myIntForStep1c;
	private int myIntForStep2a;
	private int myIntForStep2b;
	private int myIntForStep2c;
	private int myIntForStep3And4a;
	private int myIntForStep3And4b;
	private int myIntForStep3And4c;
	
	
	public void Start()
	{
		// 50 lines
	}
	
	private void Step1()
	{
		// 50 lines
	}
	
	private void Step2()
	{
		// 50 lines
	}
	
	private void Step3()
	{
		// 50 lines
	}

}

///////////////////////////

partial class MainClass_Improvement1_BadPractice
{
	// Still bad practice, because encapsultion did not change. 
	// Still 200 lines have access to the instance variables.
	
	private int myIntForStep1a;
	private int myIntForStep1b;
	private int myIntForStep1c;
	private int myIntForStep2a;
	private int myIntForStep2b;
	private int myIntForStep2c;
	private int myIntForStep3And4a;
	private int myIntForStep3And4b;
	private int myIntForStep3And4c;
	
	
	public void Start()
	{
		// 50 lines
	}
	
	private void Step1()
	{
		// 50 lines
	}
}

partial class MainClass_Improvement1_BadPractice
{	
	private void Step2()
	{
		// 50 lines
	}
	
	private void Step3()
	{
		// 50 lines
	}

}

//////////

// Key word: Segregation of concerns
class MainClass_Improvement2_Better
{
	private int myIntForStep3And4a;
	private int myIntForStep3And4b;
	private int myIntForStep3And4c;	
	
	public void Start()
	{
		new Step1().Run();
		new Step2().Run();
		//Attention: approach won't work, because parameters are sent as copy
		new Step3().Run(myIntForStep3And4a, myIntForStep3And4b, myIntForStep3And4c);
		new Step4().Run(myIntForStep3And4a, myIntForStep3And4b, myIntForStep3And4c);
		
	}

}

class Step1
{
	public void Run()
	{
		private int myIntForStep1a;
		private int myIntForStep1b;
		private int myIntForStep1c;
		//50 lines
	}
}

class Step2
{
	public void Run()
	{
		private int myIntForStep2a;
		private int myIntForStep2b;
		private int myIntForStep2c;
		//50 lines
	}
}

class Step3
{
	public void Run(int myIntForStep3And4a, int myIntForStep3And4b, int myIntForStep3And4c)
	{
		//50 lines
	}
}

class Step4
{
	public void Run(int myIntForStep3And4a, int myIntForStep3And4b, int myIntForStep3And4c)
	{
		//50 lines
	}
}

///////////////

//// Introducting abstraction via data structure

class MainClass_Improvement3_Better
{
	public void Start()
	{
		new Step1().Run();
		new Step2().Run();
		
		Step3And4 step3And4 = new Step3And4();
		
		new Step3().Run(step3And4);
		new Step4().Run(step3And4);
		
	}

}

class Step3And4
{
	public int myIntA;
	public int myIntB;
	public int myIntC;	
}

class Step1
{
	public void Run()
	{
		private int myIntForStep1a;
		private int myIntForStep1b;
		private int myIntForStep1c;
		//50 lines
	}
}

class Step2
{
	public void Run()
	{
		private int myIntForStep2a;
		private int myIntForStep2b;
		private int myIntForStep2c;
		//50 lines
	}
}

class Step3
{
	public void Run(Step3And4 step3And4)
	{
		//50 lines
	}
}

class Step4
{
	public void Run(Step3And4 step3And4)
	{
		//50 lines
	}
}
/////////////////////////

//// Improving encapsultion by disallowing Main to create instance of data structure


class MainClass_Improvement4_OK
{
	public void Start()
	{
		new Step1().Run();
		new Step2().Run();
		
		Step3And4 step3And4 = new Step3And4();
		
		new Step3().Run(step3And4);
		new Step4().Run(step3And4);
		
	}

}

partial class Step3And4
{
	class Step3And4Data
	{
		public int myIntA;
		public int myIntB;
		public int myIntC;	
	}	
}

partial class Step3And4
{
	class Step3
	{
		public void Run(Step3And4 step3And4)
		{
			//50 lines
		}
	}

	class Step4
	{
		public void Run(Step3And4 step3And4)
		{
			//50 lines
		}
	}
}

class Step1
{
	public void Run()
	{
		private int myIntForStep1a;
		private int myIntForStep1b;
		private int myIntForStep1c;
		//50 lines
	}
}

class Step2
{
	public void Run()
	{
		private int myIntForStep2a;
		private int myIntForStep2b;
		private int myIntForStep2c;
		//50 lines
	}
}




