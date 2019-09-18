using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
   class Program
   {
      static void Main(string[] args)
      {
         int index = 1;
         while (index <= 5) 
         {
            Console.WriteLine(index);
            index++;
         }

         Console.ReadLine();
      }
   }
}
// While loops is a programming structure that allows us to loop over a specific block of code repeatedly while a certain condition is true until its false.
// infinite loop error happens when we remove the index++