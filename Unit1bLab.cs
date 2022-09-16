using System;
					
public class Program
{
	public Mathmatics mathProblems;
	
	public void Main()
	{
		mathProblems = new Mathmatics();
		
		Console.WriteLine("How many apples does sarah have?");
		mathProblems.DoMath(14,24);
		mathProblems.IsItABerry(7,2);
		mathProblems.IsItABerry(4,10);
		mathProblems.Codeword("fluffernutter");
		mathProblems.Codeword("peanutbutter");
		
	}
}

public class Mathmatics {
	public void DoMath (int greenApples, int redApples) {
		var apples = greenApples + redApples;
		Console.WriteLine(apples);
	}
	
	public void IsItABerry (int bananas, int oranges) {
		if(bananas > oranges) {
			Console.WriteLine("Bananas, Berries and Cream.");
		} else {
			Console.WriteLine("Oranges, Color or Fruit.");
		}
	}
	public void Codeword (string codeWord) {
		if(codeWord == "fluffernutter") {
			Console.WriteLine("FLUFFERNUTTER!");
		} else {
			Console.WriteLine("AHHHHHH!");	
		}
	}
	
}

//fix the errors

using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome");
		DoMath(10, 4);
		DoMath(20, 7);
		DoMath(30, 15);
	
	}
						  
	public void DoMath (int value, int value2) {
		var number = value + value;
		Console.WriteLine(number);
	}
}

//Switches Challenge

using System;
					
public class Program
{
	public void Main()
	{
		int fruit = 4;
switch (fruit) 
{
  case 1:
    Console.WriteLine("oranges");
    break;
  case 2:
    Console.WriteLine("strawberries");
    break;
  case 3:
    Console.WriteLine("fruitsbasket");
    break;
  case 4:
    Console.WriteLine("riceball");
    break;
  case 5:
    Console.WriteLine("peach");
    break;
}
	}
}