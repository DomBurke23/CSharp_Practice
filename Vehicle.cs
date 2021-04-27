using System;

namespace LearnInheritance
{
	abstract class Vehicle // superclass defined like a normal class 
	{
	
		public string LicensePlate
		{ get; private set; }

		public double Speed
		//{ get; private set; }
		{ get; protected set; }

		public int Wheels
		{ get; protected set; }
		   
		public void Honk()
		{
		  Console.WriteLine("HONK!");
		}
		
		//public void SpeedUp()
		public virtual void SpeedUp() // can be overridden 
		{
		  Speed += 5;
		}

		//public void SlowDown()
		public virtual void SlowDown() // can be overridden 
		{
		  Speed -= 5;
		}
	
		public Vehicle(double speed)
		{ 
		  Speed = speed;
		  LicensePlate = Tools.GenerateLicensePlate();
		} 
		
		public abstract string Describe(); // subclasses must define a Describe() method 
  }
}

