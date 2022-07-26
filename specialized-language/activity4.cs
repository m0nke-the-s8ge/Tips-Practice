using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
     //Declare Variable
     float pizzaDiameter1;
     float pizzaDiameter2;
     float totalPizzaArea;
     float circleArea1;
     float circleArea2;
     
     
     //Assign Value
     pizzaDiameter1 = 12.0f;
     circleArea1 = CircleArea(pizzaDiameter1);
     pizzaDiameter2 = 14.0f;
     circleArea2 = CircleArea(pizzaDiameter2);
     totalPizzaArea = circleArea1 + circleArea2;
     
     
     Console.WriteLine(" A 12 and 14 inch pizza has ");
	 Console.WriteLine(totalPizzaArea);
	 Console.WriteLine(" inches squared comnbined. ");
     }
     
    static float CircleArea(float circleDiameter)
    {
     //Declare Variables
     float circleRadius;
     float piVal;
     float circleArea;
     
     //Assign Value
     piVal = 3.14159265f;
     circleRadius = circleDiameter / 2.0f;
     circleArea = piVal * circleRadius * circleRadius;
     
     return circleArea;
     
     }
     
     
     
     
     
     
     
     
     
     
     
   
    
  }
}