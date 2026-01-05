using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_02_714240045
{
    class Program
    {
        static void Main(string[] args)
        {
            Book printed = new PrintedBook("Laskar Pelangi", "Andrea Hirata", 550);
            Book ebook = new EBook("Atomic Habits", "James Clear", 2.5);

            printed.DisplayInfo();
            ebook.DisplayInfo();

            Console.ReadKey();
        }
    }
}
