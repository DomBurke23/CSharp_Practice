using System;
using System.Collections.Generic;

namespace ListDemo
{
	class ListPractice
	{
		static void Main()
		{
			/* Lists */
			List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" }; // Object Initialization
			citiesList.Add("New York City");
			citiesList.Remove("Dubai");
			citiesList.AddRange(new string[] {"Cairo", "Johannesburg"});
			bool hasNewDelhi = citiesList.Contains("New Delhi");
			foreach (string city in citiesList)
			{
				Console.WriteLine(city);
			}
			string city1 = citiesList[0];
			Console.WriteLine(city1);
			citiesList[0] = "New Delhi";
			Console.WriteLine(city1);
			Console.WriteLine(citiesList[0]);
			List<double> marathons = new List<double>();
			marathons.Add(144.07);
			marathons.Add(143.12);
			marathons.Add(146.73);
			marathons.Add(146.33);
			Console.WriteLine(marathons[1]);
			double time = marathons[1];
			Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");
			int numberCities = citiesList.Count; // finds the number of elements in list 
			bool hasDelhi = citiesList.Contains("Delhi"); // checks is an element is in the list 
			bool hasDubai = citiesList.Contains("Dubai");
			Console.WriteLine($"{numberCities}\n{hasDelhi}\n{hasDubai}"); 
			int numberMarathons = marathons.Count;
			Console.WriteLine(numberMarathons);
			marathons.Add(143.23);
			bool NaokoTakahashi = marathons.Contains(143.23);
			Console.WriteLine(NaokoTakahashi);
			numberMarathons = marathons.Count;
			Console.WriteLine(numberMarathons);
			Console.WriteLine(marathons[1]);
			bool removed = marathons.Remove(143.12);
			Console.WriteLine(marathons[1] + " " +  removed );
			citiesList.Clear(); // remove all items from list 
			List<int> numbers = new List<int>();
			// add an infinite number of items to a list 
			for (int i = 0 ; i < 1000; i++)
			{
				numbers.Add(i);
			}
			int numberFive = numbers[4];
			numbers[4] = 523;
			//Console.WriteLine(numbers[1001]); //error out of range 
			int index = 1001;
			if (index < numbers.Count)
			{
			  Console.WriteLine(numbers[index]);
			}
			List<string> places = new List<string> { "first", "second" };
			places.AddRange(new string[] { "fifth", "sixth" }); // List is  "first", "second", "fifth", "sixth" ]
			places.InsertRange(2, new string[] { "third", "fourth"}); // List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]
			places.RemoveRange(4, 2); // List is [ "first", "second", "third", "fourth" ]
			List<string> newPlaces = places.GetRange(0, 3); // New list is [ "first", "second", "third" ]
			List<double> topMarathons = marathons.GetRange(0, 3); 
			foreach (double counter in topMarathons)
			{
				Console.WriteLine(counter);
			}
			List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
			Random rand = new Random();
			Console.WriteLine("In reverse chronological order, the gold medalists are...");
			// First loop
			for (int i = 0; i < runners.Count; i++)
			{
				Console.WriteLine($"{i+1}: {runners[i]}");
			}
			Console.WriteLine("\nPrinting runner bibs...");
			// Second loop replaced by the following foreach loop 
			/*
			for (int i = 0; i < runners.Count; i++)
			{
				string name = runners[i].ToUpper();
				int id = rand.Next(100, 1000);
				Console.WriteLine($"{id} - {name}");
			}
		  */
			foreach (string runner in runners) {
				string name = runner.ToUpper();
				int id = rand.Next(100, 1000);
				Console.WriteLine($"{id} - {name}");
			}
		}
	}
}