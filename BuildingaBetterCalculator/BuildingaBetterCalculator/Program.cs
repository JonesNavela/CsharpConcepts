using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingaBetterCalculator
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Enter a number: ");
         double num1 = Convert.ToDouble(Console.ReadLine());

         Console.Write("Enter Operator: ");
         string op = Console.ReadLine();

         Console.Write("Enter another number: ");
         double num2 = Convert.ToDouble(Console.ReadLine());

         if (op == "+")
         {
            Console.WriteLine(num1 + num2);
         }

         else if (op == "-")
         {
            Console.WriteLine(num1 - num2);
         }

         else if (op == "/")
         {
            Console.WriteLine(num1 / num2);
         }

         else if (op == "*")
         {
            Console.WriteLine(num1 * num2);
         }
         else
         {
            Console.WriteLine("bummer! You either entered a non existant operator or the world is ending");
         }

         Console.ReadLine();
      }
   }
}
// Figure out how to have an error message pop up when a string is entered in the number position