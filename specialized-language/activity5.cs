using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
     PrintPizzaArea(12);
     }
     
     static void PrintPizzaArea(float pizzaDiameter)
     {
      //Declare Variable
      float piVal;
      float pizzaRadius;
      float pizzaArea;
      
      //Assign Value
      piVal = 3.14159265f;
      pizzaRadius = pizzaDiameter / 2.0f;
      pizzaArea = piVal * pizzaRadius * pizzaRadius;
      
      Console.WriteLine(pizzaDiameter);
      Console.WriteLine(" in. pizza is ");
      Console.WriteLine(pizzaArea);
      Console.WriteLine(" sq. in.\n ");
      }


    }
  }
