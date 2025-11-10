using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_02_714240045
{
    public class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string title, string author, int pages)
            : base(title, author)
        {
            PageCount = pages;
        }

        // POLYMORPHISM (Override)
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Buku Cetak] {Title} oleh {Author} - {PageCount} halaman");
        }
    }
}