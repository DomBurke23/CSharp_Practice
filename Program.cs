using System;

/**
 *  Some C# skills. 
 *  dotnet run 
 *
 *  int is a whole number.
 *  double is more precise than float. 
 *  double is faster to process than decimal. 
 *  Decimal is more precise for financial applications. 
 *
 *  The difference between Write() and WriteLine() method is based on new line character.
 *  WriteLine() automatically adds the \n line break. 
 */

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
		//Console.WriteLine("This is the syntax to print text");
		Console.WriteLine("How old are you?"); // print text
		string input = Console.ReadLine(); // get user input 
		Console.WriteLine("You are {input} years old!"); // print user input 
		
		// Create Variables
		string name = "Shadow"; 
		string breed = "Golden Retriever";
		int age = 5;
		double weight = 65.22;
		bool spayed = true;
		int evenNumber = 22; 
		int oddNumber = 45; 
		
		// Print variables to the console
		Console.WriteLine(name);
		Console.WriteLine(breed);
		Console.WriteLine(age);
		Console.WriteLine(weight);
		Console.WriteLine(spayed);
		Console.WriteLine(evenNumber+oddNumber); 
		
		/* convert double to an int 
		double myDouble=3.2;
		int myInt = myDouble; // error potential loss of data */
		// ok to convert a double to int
		int myInt = 3; 
		double myDouble = myInt; 
		Console.WriteLine("myInt=" + myInt + " myDouble=" + myDouble);
		/* convert double to an int by rounding myDouble to the nearest whole number */
		myDouble = 5.2; 
		myInt = (int)myDouble; 
		Console.WriteLine("myInt=" + myInt + " myDouble=" + myDouble);
		
		decimal decimalVariable = 489872.76m;
		
		// Ask user for fave number
		Console.Write("Enter your favorite number!: ");
		// Console.ReadLine() will always return a string.
		// Turn that answer into an int
		int faveNumber =Convert.ToInt32(Console.ReadLine());

		string myName = null; // assume they didn't give any input   
		Console.WriteLine(".ToString() : " + myName.ToString());  // if no input we get an error 
		Console.WriteLine("Convert.ToString() :" + Convert.ToString(myName)); // if no input we do not crash 

		long[] val = { 340, -200};
		double result;
		// long to double
		foreach (long number in val) {
		result = Convert.ToDouble(number);
		Console.WriteLine("Converted {0} value to {1}",number, result);
		}
		
		// Number of pizza shops
		int pizzaShops = 4332;
		// Number of employees
		int totalEmployees = 86928;
		// Revenue -- don't forget to add the m distinguish between a double and decimal 
		decimal revenue = 390819.28m; 
		// Log the values to the console:
		Console.WriteLine("pizzaShops = " + pizzaShops + " totalEmployees = " + " revenue = " + revenue);

		int answer = 4 + 19;
		Console.WriteLine(answer); 
		Console.WriteLine(5/3);
		Console.WriteLine(5/3.0); 
		/* If we do 1 + 2 * 3, it is harder for code to follow but c# follows a set of rules. */
		answer = 8 + (9 * 3);
		Console.WriteLine(answer); // = 35 
		answer = (8 + 9) * 3;
		Console.WriteLine(answer); // = 51
		answer = 8 + 9 * 3;
		Console.WriteLine(answer); // = 35  
		
		// Your Age
		int userAge = 32; 
		// Length of years on Jupiter (in Earth years)
		double jupiterYears = 11.86;
		// Age on Jupiter
		double jupiterAge = userAge/jupiterYears;
		// Time to Jupiter
		double journeyToJupiter = 6.142466;
		// New Age on Earth
		double newEarthAge = userAge+journeyToJupiter; 
		// New Age on Jupiter
		double newJupiterAge = newEarthAge/jupiterYears; 
		// Log calculations to console
		Console.WriteLine(newEarthAge);
		Console.WriteLine(newJupiterAge);
		
		int apple = 0;
		apple=apple+1;
		apple++;
		apple += 3; // is the same as apple = apple + 3
		Console.Write(apple); 

		/* A modulo returns a remainder, what is left over when we divide 
		a number by another number. 
		4 % 3 = 1
		4 % 2 = 0 	*/
		int eggs = 56;
		int crateAmount = 12;
		int eggsLeftOver = eggs % crateAmount; 
		Console.Write(eggsLeftOver); // prints 8
		/* It can also be used to check if a number is odd or even. 
		If a number is even, taking its modulo with 2 it will return a 0 
		and if it is odd it will return a 1: */
		int myNum = 85939824;
		Console.Write(myNum % 2); // prints 0, so number is even
		
		// Starting variables 
		int numberOne = 12932;
		int numberTwo = -2828472;
		/* double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
		double numberTwoSqrt = Math.Floor(Math.Sqrt(numberTwo)); */
		double numberOneSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberOne)));
		double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
		Console.WriteLine(Math.Min(numberOneSqrt,numberTwoSqrt)); // prints NaN - stands for not a number so use Math.Abs 
		
      double numberOne = 6.5;
      double numberTwo = 4;
      // Console.WriteLine(numberOne^numberTwo); // error 
      Console.WriteLine(Math.Pow(numberOne,numberTwo));
      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));
      // Find the larger number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));
	}
  }
}
 