using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrypESP.net
{
    public static class str
    {
        public static string Replace(string s, string[] str)
        {
            string newall = "";
            foreach (char item in s)
            {
                if (IsStr(item.ToString() , str))
                    continue;
                newall += item;
            }
            return newall;
        }
        public static string Replace(string s, string[] str , string a)
        {
            string newall = "";
            foreach (char item in s)
            {
                if (IsStr(item.ToString(), str))
                {

                    newall += a;
                }
                else
                {
                    newall += item;
                }   
            }
            return newall;
        }


        public static bool IsStr(this string s, string[] str)
        {
            bool b = false;
            foreach (string item in str)
                if (item == s)
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                } 
            return b;
        }
    }
}
