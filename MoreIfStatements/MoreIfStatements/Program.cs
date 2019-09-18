using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreIfStatements
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine(GetMax(20, 10, 40));

         Console.ReadLine();
      }

      static int GetMax(int num1, int num2, int num3)
      {
         int result;

         if (num1 >= num2 && num1 >= num3)
         {
            result = num1;
         }
         else if(num2 >= num1 && num2 >= num3)
         {
            result = num2;
         }
         else
         {
            result = num3;
         }

         return result;
      }

      /*static int GetMax(int num1, int num2)
      {
         int result;

         if (num1 > num2)
         {
            result = num1;
         }
         else
         {
            result = num2;
         }

         return result;
      }*/
   }
}
//Here we focus on comparisons in if statements
// comparison operators >= (greater or equals to) 
// >(greater than) <(less than) 
// <=(less than or equals to) or ==(equals to)
// a single equals(=) is used to assign
