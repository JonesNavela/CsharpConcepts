using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
   class Program
   {
      static void Main(string[] args)
      {
         Book book1 = new Book();
         book1.title = "Harry Potter";
         book1.author = "JK Rowling";
         book1.pages = 400;

         Book book2 = new Book();
         book2.title = "Learning C#";
         book2.author = "Udemy";
         book2.pages = 900;

         
         Console.ReadLine();
      }
   }
}
