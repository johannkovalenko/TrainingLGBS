using System.Drawing;

class App
{
	static void Main()
	{
		var mario = new Mario();
		
		mario.Set(Action.EatsMushroom);
		mario.Set(Action.AttackedByKoopa);
		mario.Set(Action.FallsIntoAbyss);
		
		System.Console.ReadLine();
	}
}

enum Action
{
	EatsMushroom, 	//0
	EatsFlower, 	// 1
	AttackedByFlower,
	AttackedByKoopa,
	FallsIntoAbyss
}

class Mario
{
	private State currentState; // 1 : n
	private SetState setState;
	
	public Mario()
	{
		setState = new SetState();
		currentState  = setState.Default();
	}
	
	public void Set(Action action)
	{
		System.Console.WriteLine("Before " + action.ToString() + ":  " + currentState.name + "  Can shoot: " + currentState.canShoot);

		currentState = setState.Run(action, currentState);
		System.Console.WriteLine("After  " + action.ToString() + ":  " + currentState.name + "  Can shoot: " + currentState.canShoot);
	}
}

class SetState
{
	private States states = new States();
	
	public State Default()
	{
		return states.small;
	}
	
	public State Run(Action action, State currentState)
	{		
		switch (action)
		{
			case Action.AttackedByKoopa:
			case Action.AttackedByFlower:
				return Downgrade(currentState);
			case Action.EatsMushroom:
			case Action.EatsFlower:
				return Upgrade(currentState);
			case Action.FallsIntoAbyss:
				return states.dead;
			default:
				return currentState;
		}
	}
	
	private State Upgrade(State currentState)
	{
		switch (currentState.name)
		{
			case "Small":
				return states.big;
			case "Big":
				return states.shoot;
			default:
				return currentState;
			//case "Shoot":
				// do nothing
		}
	}
	
	private State Downgrade(State currentState)
	{
		switch (currentState.name)
		{
			case "Small":
				return states.dead;
			case "Big":
			case "Shoot":
				return states.small;
			default:
				return currentState;
		}		
	}	
}

// Can be inside SetState
class States
{
	public State small 	= new Small();
	public State big 	= new Big();
	public State shoot 	= new Shoot();
	public State dead 	= new Dead();
}

abstract class State
{
	public string 	name;
	public int 		height;
	public Color 	color1;
	public Color 	color2;
	public bool 	canShoot;
	public bool  	canCrushWall;
	public bool  	diesOfKoopa;
	public string 	view;
}

class Dead : State
{
	public Dead()
	{
		name = "Dead";
		height = 20;
		color1 = Color.Red;
		color2 = Color.Green;
		canShoot = false;
		canCrushWall = false;
		diesOfKoopa = true;
		view = "Front";
	}
}

class Small : State
{
	public Small()
	{
		name = "Small";
		height = 20;
		color1 = Color.Red;
		color2 = Color.Green;
		canShoot = false;
		canCrushWall = false;
		diesOfKoopa = true;
		view = "Profile";
	}
}

class Big : State
{
	public Big()
	{
		name = "Big";
		height = 40;
		color1 = Color.Red;
		color2 = Color.Green;
		canShoot = false;
		canCrushWall = true;
		diesOfKoopa = false;
		view = "Profile";
	}
}

class Shoot : State
{
	public Shoot()
	{
		name = "Shoot";
		height = 40;
		color1 = Color.Red;
		color2 = Color.White;
		canShoot = true;
		canCrushWall = true;
		diesOfKoopa = false;
		view = "Profile";
	}		
}