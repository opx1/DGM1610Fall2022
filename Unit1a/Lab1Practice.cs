using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		string name = "Natalie";
		Console.WriteLine(name);
		int number = 36;
		Console.WriteLine(number);

        	int myNum = 75;               
		double myDoubleNum = 6.3333D;  
		char myLetter = 'G';        
		bool myBool = true; 
		string myText = "Good Practice";
		
		Console.WriteLine(myNum);
		Console.WriteLine(myDoubleNum);
		Console.WriteLine(myLetter);
		Console.WriteLine(myBool);
		Console.WriteLine(myText);

        long myLongNum = 175008945628L;
		Console.WriteLine(myLongNum);
		
		float myFloat = 17.67f;
		Console.WriteLine(myFloat);

        	int sum1 = 100 + 75;        
		int sum2 = sum1 + 630;      
		int sum3 = sum2 + sum2;
		Console.WriteLine(sum1);
		Console.WriteLine(sum2);
		Console.WriteLine(sum3);

        int sum1 = 100 + 75;        
		int sum2 = sum1 - 630;      
		int sum3 = sum2 * sum2;
		Console.WriteLine(sum1);
		Console.WriteLine(sum2);
		Console.WriteLine(sum3);
		
		int sum4 = sum3 / 75;        
		int sum5 = sum4 % 630;      
		int sum6 = sum5++ ;
		int sum7 = sum5-- ;
		Console.WriteLine(sum4);
		Console.WriteLine(sum5);
		Console.WriteLine(sum6);
		Console.WriteLine(sum7);

        int x = 5;//x = 5	
		int y = 5;
		int z = 5;
		int b = 5;
		int c = 5;
		int d = 5;
		int e = 5;
		int f = 5;
		int g = 5;
		int h = 5;
		x += 3;	//x = x + 3	
		y -= 3;	//x = x - 3	
		z *= 3;	//x = x * 3	
		b /= 3;	//x = x / 3	
		c %= 3;	//x = x % 3	
		d &= 3;	//x = x & 3	
		e |= 3;	//x = x | 3	
		f ^= 3;	//x = x ^ 3	
		g >>= 3;	//x = x >> 3	
		h <<= 3;	//x = x << 3
		Console.WriteLine(x);

        x == y;  //== Equal to
		x != y;	//!=	Not equal
		x > y;	//>	Greater than
		x < y;	//<	Less than
		x >= y;	//>=	Greater than or equal to
		x <= y; //<=	Less than or equal to
			
		x < 5 && x < 10; //&& 	Logical and	Returns true if both statements are true
		x < 5 || x < 4;  //|| 	Logical or	Returns true if one of the statements is true
		!(x < 5 && x < 10); //!	Logical not	Reverse the result, returns false if the result is true
	}
}

