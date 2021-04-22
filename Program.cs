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
 * 
 * methods use void as their return type if they are not expecting to return a value. 
 */

namespace HelloWorld
{
  class Program
  {
	static void VisitPlanets(){
		Console.WriteLine("Entered VisitPlanets");
	}
	static void VisitPlanetsParam(int numberOfPlanets){
		Console.WriteLine($"Entered VisitPlanetsParam - You visited {numberOfPlanets}");
	}
	static void VisitPlanetsOptionalParam(int numberOfPlanets=0){ // default value of parameter is 0 if not passed one 
		Console.WriteLine($"Entered VisitPlanetsOptionalParam - You visited {numberOfPlanets}");
	}
	static void VisitPlanetsNamedArgument(int a=0, string b ="0", int c =0 ){ 
		Console.WriteLine($"Entered VisitPlanetsNamedArgument - You visited: {a},{b},{c}");
	}
	static void NamePets(string a, string b){
		Console.WriteLine($"Your pets {a} and {b} will be joining your voyage across space!");
	}
	static void NamePets(string a, string b, string c){
		Console.WriteLine($"Your pets {a} , {b} and {c} will be joining your voyage across space!");
	}
	static void NamePets( ){
		Console.WriteLine("Aw, you have no spacefaring pets :(");
	}
	static string Yell(string phrase, out bool wasYellCalled)
	{
	  wasYellCalled = true;
	  return phrase.ToUpper();
	}
	static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled  = true; 
      return phrase.ToLower();
    }
	/* Expression-bodied Definitions 
	bool IsEven(int num) {
		return num % 2 == 0; 
	} 
	--- can be shortened to this : */
	static bool IsEven(int num) => num % 2 == 0; 
	void Shout(string x) => Console.WriteLine(x.ToUpper()); // works if returning nothing (void) too
	static double DaysToRotations(double days)=> days / 365; 
    static void Welcome(string planet)=>Console.WriteLine($"Welcome to {planet}!");
	public static bool IsLong(string word)
    {
      return word.Length > 8;
    }    
	static bool HitGround(string s)
    {
      return s == "meteorite";
    } 
	static bool isBig(int n) => n > 100;
    static bool isSmall(int n) => n < 10;
	static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
	static void CreateTodoItem(string item)
    {
      Console.WriteLine($"[] {item}");
    }
	
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
		 * Make sure there isn’t a space in between the $ and the starting quotation mark ". */
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
		bool logicalAnd = (((3439 > 40) && (1 < 3)) || logicalOr);
		bool beach = true;
		bool hiking = false;
		bool city = true;
		bool yourNeeds = (beach&&city);
		bool friendNeeds = (beach||hiking); 
		bool tripDecision = (yourNeeds&&friendNeeds);
		Console.WriteLine(tripDecision);
		
		/* if statement */
		string color = "blue";
		if (color == "blue"){
			// this code block will execute only if the value of color is 
			// equivalent to "blue"
			Console.WriteLine("color is blue");
		}
		
		/* else statement */
		color = "red";
		if (color == "blue"){
			// this code block will execute only if the value of color is 
			// equivalent to "blue"
			Console.WriteLine("color is blue");
		} 
		else {
			// this code block will execute if the value of color is 
			// NOT equivalent to "blue"
			Console.WriteLine("color is NOT blue");
		}
		
		/* elseif statement */
		if (color == "blue"){
			// this code block will execute only if the value of color is 
			// equivalent to "blue"
			Console.WriteLine("color is blue");
		} 
		else if (color == "red"){
			// this code block will execute if the value of color is 
			// equivalent to "red"
			Console.WriteLine("color is NOT blue");
		} 
		else { // this is optional 
			// this code block will execute if the value of color is 
			// NOT equivalent to "blue" OR "red"
			Console.WriteLine("color is NOT blue OR red");
		}
		
		/* switch statement */
		switch (color)
		{
		   case "blue":
			  // execute if the value of color is "blue"
			  Console.WriteLine("color is blue");
			  break;
		   case "red":
			  // execute if the value of color is "red"
			  Console.WriteLine("color is red");
			  break;
		   case "green":
			  // execute if the value of color is "green"
			  Console.WriteLine("color is green");
			  break;
		   default:
			  // execute if none of the above conditions are met
			  break;
		}
		
		
		Console.WriteLine("Choose a movie genre: ");
		string genre = Console.ReadLine();
		switch (genre)
		{
			case "Drama":
				Console.WriteLine("Citizen Kane");
				break;
			case "Comedy":
				Console.WriteLine("Duck Soup");
				break;
			case "Adventure":
				Console.WriteLine("King Kong");
				break;
			case "Horror":
				Console.WriteLine("Psycho");
				break;
			case "Science Fiction":
				Console.WriteLine("2001: A Space Odyssey");
				break;
			default:
				Console.WriteLine("No movie found");
				break;
		}
		
