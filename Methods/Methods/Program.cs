﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   class Program
   {
      static void Main(string[] args)
      {
         
         SayHi("Jones", 22);
         SayHi("Thembela", 23);
         Console.ReadLine();

      }

      static void SayHi(string name, int age)
      {
         Console.WriteLine("Hello " + name + " you are " + age);
      }
   }
}
