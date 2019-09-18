using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingAGuessingGame
{
   class Program
   {
      static void Main(string[] args)
      {
         string secretWord = "victory";
         string guess = "";
         int guessCount = 0;
         int guessLimit = 3;
         bool outOfGuesses = false;

         while( guess != secretWord && !outOfGuesses)
         {
            if (guessCount < guessLimit) 
            {
               Console.Write("Enter guess: ");
               guess = Console.ReadLine();
               guessCount++;
            }
            else
            {
               outOfGuesses = true;
            }
            
         }

         if (outOfGuesses)
         {
            Console.Write("You LOSE!");
         }
         else
         {
            Console.Write("You WIN!");
         }
         

         Console.ReadLine();
      }
   }
}
// challenge, do a do while loop for this
