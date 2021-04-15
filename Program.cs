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
		Console.WriteLine("pizzaShops = " + pizzaShops + " totalEmployees = " + totalEmployees + " revenue = " + revenue);

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
		
		double numberThree = 6.5;
		double numberFour = 4;
		// Console.WriteLine(numberThree^numberFour); // error 
		Console.WriteLine(Math.Pow(numberThree,numberFour));
		// Round numberThree up
		Console.WriteLine(Math.Ceiling(numberThree));
		// Find the larger number between numberThree and numberFour
		Console.WriteLine(Math.Max(numberThree, numberFour));
		
		/* What happens when you need to include quotes in a string? 
		 * You can use an escape sequence. An escape sequence places a backslash (\) 
		 * before the inner quotation marks, so the program doesn’t read them 
		 * accidentally as the end of sequence. 
		*/
		// string withoutSlash = "Ifemelu said, "Hello!""; // error 
		string withSlash = "Ifemelu said, \"Hello!\"";
		string newLine = "Ifemelu walked \n to the park."; // \n for new line 
		
		/* String concatenation */
		string yourFaveMusician = "David Bowie";
		string myFaveMusician = "Solange";
		Console.WriteLine("Your favorite musician is " + yourFaveMusician + " and mine is " + myFaveMusician + ".");
		/* String interpolation 
		 * Make sure there isn’t a space in between the $ and the starting quotation mark ".
		*/
		Console.WriteLine($"Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.");
		string beginning = "Once upon a time,";
		string middle = "The kid climbed a tree";
		string end = "Everyone lived happily ever after.";
		Console.WriteLine($"{beginning}{middle}{end}");
		string story = $"{beginning}{middle}{end}";
		Console.WriteLine(story);
		
		string userTweet = Console.ReadLine();
		Console.WriteLine(middle.Length);  
		Console.WriteLine(userTweet.Length);  // return length 
		string word = "radio";
		Console.WriteLine(word.IndexOf("a")); // return position 
		
		string password = "a92301j2add"; 
		int passwordLength = password.Length;  
		int passwordCheck = password.IndexOf("!"); // Check if password uses symbol 
		Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
				
		string plantName = "Cactaceae, Cactus"; 
		int charPosition = plantName.IndexOf("Cactus"); // returns 11
		string commonName = plantName.Substring(charPosition); // returns Cactus
		Console.WriteLine(charPosition + commonName); 
		
		string plantName2 = "Cactaceae, Cactus";
		int charPosition2 = plantName2.IndexOf("u"); // returns 15
		char u = plantName2[charPosition2]; // returns u
		Console.WriteLine(charPosition2 + " " +u); 

		string studentsName = "Farhad Hesam Abbasi";
		string firstCharacter = studentsName.Substring(0,1); 
		charPosition = studentsName.IndexOf(firstCharacter);
		char firstLetter = studentsName[charPosition];
		Console.WriteLine(firstCharacter + " " + charPosition + " " + firstLetter + " ");
		// Get last name
		string lastName = studentsName.Substring(studentsName.IndexOf("Abbasi")); 
		Console.WriteLine(lastName);

		string shouting = "I'm not shouting, you're shouting".ToUpper();
		Console.WriteLine(shouting);

		bool boolAnswer = 3 < 75; 
		Console.WriteLine(boolAnswer);
		boolAnswer = (true == false);
		Console.WriteLine(boolAnswer); 
		
		/* You are driving to your family’s house for a holiday and want to see if you’ll get there before dinner. 
		 * Dinner will begin at 6:00 PM and the house is 95 miles away. If you leave at 2:00PM and drive an average 
		 * of 30 miles per hour, will you get there early (before 6:00pm)? 
		*/
		double timeToDinner = 4; 
		double distance = 95; 
		double rate = 30; 
		double tripDuration = distance/rate;
		bool arriveOnTime = tripDuration<=timeToDinner;
		Console.WriteLine(arriveOnTime);
		
		bool logicalOr = (9 < 3) || (100 < 45); // evaluates to False
		bool logicalAnd = ((3439 > 40) && (1 < 3)) || answer;
		bool beach = true;
		bool hiking = false;
		bool city = true;
		bool yourNeeds = (beach&&city);
		bool friendNeeds = (beach||hiking); 
		bool tripDecision = (yourNeeds&&friendNeeds);
		Console.WriteLine(tripDecision);
	}
  }
}
 
