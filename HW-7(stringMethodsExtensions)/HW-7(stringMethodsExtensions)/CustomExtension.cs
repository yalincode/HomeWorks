using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7_stringMethodsExtensions_
{
    public static class CustomExtension
    {
        public static bool ExtensionContains(this string stringToSearch, string stringToFind)
        {
            var maxIndex = stringToSearch.Length - stringToFind.Length;
            // String, which we want to find is bigger than string, which we want to search
            if (maxIndex < 0) return false;

            for (int i = 0; i <= maxIndex; i++)
            {
                int j;
                for (j = 0; j < stringToFind.Length; j++)
                    // If we have different letters, stop comparing and go to next iteration of outer loop
                    if (stringToSearch[i + j] != stringToFind[j]) break;
                // If we reached last iteration of a loop then we found the string
                if (j == stringToFind.Length) return true;
            }

            // If we reached this point, we didn't find the string
            return false;
        }

        public static bool ExtensionStartWith(this string s, string k)//Tamamlandı
        {
            for (int i = 0; i < k.Length; i++)
            {
                if (s[i] == k[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static int ExtensionIndexOf(this string s, string k)
        {

            if (!s.ExtensionContains(k))
            {
                return -1;
            }
            else
            {
                for (int i = 0; i <= s.Length - k.Length; i++)
                {
                    int j;
                    for (j = 0; j < k.Length; j++)
                    {
                        if (s[j + i] != k[j])
                        {
                            break;
                        }

                    }
                    if (j == k.Length)
                    {
                        return i;
                    }
                }

            }
            return -1;
        }
        public static int ExtensionLastIndexOf(this string s, string k)
        {
            for (int i = s.Length; i >= k.Length; i--)
            {
                int j;
                int a = 0;
                for (j = k.Length - 1; j >= 0; j--)
                {
                    a++;
                    if (s[i - a] != k[j])
                    {
                        break;
                    }
                }
                if (j == -1)
                {
                    return i - 1;
                }
            }
            return -1;
        }

        public static string ExtensionReplace(this string k, string b, string c)
        {
            int index1 = k.ExtensionIndexOf(b);
            int index2 = k.ExtensionLastIndexOf(b);
            if (index2 - index1 > b.Length)
            {
                int index3 = index1 + b.Length - 1;
                int index4 = index2 - b.Length + 1;
                string temp1 = "";
                for (int i = 0; i < index1; i++)
                {
                    temp1 += k[i];
                }
                temp1 += c;
                for (int i = index3 + 1; i < index4; i++)
                {
                    temp1 += k[i];
                }
                temp1 += c;
                for (int i = index2 + 1; i < k.Length; i++)
                {
                    temp1 += k[i];
                }
                if (temp1.ExtensionIndexOf(b) > -1)
                {
                    return temp1.ExtensionReplace(b, c);
                }
                return temp1;
            }
            else if (index2 - index1 == b.Length - 1)
            {
                string temp1 = "";
                string temp2 = "";
                for (int i = 0; i < index1; i++)
                {
                    temp1 += k[i];
                }
                for (int i = index2 + 1; i < k.Length; i++)
                {
                    temp2 += k[i];
                }
                return temp1 + c + temp2;
            }
            return "Replace yapılamaz";
        }

        public static string ExtensionRemove(this string k, int a, int b)
        {
            if (a>k.Length-1)
            {
                return "Yapılamaz";
            }
            else if (a+b>k.Length-1)
            {
                return "Yapılamaz";
            }
            string temp1 = "";
            for (int i = 0; i < a; i++)
            {
                temp1 += k[i];
            }
            for (int i = a + b + 1; i < k.Length; i++)
            {
                temp1 += k[i];
            }
            return temp1;
        }

        public static string[] ExtensionSplit(this string k, char x)
        {
            string[] dizi = new string[0];
            string temp1 = "";
            for (int i = 0; i < k.Length-1; i++)
            {
                temp1 += k[i];
                if (k[i+1]==x)
                {
                    Array.Resize(ref dizi, dizi.Length + 1);
                    dizi[dizi.Length - 1] = temp1;
                    i++;
                    temp1 = "";
                }
            }
            Array.Resize(ref dizi, dizi.Length + 1);
            dizi[dizi.Length - 1] = temp1+k[k.Length-1];

            return dizi;
        }

        public static string ExtensionInsert(this string k,int a,string b)
        {
            string temp1 = "";

            if (a>k.Length)
            {
                return "Yapılamaz";
            }
            for (int i = 0; i <= a; i++)
            {
                temp1 += k[i];
            }
            temp1 += b;
            for (int i = a+1; i < k.Length; i++)
            {
                temp1 += k[i];
            }
            return temp1;
        }

        public static string ExtensionSubstring(this string k,int a)
        {
            string temp1 = "";
            for (int i = a; i < k.Length; i++)
            {
                temp1 += k[i];
            }
            return temp1;
        }

        public static string ExtensionTrim(this string k, char x)
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < k.Length; i++)
            {
                if (k[i]==x)
                {
                    continue;
                }
                if (k[i]!=x)
                {
                    index1 = i;
                    break;
                }
            }
            for (int i = k.Length-1; i > -1; i--)
            {
                if (k[i]==x)
                {
                    continue;
                }
                if (k[i] != x)
                {
                    index2 = i;
                    break;
                }
            }
            string temp = "";
            for (int i = index1; i <= index2; i++)
            {
                temp += k[i];
            }
            return temp;
        }
    }
}
