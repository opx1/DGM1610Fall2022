using System;
					
public class NumbersClass
{
    public int number = 73;
    public string numName = "Seventy Three";
	 public void RunFunction()
    {
        Console.WriteLine(numName);
    }
}

public class ClassWithFunctions
{
	public void Main()
	{
        Console.WriteLine("Class challenge practice") ;
	}
 
}   

using System;

public class CorrectTheErrors
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World, How's it goin?" );
						  }
}

using System;

public class Program
{
	public Hero heroMain;
	public Hero heroSide;
	public Hero heroVillian;
	
	public void Main()
	{
		heroMain = new Hero();
		heroSide = new Hero();
		
		heroMain.health = 2;
		heroMain.powerLevel = 5;
		
		heroSide.health = 3;
		heroSide.powerLevel = 1;
		
		Console.WriteLine(heroMain.health);
		Console.WriteLine(heroMain.powerLevel);
		
		Console.WriteLine(heroSide.health);
		Console.WriteLine(heroSide.powerLevel);
		
		heroVillian = new Hero();
		
		heroVillian.experience = 98.2f;
		heroVillian.secrets = 7;
		
		Console.WriteLine(heroVillian.experience);
		Console.WriteLine(heroVillian.secrets);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public float experience;
	public int secrets;
}

using System;

public class Program
{
	public Food foodKitchen;
	public Food foodRestaurant;
		
	public void Main()
	{
		foodKitchen = new Food();
		foodRestaurant = new Food();
		
		foodKitchen.donuts= 1.5f;
		foodKitchen.strawberries = 10;
		
		foodRestaurant.donuts = 12f;
		foodRestaurant.strawberries = 2;
		
		Console.WriteLine(foodKitchen.strawberries);
		Console.WriteLine(foodRestaurant.donuts);
	}
}
public class Food
{
	public int strawberries;
	public float donuts;
}
