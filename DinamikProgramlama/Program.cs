using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {

            //dinamik programlama geliştirme aşamasında değil de runtime (proje çalışmaya başladığı anda dinamik programlama işleri çalıştırılır) için de kullanılan şeydir.

            dynamic a = 5;
            Console.WriteLine(a);

            a = "AA";
            Console.WriteLine(a);
            dynamic insan = new ExpandoObject();//kütüphane (using System.Dynamic)ekledik bunu kullanarak bir nesne ürettik.
            insan.Ad = "Rabia Nur";//ad ve soyadları kendim nokta yazdıktan sonra elle yazdım.Herhangi bir tip(type) tanımı bulunmamaktır.Console.WriteLine a yazarken de . dan sonra bir şey çıkmaz
            insan.Soyad = "Kavi";
            Console.WriteLine(insan.Ad + " " + insan.Soyad);//bunların hiç biri yok program çalışmaya başladıktan sonra değerler atanacak ve ondan sonra yazdıracak.Eğer belirtmediğimiz yani atamadığımız bir method(Ad,Soyad) dışında bir şey yazdıracaksak hata verir.

            dynamic kisi = new ExpandoObject();
            kisi.Ad = "Hakan";
            kisi.Soyad = "Kavi";
            kisi.AdGoster = new Action(() =>//Method belirtmek için. Action geriye değer döndürmeyen geliştirilmiş delegate
            {
                Console.WriteLine("Ad: " + kisi.Ad);
            });

            kisi.TekrarEt = new Func<string, string>(gelen =>
            {
                return gelen;
            });//func değer döndürdüğü için return kullanılmak zorunda
            //Çalıştırma İşlemleri
            kisi.AdGoster();
            dynamic sonuc = kisi.TekrarEt("Çoklu Tekrar");
            Console.WriteLine("Gelen Cevap: " + sonuc);

            //aşağıdakiler class ve methhod için

            foreach (dynamic user in GetList())
            {
                Console.WriteLine("{0}  {1} ", user.Ad, user.Soyad);//user.FirstName user.LastName yazarsak hata verir çünkü geriye dönme yerinde Ad ve Soyada çevirdik.
            }
            Console.ReadLine();

        }
        private static IEnumerable<dynamic> GetList()
        {
            var users = new List<User>
            {
                new User() { Id = 1, FirstName = "Büşra", LastName = "Kavi Yurdakul" },
                new User() { Id = 2, FirstName = "Yusuf", LastName = "Yurdakul" }
            };
            return from k in users
                   select new { Ad = k.FirstName, Soyad = k.LastName };//LİNQ kullanıldı
        }
    }
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
