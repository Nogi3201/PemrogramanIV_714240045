using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_02_714240045
{
    public class EBook : Book
    {
        public double FileSizeMB { get; set; }

        public EBook(string title, string author, double fileSize)
            : base(title, author)
        {
            FileSizeMB = fileSize;
        }

        // POLYMORPHISM (Override)
        public override void DisplayInfo()
        {
            Console.WriteLine($"[E-Book] {Title} oleh {Author} - Ukuran File: {FileSizeMB} MB");
        }
    }
}