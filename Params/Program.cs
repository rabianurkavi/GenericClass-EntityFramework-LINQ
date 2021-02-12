using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{//bazen kaç değişken vereceğimizi bilemediğimiz zamanlar olur bunlar için params kullanırız.
    class Program
    {
        static int Toplam(params int[] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            int toplam = 0;
            foreach (int sayi in sayilar)
                toplam += sayi;
            return toplam;
        }
        static double Cikarma(double x,params double [] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            double cikartma = 0;
            foreach (double sayi in sayilar)
                cikartma -= sayi;
            return cikartma;
        }
        static double Cikarma(double x,double y)
        {
            double cikartma = 0;

              cikartma = x - y;
            return cikartma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(9, 8, 10, 30, 40));
            Console.WriteLine(Toplam(3500, 2541));
            Console.WriteLine(Toplam(8510, -96, 32569));
            Console.WriteLine(Cikarma(91, 12, 3));//params için
            Console.WriteLine(Cikarma(84, 12));//çıkartma için
            Console.ReadKey();
        }
    }
}
