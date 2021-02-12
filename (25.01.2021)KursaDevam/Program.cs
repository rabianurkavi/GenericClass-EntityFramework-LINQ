using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01._2021_KursaDevam
{//advanced class
    class Program
    {
        static void Main(string[] args)
        {
            //  Liste liste = new Liste();
            /*Liste<decimal> liste = new Liste<decimal>();//Çıktımız System.Decimal olur.Tipini yazdırır.
            Console.ReadLine();*/
            Liste<string> liste = new Liste<string>();
            liste.Add("Ali");
            liste.Add("Veli");
            liste.Get();
            Console.ReadKey();


                
        }
    }
    //sınıfların aşırı yüklemesini göreceğiz
    class Liste
    {

    }
    /*class Liste<T> //CLASS OVERLOADİNG Burdaki t type anlamına gelir
    {
        public Liste()
        {
            Console.WriteLine(typeof(T));
        }
    } */
   class Liste<T>
    {
        List<T> liste = new List<T>();
        public void Add(T ticin)
        {
            liste.Add(ticin); 
        }
        public void Get()
        {
            foreach (var t in liste)
            {
                Console.WriteLine("t -> " + t);
            }
        }
    }
}
