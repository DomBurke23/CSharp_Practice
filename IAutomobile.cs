using System;

namespace LearnInterfaces
{
  /* Every interface should have a name starting with “I”. */
  interface IAutomobile
  {
    string LicensePlate
    { get; }
    double Speed
    { get; }
    int Wheels
    { get; }
    void Honk();
  }
}