using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, bolum, program;
            int s1, s2, s3, ort;

            ad ="Emre";
            bolum ="Mekatronik";
            program ="Sayisal Elektronik";

            s1 = 23;
            s2 = 31;
            s3 = 52;
            ort = (s1 + s2 + s3) / 3 ;
            Console.WriteLine("Adi:"+ ad );
            Console.WriteLine("Bolumu:" + bolum);
            Console.WriteLine("Ders" + program);
            Console.WriteLine();
            Console.WriteLine("Birinci Sinav:" + s1 );
            Console.WriteLine("İkinci Sinav:" + s2 );
            Console.WriteLine("Ucuncu Sinav:" +  s3);
            Console.WriteLine("Ortalama:" + ort);
            Console.ReadLine();

        }
    }
}
