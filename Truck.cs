using System;

namespace LearnInterfaces
{
  class Truck : Vehicle, IAutomobile
  {
	/* code located in Vehicle.cs 
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

	public void SpeedUp()
	{
		Speed += 5;
	}
	
	public void SlowDown()
	{
		Speed -= 5;
	}
	*/
	
    public double Weight
    {get;}
	
    public Truck(double speed, double weight) : base(speed) // constructor 
    {
		/* replaced with :base(speed)
		Speed = speed;
		LicensePlate = Tools.GenerateLicensePlate(); // utility class 
		*/
		Weight = weight; 
		if (Weight < 400 ) {
			Wheels = 8; 
		} else { 
			Wheels = 12; 
		}
    }

  }
}
