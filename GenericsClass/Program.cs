using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var book1 = new Book() { BookId = 1, BookName = "Akhil" };

            //var numbers = new CList<Book>();
            //numbers.Add(book1);

            //var dict = new GenericDictionary<string, Book>();

            //dict.Add(book1.BookName, book1);

            int? a=null;

            Console.WriteLine(a+"  ghj");

            var Number = new Nullable<int>();

            Console.WriteLine(Number.HasValue);

            Console.WriteLine(Number.GetValueDefault());



            
        }
    }
}
