using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240045
{
    class Program
    {
        // Metode pilihan 1 untuk menghitung hitung Luas
        static void HitungLuas()
        {
            
                if (TryGetInput("Masukkan Panjang: ", out double panjang) &&
                    TryGetInput("Masukkan Lebar: ", out double lebar))
                {
                    double luas = panjang * lebar;
                    Console.WriteLine($"Luas Persegi Panjang: {luas}");
                }
       
        }

        // Metode pilihan 2 untuk menghitung hitung Keliling
        static void HitungKeliling()
        {
            
            if (TryGetInput("Masukkan Panjang: ", out double panjang) &&
                TryGetInput("Masukkan Lebar: ", out double lebar))
            {
                double keliling = 2 * (panjang + lebar);
                Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
            }
        }

        static bool TryGetInput(string prompt, out double result)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out result))
            {
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("[ERROR] Input harus angka positif.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("[ERROR] Input tidak valid. Harap masukkan angka.");
                return false;
            }
        }

        // Metode Utama Program
        static void Main(string[] args)
        {
            string ulangiProgram = "Y";

            bool keluarProgram = false;

            do
            {
                // Tampilkan menu
                Console.WriteLine("=== Menu Persegi Panjang ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");

                // Minta pengguna memilih opsi
                Console.Write("pilih menu (1-3):");
                string input = Console.ReadLine();

                keluarProgram = false;

                // Proses input pengguna
                switch (input)
                {
                    case "1":
                        // untuk memanggil fungsi hitung luas
                        HitungLuas();
                        break;
                    case "2":
                        //untuk memanggil fungsi hitung keliling
                        HitungKeliling();
                        break;
                    case "3":
                        Console.WriteLine("\nProgram selesai.");
                        Console.WriteLine("\nTerima Kasih!");
                        keluarProgram = true;
                        break;
                    default:
                        Console.WriteLine("\nMenu tidak tersedia.Silakan pilih menu yang valid");
                        break;

                }

                if(keluarProgram)
                {
                    // Jika opsi 3 dipilih, loop berhenti
                    ulangiProgram = "T";
                }
                else if (input == "1" || input == "2")
                {
                    // Jika opsi 1 atau 2 dipilih, tanyakan konfirmasi pengulangan
                    Console.Write("\nIngin mengulang kembali? (Y/T): ");
                    // Baca input dan ubah ke huruf besar (Uppercase)
                    ulangiProgram = Console.ReadLine().ToUpper();
                }
              

            }
            // Kondisi untuk melanjutkan loop
            while (ulangiProgram == "Y");

            // Tambahkan jeda agar konsol tidak langsung tertutup saat program benar-benar selesai
            Console.WriteLine("\nTekan tombol apa saja untuk menutup...");
            Console.ReadKey();
        }
    }

 }