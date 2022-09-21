//If Statements and accessing
using System;
					
public class Program
{
	public Operations myOperator;
	
	public  void Main()
	{
		myOperator = new Operations();
		Console.WriteLine("Math Time!");
		myOperator.DoMath(7,8);
		myOperator.DoMath(2,1);
		myOperator.DoMath(6,5);
		myOperator.IfGreater(7,5);
		myOperator.IfGreater(3,9);
	}
	
}

public class Operations
{
	public void DoMath(int value, int value2)
	{
		var number = value + value2;
		Console.WriteLine(number);
	}
	public void IfGreater(int value, int value2)
	{
		if(value>value2)
		{Console.WriteLine("True, the first is greater");
		} else{
			Console.WriteLine("False, the last is greater");
		}
	}
}


//Switch statemens

using System;
					
public class Program
{
	public GameStates gameStates;
	
	public void Main()
	{
	gameStates = new GameStates();
	gameStates.currentState = GameStates.States.Playing;
	gameStates.CheckStates();
	}
}

public class GameStates
{
	public enum States {
		Starting,
		Playing,
		Ending,
	}
	public States currentState = States.Starting;
	
	public void CheckStates () {
		switch (currentState) {
			case States.Starting: Console.WriteLine("Starting Game"); 
				break;
			case States.Playing: Console.WriteLine("Playing the Game"); 
				break;
			case States.Ending: Console.WriteLine("Game End"); 
				break;
		}
	}
}

//Switch Example

int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)