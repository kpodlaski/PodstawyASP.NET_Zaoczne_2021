using System;
using System.Collections.Generic;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biblioteka");
            Author author = new Author("Adam", "Mickiewicz");
            Author author2 = new Author("Juliusz", "Słowacki");
            List<Book> books = new List<Book>();

            Book book = new Book("Pan Tadeusz", author);
            books.Add(book);
            Console.WriteLine(book);
            //Book book1 = new Book("Dziady cz. III", author);
            //Console.WriteLine(book1);
            books.Add(new Book("Dziady cz. III", author));
            book = new Book("Wiersze", author);
            books.Add(book);
            books.Add(new Book("Kordian", author2));
            //Console.WriteLine(book.ID);
            Console.WriteLine(book);
            Console.WriteLine("==================");
            for (int i=0; i<books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }

            Console.WriteLine("==================");
            books.Sort();
            books.Sort(new ComparerBooksByTitle());
            foreach( Book b in books)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("==================");
            author2 = new Author("Juliusz", "Słowacki");
            foreach (Book b in books)
            {
                if (b.Author.Equals(author2))
                    Console.WriteLine(b);
            }

        }
    }
}
