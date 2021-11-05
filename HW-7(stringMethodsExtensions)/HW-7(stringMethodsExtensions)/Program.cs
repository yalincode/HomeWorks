using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_7_stringMethodsExtensions_
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Yalın Sonat Sonat Yüksel";
            
            bool result=CustomExtension.ExtensionContains(metin,"Yalın");
            Console.WriteLine(result);

            bool result2 = CustomExtension.ExtensionStartWith(metin, "Yalın");
            Console.WriteLine(result2);

            int result3 = CustomExtension.ExtensionIndexOf(metin, "Sonat");
            Console.WriteLine(result3);
            
            int result4 = CustomExtension.ExtensionLastIndexOf(metin, "Yüksel");
            Console.WriteLine(result4);

            string result5 = CustomExtension.ExtensionReplace(metin, "Sonat", "Yalın");
            Console.WriteLine(result5);

            string result6 = CustomExtension.ExtensionRemove(metin, 0, 5);
            Console.WriteLine(result6);

            string[] result7 = CustomExtension.ExtensionSplit(metin, ' ');
            foreach (var item in result7)
            {
                Console.WriteLine(item.ToString());
            }

            string resul8 = CustomExtension.ExtensionInsert(metin, 5, "Doğukan");
            Console.WriteLine(resul8);

            string result9 = CustomExtension.ExtensionSubstring(metin,6);
            Console.WriteLine(result9);

            string result10 = CustomExtension.ExtensionTrim(metin, 'Y');
            Console.WriteLine(result10);





            Console.ReadKey();
        }


    }


}