		/* Ternary expression */
		color = "blue";
		string ternaryResult = (color == "blue") ? "blue" : "NOT blue";
		Console.WriteLine(ternaryResult);
		int pepperLength = 4;
		string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer" ;
		Console.WriteLine(message);
		
		/* returns smallest number */
		Console.WriteLine(Math.Min(3, 4));
		
		string designer = "Anders Hejlsberg";
		int indexOfSpace = designer.IndexOf(" "); 
		string secondName = designer.Substring(indexOfSpace);
		Console.WriteLine(secondName);
		
		/* Calling a user defined method */
		VisitPlanets(); // no arguments 
		VisitPlanetsParam(3); // must pass one integer 
		VisitPlanetsOptionalParam(); 
		VisitPlanetsOptionalParam(5); 
		VisitPlanetsNamedArgument(); // prints all default values 
		VisitPlanetsNamedArgument(4); // changes the first default value 
		VisitPlanetsNamedArgument(c:4); // changes argument c value 
		VisitPlanetsNamedArgument(b:"Dom",c:6);
		
		/* Method Overloading */ 
		Console.WriteLine(Math.Round(3.14159, 2)); // returns 3.14
		Console.WriteLine(Math.Round(3.14159)); // returns 3
		NamePets("Laika", "Albert");
		NamePets("Mango", "Puddy","Bucket");
		NamePets();
		
		/* Int32.TryParse */
		string textNumber = "abc"; 
		int number2, number3;
		Console.WriteLine(Int32.TryParse(textNumber, out number2)); 
		var boolParse = Int32.TryParse(textNumber,out number2); 
		if (boolParse==true){ Console.WriteLine(number2); } else { number2 =0; Console.WriteLine(number2); }
		bool success = Int32.TryParse("10602", out number2); 
		Console.WriteLine("success = " + success); // number2 is 10602 and success is true
		bool success2 = Int32.TryParse(" !!! ", out number3);
		Console.WriteLine("success2 = " + success2);
		string ageAsString = "102";
		string nameAsString = "Granny";
		int ageAsInt, nameAsInt; 
		bool outcome, outcome2; 
		outcome = Int32.TryParse(ageAsString, out ageAsInt); 
		Console.WriteLine($"Outcome = {outcome} and ageAsInt = {ageAsInt}");
		outcome2 = Int32.TryParse(nameAsString, out nameAsInt); 
		Console.WriteLine($"Outcome2 = {outcome} and nameAsInt = {nameAsInt}");
		
		message = "garrrr";
		Console.WriteLine(Yell(message, out bool flag));
		string statement = "GARRRR";
		bool marker;
		string murmur = Whisper(statement, out marker);
		Console.WriteLine(murmur);
		
		/* Expression-bodied Definitions */
		Welcome("Earth");
		double days = 500;
		double rotations = DaysToRotations(days);
		Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
		
		/* Methods as Arguments */
		int[] numbers = {1, 3, 5, 6, 7, 8};
		bool hasEvenNumber = Array.Exists(numbers, IsEven); // IsEven is called for every element in the array. 
		Console.WriteLine(hasEvenNumber); // prints true if one of the elements in the array is even. 
		string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
		string firstLongAdjective = Array.Find(adjectives, IsLong);
		Console.WriteLine($"The first long word is: {firstLongAdjective}.");
		
		/* Lambda Expression */
		//hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );  // anonymous method: it has no name.
		// we can remove int with deductive reasoning. When there is one parameter we can remove the parentheses(). 
		hasEvenNumber = Array.Exists(numbers, num => num % 2 == 0 ); 
		Console.WriteLine(hasEvenNumber);
		bool hasBigDozen = Array.Exists(numbers, (int num) => {
		bool isDozenMultiple = num % 12 == 0;
		bool greaterThan20 = num > 20;
		return isDozenMultiple && greaterThan20;}); 
		Console.WriteLine(hasBigDozen);
		
		string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
		//bool makesContact = Array.Exists(spaceRocks, HitGround);
		/* rewrite the line above as a lambda expression */ 
		bool makesContact = Array.Exists(spaceRocks,(string s) => s == "meteorite" );
		if (makesContact)	{
			Console.WriteLine("At least one space rock has reached the Earth's surface!");
		} 
		int[] nums = {0, 555, 252, 3, 9, 101};
		bool hasBigNum = Array.Exists(nums, isBig);
		bool hasSmallNum = Array.Exists(nums, isSmall);
		bool hasMediumNum = Array.Exists(nums, (n) => n >= 10 && n <= 100);
		Console.WriteLine($"Any big #s? {hasBigNum}");
		Console.WriteLine($"Any small #s? {hasSmallNum}");
		Console.WriteLine($"Any medium #s? {hasMediumNum}");
		
