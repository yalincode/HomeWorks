using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeyveAd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Elma");
            Console.WriteLine("2-Armut");
            Console.WriteLine("3-Çilek");
            Console.WriteLine("4-Üzüm");
            Console.WriteLine("5-Muz");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Elma seçtiniz");
                    Console.WriteLine("Kaç kg istiyorsunuz?");
                    double sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sayi+ "Kg istediniz");
                    Console.WriteLine("Ödeyeceğiniz para=>" +(sayi*5));
                    break;
                case "2":
                    Console.WriteLine("Armut seçtiniz");
                    Console.WriteLine("Kaç kg istiyorsunuz?");
                    double sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sayi1 + "Kg istediniz");
                    Console.WriteLine("Ödeyeceğiniz para=>" + (sayi1 * 10));
                    break;
                case "3":
                    Console.WriteLine("Çilek seçtiniz");
                    Console.WriteLine("Kaç kg istiyorsunuz?");
                    double sayi2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sayi2 + "Kg istediniz");
                    Console.WriteLine("Ödeyeceğiniz para=>" + (sayi2 * 15));
                    break;
                case "4":
                    Console.WriteLine("Üzüm seçtiniz");
                    Console.WriteLine("Kaç kg istiyorsunuz?");
                    double sayi3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sayi3 + "Kg istediniz");
                    Console.WriteLine("Ödeyeceğiniz para=>" + (sayi3 * 7.5));
                    break;
                case "5":
                    Console.WriteLine("Muz seçtiniz");
                    Console.WriteLine("Kaç kg istiyorsunuz?");
                    double sayi4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sayi4 + "Kg istediniz");
                    Console.WriteLine("Ödeyeceğiniz para=>" + (sayi4 * 5));
                    break;
            }
            Console.ReadLine();
        }
    }
}
