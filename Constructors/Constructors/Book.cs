using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
   class Book
   {
      public string title;
      public string author;
      public int pages;

      public Book()
      {
         Console.WriteLine();
      }
   }
}
//Constructors are special methods inside a class that will get called when we create an object of that class