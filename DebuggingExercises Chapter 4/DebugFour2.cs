// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order
// in reverse order
// or in neither order
using System;
using System.Console;
class DebugFour2
{
   static void Main()
   {
       int num1, num2, num3;
      string snum1, snum2, snum3;
      Console.Write("Enter first number ");
      snum1 = Console.ReadLine();
      num1 = Convert.ToInt32(snum1);
      Console.Write("Enter second number ");
      snum2 = Console.ReadLine();
      num2 = Convert.ToInt32(snum2);
      Console.Write("Enter third number ");
      snum3 = Console.ReadLine();
      num3 = Convert.ToInt32(snum3);
      if(num1 > num2 && num2 <= num3)
          Console.WriteLine("Numbers are in sequential order");
      else
         if(num1 < num2 && num2 == num3)
             Console.WriteLine("Numbers are in reverse order");
         else
             Console.WriteLine("Numbers are in neither sequential nor reverse order");
   }
}
