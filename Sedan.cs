using System;

namespace LearnInterfaces
{
  class Sedan : Vehicle, IAutomobile
  {
	/* moved to Vehicle.cs 
  	public string LicensePlate
    { get; }

    public double Speed
    { get; private set; }

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
	
	public Sedan(double speed) : base(speed) // calling superclass constructor 
    {
		/* replaced with :base(speed) in constructor 
		Speed = speed;
		LicensePlate = Tools.GenerateLicensePlate(); // utility class 
		*/
		Wheels = 4;
    }
	
	public override string Describe()
	{
	  return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
	}
  }
}