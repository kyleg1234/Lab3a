using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");
    var x = Console.ReadLine();
 double num1 = Convert.ToDouble(x);

Console.Write("Farenheit equivalent for ");
    Console.Write(num1 );
    Console.Write(" degree celsius is ");
Console.WriteLine(num1*9/5+32);
if (num1<32)
{
Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
  }
   if (num1>=100)
   {
   Console.WriteLine(" This temperature is above boiling point of 212 degree Farenheit");  
   
   }
    

  }
}