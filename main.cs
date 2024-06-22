using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    
    double[] temps = new double [5];
    Console.WriteLine("Enter five temperatures: ");

    //requests input for 5 numbers and eneures a. alid number is entered before moving to the next number
    for(int i = 0; i < temps.Length; i++)
    {
      Console.Write("Enter temperature {0}: ", i+1);
      temps[i] = IsInputNumber.GetDouble(Console.ReadLine()) ?? 0;
      
      //request input until a number between -30 an 130 is entered
      while(temps[i] < -30 || temps[i] > 130)
      {
        Console.WriteLine("{0} is an invalid temperatue. Please enter a temperature between -30 and 130.", temps[i]);

        Console.Write("Enter temperature {0}: ", i+1);
        temps[i] = IsInputNumber.GetDouble(Console.ReadLine()) ?? 0;
      }
    }
    Console.WriteLine();
    //creates a copy of inputted temps sorted in ascending and decending order then checks if the order is the same as the original 
    double[] ascendingTemps = new double[5];
    temps.CopyTo(ascendingTemps, 0);
    Array.Sort(ascendingTemps);

    double[] descendingTemps = new double[5];
    temps.CopyTo(descendingTemps, 0);
    Array.Sort(descendingTemps);
    Array.Reverse(descendingTemps);

    if(ascendingTemps.SequenceEqual(temps))
      Console.WriteLine("Getting warmer");
    else if(descendingTemps.SequenceEqual(temps))
      Console.WriteLine("Getting cooler");
    else
      Console.WriteLine("It's a mixed bag");

    //prints the temperatures in the entered order and the average
    Console.WriteLine("5-Day Temperature: [{0}, {1}, {2}, {3}, {4}]", temps[0], temps[1], temps[2], temps[3], temps[4]);

    Console.WriteLine("Average temperature is {0} degrees", temps.Sum()/5);
  }
}