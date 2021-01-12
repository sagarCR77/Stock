using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
       
       Stock test = new Stock("Test Stock Item1", 100);

       test.PrintSummary(); // tell the stock object to print
       test.AddStock(20);  // Add stock
       test.PrintSummary();  // printing the object again

       test.PrintSummary();
       test.RemoveStock(20); // Remove the stock
       test.PrintSummary();

       Stock test1 = new Stock("Test Stock Item2", 200); // second stock object


       test1.PrintSummary();
       test1.AddStock(20); 
       test1.PrintSummary();

       test1.PrintSummary();
       test1.RemoveStock(10);
       test1.PrintSummary();
      

        
    }
}

