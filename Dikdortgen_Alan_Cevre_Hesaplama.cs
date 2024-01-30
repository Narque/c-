using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        // STRING DEGISKENLER
        /*static void Main(string[] args)
        {
            string sehir;
            sehir = "Tekirdag";
            string ilce;
            ilce = "Corlu";
            Console.WriteLine(sehir+" "+ilce);
            Console.Read();

        }*/
        static void Main(string[] args)
        {
            //int sayi;
            //sayi = 24;
            //Console.Write(sayi);
            //Console.Read();

            //int sayi1;
            //int sayi2;
            //int toplam;

            //sayi1 = 10;
            //sayi2 = 20;
            //toplam = sayi1 + sayi2;
            //Console.Write(toplam);
            //Console.Read();

            Console.WriteLine("---Dikdörtgenin alanı ve çevresinin hesaplanması---");
            Console.WriteLine("Önce 1. kenarı sonra 2. kenarı girin.");
            Console.WriteLine("1. kenarı girin:");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kenarı Girin:");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            string qenar1 = Convert.ToString(kenar1);
            string qenar2 = Convert.ToString(kenar2);
            Console.WriteLine("Girdiğiniz değerler: " + (qenar1) + " " + (kenar2));
            int alan = kenar1 * kenar2;
            string alann = Convert.ToString(alan);
            int cevre = (2 * (kenar1)) + (2 * (kenar2));
            string cevree = Convert.ToString(cevre);
            Console.WriteLine("Alan: " + alann);
            Console.WriteLine("Cevre: " + cevree);
            Console.WriteLine("Cikmak icin enter'a bas.");
            Console.ReadLine();

        }
    }
}
