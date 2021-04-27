using System;

namespace LearnInheritance
{
	class Vehicle // superclass defined like a normal class 
	{
	
		public string LicensePlate
		{ get; private set; }

		public double Speed
		{ get; private set; }

		public int Wheels
		{ get; protected set; }
		   
		public void Honk()
		{
		  Console.WriteLine("HONK!");
		}
		
		public void SpeedUp()
		{
		  Speed += 5;
		}

		public void SlowDown()
		{
		  Speed -= 5;
		}
	
		public Vehicle(double speed)
		{ 
		  Speed = speed;
		  LicensePlate = Tools.GenerateLicensePlate();
		} 
  }
}

