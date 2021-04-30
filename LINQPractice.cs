using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
	class LINQPractice
	{
		static void Main()
		{
			string[] names = { "Tiana", "Dwayne", "Helena", "Dom" };
			var filteredNames = from n in names
				where n.Contains("a")
				select n;
			var shortNames = names.Where(n => n.Length < 4);
			foreach (string counter in filteredNames)
			{
				Console.WriteLine(counter); // all but Dom 
			}
			foreach (string counter in shortNames)
			{
				Console.WriteLine("shortNames = " + counter); // just Dom 
			}
			Console.WriteLine("-----");
			
			
			List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
			// Approach 1: without LINQ
			List<string> longLoudHeroes = new List<string>();
			foreach (string hero in heroes)
			{
				if (hero.Length > 6)
				{
				  string formatted = hero.ToUpper();
				  longLoudHeroes.Add(formatted);
				}
			}
			// Approach 2: with LINQ (Query syntax) 
			var longLoudHeroes2 = from h in heroes
				where h.Length > 6
				select h.ToUpper();
			Console.WriteLine("Your long loud heroes are...");
			foreach (string hero in longLoudHeroes2)
			{
				Console.WriteLine(hero);
			}


			var shortHeroes = from h in heroes // Query syntax 
				where h.Length < 8 
				select h; 
			Console.WriteLine("shortHeroes");
			foreach (string counter in shortHeroes)
			{
				Console.WriteLine(counter);
			}
			var longHeroes = heroes.Where(n => n.Length > 8); // Method syntax - Lambda expression 
			Console.WriteLine("longHeroes");
			foreach (string counter in longHeroes)
			{
				Console.WriteLine(counter);
			}
			Console.WriteLine(longHeroes.Count());
	
			
			// Query syntax
			var queryResult = from x in heroes // from x is the iterator and counter variable 
							where x.Contains("a") // where picks elements from the sequence if they satisfy the given condition 
							select $"{x} contains an 'a'"; // select determines what is returned for each element in the sequence
			// Method syntax
			var methodResult = heroes
				.Where(x => x.Contains("a"))
				.Select(x => $"{x} contains an 'a'");
			Console.WriteLine("queryResult:");
			foreach (string s in queryResult)
			{
				Console.WriteLine(s);
			}
			Console.WriteLine("\nmethodResult:");
			foreach (string s in methodResult)
			{
				Console.WriteLine(s);
			}
			
			
			/* select all of the elements in heroes that contain the character "i" */
			var heroesWithI = from x in heroes 
				where x.Contains("i") 
				select $"{x} contains an 'i'"; 
			foreach (string s in heroesWithI)
			{
				Console.WriteLine(s);
			}
			
			Console.WriteLine("-----");
			
			/* Write a from - select query that returns the same array as heroes, 
			 * but every space is replaced with an underscore (_). */
			var underscoredHeroes = from x in heroes 
				select x.Replace(" ", "_");
			foreach (string s in underscoredHeroes)
			{
				Console.WriteLine(s);
			}
			
			Console.WriteLine("-----");
			var heroesWithIlambda = heroes.Where(n => n.Contains("i") ); // Method syntax - Lambda expression 
			Console.WriteLine("heroesWithIlambda");
			foreach (string counter in heroesWithIlambda)
			{
				Console.WriteLine(counter);
			}
			Console.WriteLine(heroesWithIlambda.Count());
			
			
			/* select all the heroes with c in their name and then change just them to lower case. */
			var heroesWithC = heroes.Where(h=>h.Contains("c")); 
			foreach (string counter in heroesWithC)
			{
				Console.WriteLine(counter);
			}
			Console.WriteLine("-----");
			var lowerHeroesWithC = heroesWithC.Select(h=>h.ToLower()); 
			foreach (string counter in lowerHeroesWithC)
			{
				Console.WriteLine(counter);
			}
			Console.WriteLine("-----");
			/* Do the same task as above but a method-syntax chained expression */
			var sameResult = heroes
				.Where(h=>h.Contains("c"))
				.Select(h=>h.ToLower());
			foreach (string counter in sameResult)
			{
				Console.WriteLine(counter);
			}
			
			/* Write a method-syntax query that transforms each element in heroes to this format */
			// Method syntax - chained expressions
			var introducingFormat = heroes
				.Select(h => $"Introducing...{h}!");
			foreach (var v in introducingFormat)
			{
				Console.WriteLine(v);
			}
			// Query syntax
  			var indexHeroes = from x in heroes 
				where x.Contains(" ")
				select x.IndexOf(" ");
			foreach (var v in indexHeroes)
			{
				Console.WriteLine(v);
			}
			
			List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
			var orCheck = heroesList
				.Where(h=>h.Contains(".")||h.Contains("7"))
				.Select(h=>$"{h}");
			foreach (var v in orCheck)
			{
				Console.WriteLine(v);
			}
		}
	}
}