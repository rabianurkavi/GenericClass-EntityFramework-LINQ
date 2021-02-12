using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_ve_Func
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Action
            /* Geriye değer döndürmeyen (void) methodlar için kullanılır.
             * delegate in geriye değer döndürmeyen dark net framework versiyonudur.

            */
            Action<int, string> action = new Action<int, string>(KullaniciBilgi);
            action(5, "Rabia Nur Kavi");
            // metotları public yapınca hata veriyor.
            //Func
            /* Geriye değer dönebilen Action versiyonudur.Ya da deleagtes versiyonudur. */
            Func<DateTime, double> func = new Func<DateTime, double>(GetUserAgeATTime);

            double dateDiff = func(new DateTime(2000, 2, 4));
            Console.WriteLine(dateDiff +" "+"gündür yaşıyorsunuz.");

            Console.ReadLine();

        }
        static void KullaniciBilgi(int kullaniciId,string adSoyad)
        {
            Console.WriteLine("Kullanici Id: " + kullaniciId);
            Console.WriteLine("Ad Soyad: " + adSoyad);


        }
        static double GetUserAgeATTime(DateTime birthDate)
        {
            return (DateTime.Now - birthDate).TotalDays;
        }
    }
}
