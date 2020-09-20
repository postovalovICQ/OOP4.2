using System;

namespace oop4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Книга");
            Book book = new Book();
            book.Year = 6666;
            Console.WriteLine($"Максимум: { book.Year} год");
            book.Year = 666;
            Console.WriteLine($"Минимум: { book.Year} год");
            book.Year = 2010;
            Console.WriteLine($"Ваша книга: { book.Year} года");
            Console.ReadKey();
        }
        class Book
        {
            private int year;
            public int Year
            {
                get
                {
                    return year;
                }

                set
                {
                    if (value > 2020)
                        year = 2020;
                    else if (value < 1940)
                        year = 1940;
                    else year = value;
                }
            }
        }
    }
}
