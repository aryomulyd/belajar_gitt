using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalculationConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih Menu Calculator); \n");

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("\nInput Nomor Menu [1 . 4] : ");
            int menu = int.Parse(Console.ReadLine());

            //int a = 10;
            //int b = 6;

            Console.Write("Inputkan nilai a =");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b =");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian (a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian (a, b));

            Console.WriteLine("\nTeken sembarang key untuk keluar");
            Console.ReadKey();

        }
        static int Penambahan(int a, int b)
        { 
            return a + b;
            }
    static int Pengurangan(int a, int b)
    {
        return a - b;
        
    }
        //TODO: tambahkan method untuk Perkalian dan Pembagian
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}

