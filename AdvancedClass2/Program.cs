using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLİST<string> liste = new MyLİST<string>();
            liste.Ekle("iSTANBUL");
            liste.Ekle("Ankara");
            Console.WriteLine("Eleman sayı: " + liste.ElementSayi);
            Console.ReadLine();
                
        }
    }
   
    class MyLİST<T>
    {
        T[] dizi;
        public void Ekle(T deger)
        {
            try
            {
                T[] geciciDizi = new T[dizi.Length];
                geciciDizi = dizi;
                dizi = new T[geciciDizi.Length + 1];
                for (int i = 0; i < geciciDizi.Length; i++)
                {
                    dizi[i] = geciciDizi[i];

                }
                dizi[dizi.Length - 1] = deger;
            }

            catch
            {
                dizi = new T[1];
                dizi[0] = deger;
            }
        }
        public int ElementSayi
        {
            get { return dizi.Length; }
        }
    }
}
