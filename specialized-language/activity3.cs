using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
    //Declare Variables
    float distKm;
    float distMiles;
    
    //Assign Value
    distKm = Convert.ToInt32(Console.ReadLine());
    distMiles = ConvKiloMetersToMiles(distKm);
    
    Console.WriteLine("Miles driven: ");
    Console.WriteLine(distMiles);
    }
    static float ConvKiloMetersToMiles(float numKilometers)
    {
    //Declare Variables
    float milesPerKm;
    float numMiles;
    
    
    //Assign Value
    milesPerKm = 0.621371f;
    numMiles = numKilometers * milesPerKm;
    
    return numMiles;
    }
    
   
  
    
  }
}