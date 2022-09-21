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