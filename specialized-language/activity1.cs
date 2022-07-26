using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
     //Declare Variable
     int stepsWalked;
     
     stepsWalked = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(" Miles walked: ");
	 Console.WriteLine( StepsToMiles(stepsWalked));
	 Console.WriteLine(" \n ");
     Console.WriteLine(" Calories: ");
	 Console.WriteLine(StepsToCalories(stepsWalked));
	 Console.WriteLine(" \n ");
    }
    static float StepsToMiles(int numSteps)
    {
     //Declare Variable
     float feetPerStep;
     int feetPerMile;
     float milesTotal;
     
     //Assign Value
     feetPerMile = 5280;
     feetPerStep = 2.5f;
     milesTotal = (float)(numSteps * feetPerStep * (1.0/feetPerMile));
     
     return milesTotal;
    }


    static float StepsToCalories(int numSteps)
    {
     //Declare Variable
     float stepsPerMinute;
     float calPerMinuteWalking;
     float minutesTotal;
     float caloriesTotal;
     
     //Assign Value
     stepsPerMinute = 70.0f;
     calPerMinuteWalking = 3.5f;
     minutesTotal = (float)(numSteps / stepsPerMinute);
     caloriesTotal = minutesTotal * calPerMinuteWalking;
     
     return caloriesTotal;
     
     
     
     
     
     
     
      }
  }
}