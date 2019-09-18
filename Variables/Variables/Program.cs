using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
   class Program
   {
      static void Main(string[] args)
      {
         string characterName = "Cena";
         int characterAge = 40;

         Console.WriteLine("There was once a man named " + characterName);
         Console.WriteLine("He was " + characterAge + " years old");

         characterName = "Jones";
         Console.WriteLine("He really liked the name " + characterName);
         Console.WriteLine("But didn't like being " + characterAge);

         Console.ReadLine();
      }
   }
}
