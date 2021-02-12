using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİNQ_SAMPLE
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Ornek1();
            //Ornek2();
            //Ornek3();
            //Ornek4();
            //Ornek5();
            //Ornek6();
            //Ornek7();
            //Ornek8();          
            //Ornek9();
            Ornek10();

            Console.ReadKey();
        }

        private static void Ornek10()
        {
            //Bir string dizisi hazırlanmış ve içerisine elemanlar yerleştirilmiştir."n" karakteri ile başlayan elemanlardan ilk ve son sırada bulunan elemmana ait index değerini ekrana yazan programı oluşturunuz.
            string[] kelimeler = { "rabia", "nermin", "hakan", "neriman", "mehmet", "hayati", "numan", "süleyman" };
            int ilkindeks = kelimeler.ToList().FindIndex(p => p.Substring(0, 1) == "n");
            int sonindeks = kelimeler.ToList().FindLastIndex(p => p.Substring(0, 1) == "n");
            Console.WriteLine("Kelimeler dizisine ait -n- harfi bulunan ilk index:{0} son index:{1} ", ilkindeks, sonindeks);
        }

        private static void Ornek9()
        {
            //Bir string dizisi hazırlanmış ve içerisine elemanlar yerleştirilmiştir.Metin uzunluğu 5 olan elemenların ,şarta ilk uyanı ve son uyanı ekrana yazdıran programı oluşturunuz.
            string[] kelimeler = { "fener", "yobü", "kahve", "gül", "muz", "yeşil", "kare", "bahçe" };
            string ilkKelime = kelimeler.First(p => p.Length == 5);
            string sonKelime = kelimeler.Last(p => p.Length == 5);
            Console.WriteLine("Kelimeler dizisinde 5 karakterli ilk kelime: {0}, son kelime: {1}", ilkKelime, sonKelime);
        }

        private static void Ornek8()
        {
            //List koleksiyonu içerisine tanımlanmış string tipindeki metinleri, metin uzunluğuna göre küçükten büyüğe doğru sırala
            List<string> metin = new List<string> { "Rabia Nur Kavi", "Büşra Kavi Yurdakul", "Hakan Kavi", "Yusuf Yurdakul", "Canan Kalyoncu", "Şükran Kalyoncu", "Yasemin Işık", "Zeynep Kılıç Işık" };
             (from p in metin
                          orderby p.Length
                          select p).ToList().ForEach(p => Console.WriteLine("Metin: " + p + " " + "Karakter Sayısı: " + p.Length));
          
        }

        private static void Ornek7()
        {
            //string değişkene tanımlanmış metinin tüm karakterlerini alt alta yazdıran programı oluşturun
            string metin = "RABİA NUR KAVİ";
            metin.ToList().ForEach(p => Console.WriteLine(p));
        }

        private static void Ornek6()
        {
            //List koleksiyonu içerisindeki sayıları büyükten küçüğe doğru sıralayan 70 ile 30 arasındaki sayıları yazdıran program kodu
            List<int> liste = new List<int> { 8, 12, 45, 26, 31, 48, 51, 1202, 1402, 987, 62, 9, 71, 1423 };
            var result = (from p in liste.Where(p => p > 30 && p < 70).OrderByDescending(p => p)
                          select p).ToList();
            foreach (var linq in result)
            {
                Console.WriteLine(linq);
            }
        }

        private static void Ornek5()
        {
            //List koleksiyonu içerisindeki sayıları küçükten büyüğe doğru sıralayan kodlar
            List<int> liste = new List<int> { 8, 12, 45, 26, 31, 48, 51, 1202, 1402, 987, 62, 9, 71, 1423 };
            var result = liste.OrderBy(p => p).ToList();
            foreach (var linq in result)
            {
                Console.WriteLine(linq);
            }
        }

        private static void Ornek4()
        {
            //List koleksiyonu içerisinde hem 3 hem 5 e bölünen sayıların aritmetik ortalamasını veren kodlar
            List<int> liste = new List<int> { 8, 12, 45, 26, 31, 48, 51, 1202, 1402, 987, 62, 9, 71, 1423 };
            double result = (from p in liste.Where(p => p % 3 == 0 && p % 5 == 0)
                             select p).Average();//Average fonksiyonu 1 30 arasında sayıların aritmetik ortalamasını alır.
            Console.WriteLine(result);
        }

        private static void Ornek3()
        {
            //List koleksiyonu içerisinde tek olan sayıların 2 katının 4 eksiğini bulan sayıları ekrana yazdıran kod.
            List<int> liste = new List<int> { 8, 12, 45, 26, 31, 48, 51, 1202, 1402, 987, 62, 9, 71, 1423 };
            var result = (from p in liste.Where(p => p % 2 == 1)
                          select p * 2 - 4).ToList();
            foreach (var linq in result)
            {
                Console.WriteLine(linq);
            }
        }

        private static void Ornek2()
        {
            //List koleksiyonu içerisinde tanımlanmış integer tiplindeki sayıların tek olanların adetini ekrana yazdıran kodları oluşturunuz.

            List<int> liste = new List<int> { 8, 12, 45, 26, 31, 48, 51, 1202, 1402, 987, 62, 9, 71, 1423 };
            var result = liste.Where(p => p % 2 == 1).Count();
            Console.WriteLine("Listenin içinde bulunan tek sayıların sayısı: {0} ", result);
        }

        private static void Ornek1()
        {    //List koleksiyonu içerisinde tanımlanmış integer tiplindeki sayıların çift olanlarını ekrana yazdıran kodları oluşturunuz.

            List<int> liste = new List<int> { 8, 12, 45, 26, 31, 48, 51, 1202, 1402, 987, 62 };
            var result = liste.Where(p => p % 2 == 0).ToList();
            foreach (var linq in result)
            {
                Console.WriteLine(linq);
            }
        }
    }
}
