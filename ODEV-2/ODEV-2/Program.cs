using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 adet sayı girişi yapın");
            Console.WriteLine("1.Sayıyı girin");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı girin");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Sayıyı girin");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4.Sayıyı girin");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5.Sayıyı girin");
            int sayi5 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5;
            Console.WriteLine("Sayıların ortalaması: "+ortalama);
            Console.ReadKey();
        }
    }
}
