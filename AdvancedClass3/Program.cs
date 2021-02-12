using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler<double> sinif = new Islemler<double>();
            double sonuc = sinif.IslemYap(5.40, 5);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
    class Islemler<T>
    {
        public T IslemYap(T ticin,int param)
        {
            if(param>=0)
            {
                return ticin;
            }
            else
            {
                return default(T);//doubleın default değeri 0dır.
            }
        }
    }
}
