using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Program
    {
        delegate void MyGenericDelegate<T>(T args);
        static void Main(string[] args)
        {
            MyGenericDelegate<string> stringDelegate = new MyGenericDelegate<string>(StringTarget);//parametre olarak bizden void döndüren string bir method istiyor.
            MyGenericDelegate<int> intDelegate = new MyGenericDelegate<int>(IntTarget);
            intDelegate(200);
            stringDelegate("Rabia Nur Kavi");
            Console.ReadLine();
        }
        static void StringTarget(string arg)
        {
            Console.WriteLine("Arg metnini büyüt: " + arg.ToUpper());
        }
        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg: " + ++arg);
        }
    }
}
