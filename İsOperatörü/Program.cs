using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsOperatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            object bakiye = 100;
            if(bakiye is null)
            {
                return;
            }
            Console.WriteLine(bakiye);
            if(bakiye is decimal kullaniciBakiyesi)
            {      
                Console.WriteLine("Kullanıcının bakiyesi" + kullaniciBakiyesi);
            }
            Console.ReadLine();
        }
    }
}
