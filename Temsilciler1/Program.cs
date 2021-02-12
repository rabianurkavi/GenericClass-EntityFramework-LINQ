using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temsilciler1
{
    class Program
    {//Temsilcilerin amacı bir ya da birden fazla methodu temsil etmektir yani işaret bir pointerdır.
        static void Main(string[] args)
        {
              Hesap hesap = Topla;//senin adın hesap olacak ve sen topla adında bir methodu temsil edeceksin.
               int sonuc = hesap(5, 4);
               Console.WriteLine("Topla: " + sonuc);
               hesap = Carp;
               Console.WriteLine("Carp: " + hesap(5, 4));       
               hesap = Cıkar;
               Console.WriteLine("Cıkar: " + hesap(5, 20));
               hesap = Bol;
               Console.WriteLine("Bol: " + hesap(5, 1));
               //delegateslerin yerleride çok önemlidir atadıktan sonra yazılan methodun çıktı yazılımını hemen ardından yazmamız gerekir.
           
            Hesap hesabı = new Hesap(Topla);
            Console.WriteLine("Topla: " + hesabı(5,4));
            hesabı = new Hesap(Cıkar);
            Console.WriteLine("Cıkar: " + hesabı(5, 4));
            //Bu şekilde de yazılabilir.

            Hesap hesapet = new Hesap(Topla);
            int sonucu = hesap.Invoke(4, 4);
            Console.WriteLine(sonucu);
            //bir değer kullanım ınvoke da kendi içerisindeki referansı çağırıyor(ınvoke=çağırmak)
            Console.ReadLine();
                
        }
   
        delegate int Hesap(int x, int y);//delegate tanımı
        //burada dikkat edilmesi gereken bir diğer şey de imzasının yani değişken tipinin aynı olması gerektiğidir.

        static int Topla(int a,int b)
        {
            return a + b;
        }
        static int Cıkar(int a, int b)
        {
            return a - b;
        }
        static int Carp(int a, int b)
        {
            return a * b;
        }
        static int Bol(int a, int b)
        {
          if (a > 0 && b > 0)
        {
            return a / b;
        }
        return 0;
        }
    }     
}
