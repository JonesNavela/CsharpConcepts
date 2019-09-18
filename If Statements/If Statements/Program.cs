using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
   class Program
   {
      static void Main(string[] args)
      {
         bool isMale = false;
         bool isTall = false;

         if(isMale && isTall)
         {
            Console.WriteLine("You are male and tall");
         } else if (isMale && !isTall)
         {
            Console.WriteLine("You are male but not tall");
         } else if (!isMale && isTall)
         {
            Console.WriteLine("You are not male but you are tall");
         }
         else
         {
            Console.WriteLine("You are not male and not tall");
         }
         
         Console.ReadLine();
      }
   }
}
//if statements allow us to do different things when different conditions are met.
// with && both conditions have to be true in order to execute the code in the if statement. if one is false, they all false and the else statement will be executed
// with || only one of the conditions have to be true to execute the code in the if statement.