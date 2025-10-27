﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714240045
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("MENENTUKAN INDEKS PRESTASI MAHASISWA\n---------------------------");
                Console.Write("\nMasukkan Nama Mahasiswa : ");

                string nama = Console.ReadLine();

                Console.WriteLine("Masukkan Nilai : ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.WriteLine("\nMasukkan indeks yang ditampilkan :");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks prestasi {0} adalah",nama);

                prestasi(indeks);

                Console.Write("\nIngin mengulang kembali (y/n) ? ");
            }
            while (Console.ReadLine() == "y");
        }
        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.Write("sangat baik");
                    break;
                case 'B':
                    Console.Write("baik");
                    break;
                case 'C':
                    Console.Write("Cukup");
                    break;
                case 'D':
                    Console.Write("buruk");
                    break;
                default:
                    Console.Write("Indeks yang anda masukkan salah");
                    break;
            }
        }
    }
}
