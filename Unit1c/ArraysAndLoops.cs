//Arrays

using System;
					
public class Program
{
	public void Main()
	{
		string[] animals = {"cat", "dog", "pig", "snake"};
		Console.WriteLine(animals.Length);
		Console.WriteLine(animals[2]);
	}
}

//foreach loops

using System;
					
public class Program
{
	public void Main()
	{
		string[] animals = {"cat", "dog", "pig", "snake"};
		Console.WriteLine(animals.Length);
		foreach(var animal in animals){
		Console.WriteLine(animal);	
		}
	}
}

//for loops

using System;
					
public class Program
{
	public void Main()
	{
		string[] animals = {"cat", "dog", "pig", "snake"};
		for (var i = 0; i < animals.Length; i++) {
			animals[i] = "lil guy";
		}
		
		Console.WriteLine(animals.Length);
		foreach(var animal in animals){
		Console.WriteLine(animal);	
		}
	}
}

//Arrays loops and Classes

using System;
					
public class Program
{
	public void Main()
	{
		Animals[] animal = {new Animals(), new Animals(), new Animals()};
		animal[1].animalType = "dog";
		animal[2].animalType = "ferret";
		
		for (var i = 0; i < animal.Length; i++) {
			animal[i].mammal = true ;
		}
		
		Console.WriteLine(animal.Length);
		foreach(var creature in animal){
		Console.WriteLine(creature.animalType);	
		}
	}
}

public class Animals
{
	public string animalType = "cat";
	public bool mammal = false;
}

//While Loop

using System;
					
public class Program
{
	public static void Main()
	{
	int i = 0;
	while (i < 5) 
		{
		 Console.WriteLine(i);
	 	 i++;
		}
		int a = 0;
	do 
	{
  	Console.WriteLine(a);
  	a++;
	}
	while (a < 5);
	}
}