using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
    //Declare Variable
    int stepsWalked;
    float feetPerStep;
    int feetPerMile;
    float stepsPerMinute;
    float calPerMinuteWalking;
    float minutesTotal;
    float caloriesTotal;
    float milesWalked;
    
    //Assign Value
    feetPerMile = 5280;
    feetPerStep = 2.5f;
    stepsPerMinute = 70.0f;
    calPerMinuteWalking = 3.5f;
    stepsWalked = Convert.ToInt32(Console.ReadLine());
    milesWalked = (float)(stepsWalked * feetPerStep * (1.0 / feetPerMile));
    Console.WriteLine(" Miles walked: ");
    Console.WriteLine(milesWalked);
    Console.WriteLine(" \n ");
    minutesTotal = stepsWalked / stepsPerMinute;
    caloriesTotal = minutesTotal * calPerMinuteWalking;
    Console.WriteLine("Calories: ");
    Console.WriteLine(caloriesTotal);
    Console.WriteLine(" \n ");
    
   
  
    }
  }
}