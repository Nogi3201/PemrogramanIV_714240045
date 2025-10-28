using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714240045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====arithmetic operators=====");

            Console.WriteLine("masukkan angka 1: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("masukkan angka 2: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());


            double penjumlahan;

            penjumlahan = angka1 + angka2;
            Console.WriteLine($"{angka1} + {angka2} = {penjumlahan}" );

            double pengurangan;

            pengurangan = angka1 - angka2;
            Console.WriteLine($"{angka1} - {angka2} = {pengurangan}");

            double perkalian;

            perkalian = angka1 * angka2;
            Console.WriteLine($"{angka1} * {angka2} = {perkalian}");

            double pembagian;

            pembagian = angka1 / angka2;
            Console.WriteLine($"{angka1} / {angka2} = {pembagian}");
        }
    }
}
