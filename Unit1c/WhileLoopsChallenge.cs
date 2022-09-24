using System;
					
public class Program
{
	public static void Main()
	{
		string[] plants = {"succulent", "vine", "moss", "flower"};
		Console.WriteLine(plants.Length);
			
		int i = 0;
		while (i < 3) 
		{
		 Console.WriteLine(plants[i]);
	 	 i++;
		}
	}
}