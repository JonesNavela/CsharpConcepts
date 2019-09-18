using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingUserInput
{
   class Program
   {
      static void Main(string[] args)
      {

         Console.Write("Enter your name: ");
         string name = Console.ReadLine();

         Console.WriteLine("Hello " + name);

         Console.Write("How old are you turning this year? ");
         string age = Console.ReadLine();

         Console.WriteLine("wow " + name + " turning " + age + " is cool");

         Console.Write("So i wanted to ask, do you know that God loves you? ");
         string answer = Console.ReadLine();

         Console.Write("Great, since you said " + answer + ", please share that truth with everyone you know and may not know. :) ? ");
         string canShare = Console.ReadLine();

         Console.WriteLine("Awesome may God bless you for saying " + canShare + " to sharing!" );

         Console.ReadLine();

      }
   }
}
