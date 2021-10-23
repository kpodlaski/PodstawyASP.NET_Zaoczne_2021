using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Intro
{
    class Book : IComparable<Book>
    {
        private static int lastId = 0;
        public int ID { private set; get; }
        public String Title;
        public Author Author;

        public Book(String title, Author author)
        {
            this.Title = title;
            this.Author = author;
            ID = lastId++;
        }

        public override String ToString()
        {
            return ID+":: "+ Author + ": " + Title;
        }

        public int CompareTo(Book other)
        {
            //sortowanie po ID malejąco
            return other.ID - ID ;
            
        }
    }

    class ComparerBooksByTitle : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            //sortowanie po tytule, alfabetycznie
            return x.Title.CompareTo(y.Title);
        }
    }
}
