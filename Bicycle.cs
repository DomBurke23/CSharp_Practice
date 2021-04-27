using System;

namespace LearnInheritance
{
	class Bicycle : Vehicle // class that inherits 
	{
		public Bicycle(double speed):base(speed) // constructor 
		{
		  Wheels = 2; 
		}
		
		// override an inherited method , mark as virtual in superclass.  
		public override void SpeedUp() {
			Speed += 5; 
			if (Speed >15){
				Speed = 15; 
			}
		}

		public override void SlowDown() {
			Speed -= 5; 
			if (Speed <0){
				Speed = 0; 
			}
		}
		
		public override string Describe()
		{
		return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
		}
	}
}