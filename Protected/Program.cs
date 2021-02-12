using System;

namespace Protected
{
    class Memeli
    {
        public double Boyu;
        protected double Agirlik;
        public void BoyGoster()
        {
            Console.WriteLine("Boyu: {0}", Boyu);
            Console.WriteLine("Ağırlık: {0} ", Agirlik);
        }
    }
    interface IKonus
    {
        void Konus();
    }
    class Kedi:Memeli,IKonus
    {
        protected string Turu;

         void IKonus.Konus()
        {
            Console.WriteLine("Konus: Miyav ");
        }

        public void TurGoster()
        {
            Console.WriteLine("Turu: {0}", Turu);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.TurGoster();     
            ((IKonus)kedi).Konus();//interfacelerin metotlarını ancak bu şekilde çağırabiliriz.
            Console.ReadLine();

        }
    }
}
