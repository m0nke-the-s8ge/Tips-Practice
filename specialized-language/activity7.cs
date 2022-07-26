using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
    //Declare Variable
    double sellingPrice;
    
    sellingPrice = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("eBay fee: $");
    Console.WriteLine(EbayFee(sellingPrice));
    }
    
    
   static double EbayFee(double sellPrice)
   {
   //Declare Variables 
   double feeTotal;
   
   // Base listing fee
   feeTotal = 0.50f;
   
   if (sellPrice <= 50.00){
    feeTotal = (double)feeTotal + (sellPrice * 0.13);
   }
   	// $50.00 or lower
   else if (sellPrice <= 1000.00) {
    feeTotal = (double)feeTotal + (50 * 0.13);
    feeTotal = (double)feeTotal + ((1000 - 50) * 0.05);
    feeTotal = (double)feeTotal + ((sellPrice - 1000) * 0.02);
   }
   	// $50.01..$1000.00
    
   return feeTotal;
   }
  }
}