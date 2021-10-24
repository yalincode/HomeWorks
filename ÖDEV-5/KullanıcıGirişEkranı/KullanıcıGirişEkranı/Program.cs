using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirişEkranı
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kullanıcı adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            string sifre = Console.ReadLine();
            while (ad!="admin"|| sifre!="123")
            {
                Console.WriteLine("Kullanıcı adınızı tekrar giriniz");
                ad = Console.ReadLine();
                Console.WriteLine("Şifrenizi tekrar giriniz");
                sifre = Console.ReadLine();
            }

            Console.WriteLine("Başarı ile giriş yaptınız");
            Console.ReadKey();

        }
    }
}