		/* Arrays */
		int[] x; 
		double[] d; 
		int[] plantHeights = { 3, 6, 4, 1, 6, 8 };
		//You may also see arrays defined and initialized using a new keyword
		int[] plantHeights1 = new int[] { 3, 4, 6 };
		// if you decide to define an array and then initialize it later (rather in one line like above) you must use the new keyword
		x = new int[] { 3, 4, 6 }; 
		string[] summerStrut;
		summerStrut = new string[]{"Juice","Missing U","Raspberry Beret","New York Groove","Make Me Feel","Rebel Rebel", "Despacito","Los Angeles" };
		int[] ratings = {5, 4, 4, 3, 3, 5, 5, 4 };
		int arrayLength = plantHeights.Length; 
		Console.WriteLine($"Array Length {arrayLength}");
		if (summerStrut.Length== 8){ 
			Console.WriteLine("Ready to play!");
		} else if (summerStrut.Length>8) {
			Console.WriteLine("Too many songs!");
		} else {
			Console.WriteLine("Not enough songs!");
		}
		int plantTwoHeight = plantHeights[1]; // accessing an element in the array 
		Console.WriteLine($"Index 1 = {plantTwoHeight}" );
		Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars");
		int[] houseHeights = new int[3]; // will have 3 elements all 0 
		houseHeights[2] = 8; // [0,0,8] 
		// plantHeights will be [3, 5, 6]
		plantHeights[1] = 5; 
		summerStrut[7]="I Like It";
		ratings[7]=1;
		Console.WriteLine($"ratings[7] = {ratings[7]}"); 
		foreach (int i in plantHeights) Console.Write(i + " ");
		Array.Sort(plantHeights); 
		foreach (int i in plantHeights) Console.Write(i + "\n ");
		Array.IndexOf(plantHeights, 6);  // returns 1
		// Find the first occurence of a plant height that is greater than 5 inches, 
		int firstHeight = Array.Find(plantHeights, height => height > 5);
		int ratingThree = Array.IndexOf(ratings, 3);
		Console.WriteLine($"Song number {summerStrut[ratingThree+1]} is rated three stars");
		string longName = Array.Find(summerStrut, longname => longname.Length > 10);
		Console.WriteLine($"he first song that has more than 10 characters in the title is {longName}");
		Array.Sort(summerStrut);
		Console.WriteLine(summerStrut[0] + summerStrut[7]);
		foreach (string str in summerStrut) Console.Write(str + " "); // print string array 
		foreach (int i in ratings) Console.Write(i + " "); // print int array 
		
		string[] summerStrutCopy = new string[8]; // create a copy of the array 
		Array.Copy(summerStrut, summerStrutCopy, 8); // copy the elements into copy 
		foreach (string str in summerStrutCopy) Console.Write(str + " \n"); // print array 
		Array.Reverse(summerStrutCopy); // reverse the elements in the array 
		Console.WriteLine($"{summerStrutCopy[0]} {summerStrutCopy[7]}");// printing 1st and last element 
		Array.Clear(ratings,0,ratings.Length); // clear array / set all elements to the same value 
		foreach (int i in ratings) Console.Write(i + " ");
		
		/* While loop */
		int emails = 20;  
		while (emails>0){
			emails--; Console.WriteLine($"Inbox: {emails}");
		}
		Console.WriteLine("INBOX ZERO ACHIEVED!");
		
		/* Do while loop */
		bool buttonClick = true;
		do {
			Console.WriteLine("BLARRRRRRRRR");
		} while (!buttonClick);
		Console.WriteLine("Time for a five minute break.");
		
		/* for loop */
		for ( int i = 0; i < 17; i++ ){
			CreateTemplate(i);
		}
		string[] items = { "potion", "dagger", "shield", "plant" };
		for (int i = 0; i < items.Length; i++)	{
		  Console.WriteLine(items[i]);
		}
		
		/* for each loop (or collection loops) used for collections/sequences like arrays */
		string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
		foreach(string counter in todo){CreateTodoItem(counter);}
		
		/* do while loop */
		buttonClick = false;
		int loopcounter=0; 
			do	{
			Console.WriteLine("BLARRRRR");
			loopcounter++; 
			if (loopcounter==3){break;}
		} //while(!buttonClick&&(loopcounter<3));
		   while(!buttonClick);
		   
	} 
  }
}
 
