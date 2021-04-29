using System;

namespace LearnReferences
{
  class ReferencesMain
  {
    static void Main(string[] args)
    {
		/* Instance created, diss1 is a reference to that location in memory */
		Dissertation diss1 = new Dissertation(); // constructor  
		Dissertation diss2 = diss1; // diss1 and diss2 refer to the same object 
		diss1.CurrentPage = 0;
		diss2.CurrentPage = 16;
		Console.WriteLine(diss1.CurrentPage);
		Console.WriteLine(diss2.CurrentPage);
		
		Diary dy1 = new Diary(5); 
		Diary dy2 = dy1; // reference 
		dy2.Flip();
		Console.WriteLine($"dy1 = {dy1.CurrentPage} and \ndy2 = {dy2.CurrentPage}");
		
		Book bookLocation = new Book();
		Book sameBookLocation = bookLocation;
		bool falseValue = false; 
		/* The false value was copied to a new location in memory for anotherFalseValue to use. */
		bool anotherFalseValue = falseValue; 
		
		int int1 = 6;
		int int2 = 6;
		Console.WriteLine(int1 == int2); // Output: true
		
		/* referential comparison - checks if two variables refer to the same memory location. */
		Dissertation d1 = new Dissertation(50);
		Dissertation d2 = new Dissertation(50);
		Console.WriteLine(d1 == d2); // Output: false due to two different locations in memory 
		Book b1 = new Book();
		Book b2 = b1; 
		Console.WriteLine(b1 == b2); // Output: true 
		
		Dissertation diss = new Dissertation();
		IFlippable fdiss = diss; // can ONLY use IFlippable functionality
		Console.WriteLine(diss.Define());
		//Console.WriteLine(fdiss.Define()); // This causes an error because Define() is not in IFlippable interface 
		Book bdiss = diss;
		Console.WriteLine(diss.Title);
		Console.WriteLine(bdiss.Title);
		diss.Define();
		// bdiss.Define(); // This causes an error!
		fdiss.CurrentPage = 42;
		//  bdiss.CurrentPage = 43; // This causes an error!
		//  fdiss.Stringify(); // This causes an error!
		bdiss.Stringify();
		Console.WriteLine(fdiss == bdiss);
		
		/* an array of IFlippable references */
		IFlippable[] classroom = new IFlippable[] { new Diary(1), new Diary(30), new Dissertation(50), new Dissertation(49) };
		foreach (IFlippable f in classroom) 
		{
		  f.Flip();
		}
		Book[] books = new Book[] {diss1,diss2,dy1,dy2 };
		foreach (Book b in books) 
		{
			b.Flip();
			Console.WriteLine(b.Title);
		}
		
		/* Polymorphism */
		Book bk = new Book();
		Book bdiss = new Dissertation();
		Console.WriteLine(bk.Stringify());
		Console.WriteLine(bdiss.Stringify());
		Book b1 = new Book();
		Book b2 = new Diary();
		Console.WriteLine(b1.Stringify());
		Console.WriteLine(b2.Stringify());
		
		/* Casting / upcasting / downcasting */
		Book bk = new Book();
		//Dissertation dbk = bk; // Error! Can not downcast due to Define() , must explicitly downcast 
		Dissertation bdk = (Dissertation)bk; // error 
		Diary dy = new Diary();
        //   Book bdiss = (Book)diss;
		//   Book bdy = (Book)dy;
		dy = null;
		Diary[] diaries = new Diary[5]; // diaries[1] is unassigned, diaries[2] is unassigned, etc.
		Console.WriteLine(dy); // nothing is printed 
		Console.WriteLine(dy == null); // Output = true 
    }
  }
}
