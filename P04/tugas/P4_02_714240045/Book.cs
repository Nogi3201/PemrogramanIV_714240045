using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_02_714240045
{
    public abstract class Book
    {
        // ENCAPSULATION: private field + public property
        private string title;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // CONSTRUCTOR
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        // ABSTRACT METHOD (Polymorphism)
        public abstract void DisplayInfo();
    }
}