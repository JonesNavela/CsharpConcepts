using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandObjects
{
   class Program
   {
      static void Main(string[] args)
      {
         Book book1 = new Book();
         book1.title = "Harry Potter";
         book1.aurthor = "JK Rowling";
         book1.pages = 400;

         Book book2 = new Book();
         book2.title = "Learning C#";
         book2.aurthor = "Udemy";
         book2.pages = 300;

         Console.WriteLine(book1.pages);

         Console.ReadLine();
      }
   }
}
