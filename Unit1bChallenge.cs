using System;
					
public class Program
{
	public PowerUps powerState;
	
	public void Main()
	{
	powerState = new PowerUps();
	powerState.CheckStates();
			if (powerState.powerUp == true)
	{
		Console.WriteLine("Power On");
	}
	}

}

public class PowerUps
{
	public bool powerUp = false;
	public enum Powers {
		Speed,
		Strength,
		Powerdown,
	}
	public Powers currentPower = Powers.Speed;
	
	public void CheckStates () {
		switch (currentPower) {
			case Powers.Speed: Console.WriteLine("Gotta go fast"); 
				powerUp = true;
				break;
			case Powers.Strength: Console.WriteLine("Stronk");
				powerUp = true;
				break;
			case Powers.Powerdown: Console.WriteLine("weak");
				break;
		}
	}
}