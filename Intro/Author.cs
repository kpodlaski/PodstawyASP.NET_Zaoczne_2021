using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    class Author
    {
        public String Name;
        public String Surname;

        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            return obj is Author author &&
                   Name == author.Name &&
                   Surname == author.Surname;
        }

        public override string ToString()
        {
            return Name + " "+ Surname;
        }

        
    }
}
