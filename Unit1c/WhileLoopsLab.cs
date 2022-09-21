using System;
					
public class Program
{
	public static void Main()
	{
		string[] animals = {"cat", "dog", "pig", "snake"};
		Console.WriteLine(animals.Length);
			
		int i = 0;
		while (i < 3) 
		{
		 Console.WriteLine(animals[i]);
	 	 i++;
		}
	}
}