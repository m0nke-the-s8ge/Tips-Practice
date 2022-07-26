using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
     PrintPizzaVolume(12.0f, 0.3f);
     PrintPizzaVolume(12.0f, 0.8f);
     PrintPizzaVolume(16.0f, 0.8f);
     }
     
     
     static void PrintPizzaVolume(float pizzaDiameter, float pizzaHeight)
     {    
      //Declare Variables
      float piVal;
      float pizzaRadius;
      float pizzaArea;
      float pizzaVolume;
      
      //Assign Value
      piVal = 3.14159265f;
      pizzaRadius = pizzaDiameter / 2.0f;
      pizzaArea = piVal * pizzaRadius * pizzaRadius;
      pizzaVolume = pizzaArea * pizzaHeight;
      
      Console.WriteLine(pizzaDiameter);
      Console.WriteLine(" x ");
      Console.WriteLine(pizzaHeight);
      Console.WriteLine(" inch pizza is ");
      Console.WriteLine(pizzaVolume);
      Console.WriteLine(" inches cubed.\n");


    }
  }
}