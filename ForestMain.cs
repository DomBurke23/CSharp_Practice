using System;

namespace BasicClasses
{
  class ForestMain
  {
    static void Main(string[] args)
    {
        /* phrase is an instance of the string type. 
         * Every string has a Length property and IndexOf() method, 
         * but the resulting values are different for each instance. */
        string phrase = "zoinks!";
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.IndexOf("k"));
        
        /* A class represents a custom data type. 
         * In C#, the class defines the kinds of information 
         * and methods included in a custom type.
         * You can then make instances of that class 
         * (above, phrase was an instance of string). 
         * There may be many instances of the same class, all with unique values.*/
         
        /* The code for class Forest is in its own .cs file for debugging 
         * create an instance/object of that class with keyword new 
         * The process of creating an instance is called instantiation. */
        //Forest f = new Forest(); // parameterless constructor
        Forest f = new Forest(400,"Name1","Biome1"); // this is a constructor. 
        /* access and edit each field with dot notation */
        //f.name="Amazon"; // no propety 
        f.Name="Amazon"; // using properties
        //f.trees=300; 
        f.Trees=300; // access using property
        f.age=130;  // access using field which avoids properties validation by directly accessing the field
        //f.Age=120; // error due to having private setter 
        //f.biome="Tropical";
        f.Biome="Tropical";
        f.Biome = "Desert"; // the following will cause a crash due to value being invalid 
        Console.WriteLine($"{f.Name} , {f.Trees} , {f.age} , {f.Biome}"); 
        Forest f2 = new Forest(600,"Congo","Biome2");
        f2.name = "Congo";
        Console.WriteLine("f2.name = " + f2.name);
        
        f.Area = -1; // set() is called
        Console.WriteLine("Area = " + f.Area);
        int result = f.IncreaseArea(2);
        Console.WriteLine("result = " + result);
        Console.WriteLine("Grow() = " + f.Grow());
        Console.WriteLine("Burn() = " + f.Burn());
        Forest f3 = new Forest(1000);
        Forest.PrintTreeFacts();

		Console.WriteLine(Forest.ForestsCreated);
		Forest f4 = new Forest(350,"Name1a","Biome1a");
		Forest f5 = new Forest(800);
		Console.WriteLine(Forest.ForestsCreated);
    }
  }
}
