using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gneişletme_Metodları_Extension_Methods_
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj1 = new object();
            obj1 = new Program();
            //öyle bir şey yapayım ki bana bu object nesnesi ile ilgili assembly(yazamadım :( ) bir şey versin.
            obj1.DisplayAssemblyInfo();

            //square öethodu ,.,n
            int x = 6;
            Console.WriteLine(x.Square());

            //listeleme için kullanılacak extension
            ArrayList list = new ArrayList();
            list.Add("Rabia");
            list.Add("Hakan");
            list.Add("Büşra");
            list.ShowItems();


            Console.ReadLine();

        }
    }
    public static class MyExtensions
    {

            public static void DisplayAssemblyInfo(this object obj)//Extensions methodlarda bu thisi yazmak zorundayız başka yerlede böyle bir şey yok.
            {
            Console.WriteLine("Object Type: {0},Assembly: \n ", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
            }
       
            /// <summary>
            /// Projedeki her int veri tipi için kullanılabilir olan karesini alma methodudur.
            /// </summary>
            /// <param name="i"></param>
            /// <returns></returns>
            public static int Square(this int i)
            {
               return i * i;
            }

        public static void ShowItems(this System.Collections.IEnumerable iterator)
        {
            foreach(var item in iterator)
            {
                Console.WriteLine(item);
            }
        }
    }
}
