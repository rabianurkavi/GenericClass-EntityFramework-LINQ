using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsiyonelveNamedParametreler
{
    class Program
    {
        //opsiyonel(optional)parametreler
        public static void Method(string a,string b=" Rabia",int c=21)
        {
            Console.WriteLine(" {0}={1} yaş={2} ", a, b, c);
        }
       
        
        static void Main(string[] args)
        {  
            //3 yazdırma şeklide kullanılabilir.
            Method("Çalışan ");
            Method("Çalışan ", " Hakan");
            Method("Çalışan ", " Hakan", 22);
            //peki method("Çalışan",24); yani ortadaki parametreyi atlayıp direkt yaşı değiştirmek istersem ne yapacağız?(named parametreler)
            Method("Çalışan ", c:24);//böyle yapmak mümkündür
            Method(c: 24, a: "Müdür   ", b: " Büşra");


            Console.ReadLine();

        }
    }
}
