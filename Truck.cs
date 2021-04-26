using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {
  	public string LicensePlate
    { get; }

    public double Speed
    { get; }

    public int Wheels
    { get; }
     
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public double Weight
    {get;}

    public Truck(double speed, double weight) // constructor 
    {
		Speed = speed;
		Weight = weight; 
		LicensePlate = Tools.GenerateLicensePlate(); // utility class 
		if (Weight < 400 ) {
			Wheels = 8; 
		} else { 
			Wheels = 12; 
		}
    }
	
	public void SpeedUp()
	{
		Speed += 5;
	}
	
	public void SlowDown()
	{
		Speed -= 5;
	}
  }
}