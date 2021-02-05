using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypESP.net
{

    public static class PasswordLib
    {
        public static string GeneretedNewPass(string u , string p)
        {
            // https://vk.com/ 
            // Test123123

            string all = "";
            string all2 = "";
            string up = p + u;


            for (int i = 0; i < up.Length; i++)
            {
                if (i % 2 == 0)
                {
                    all2 += up[i].ToString();
                }
                else
                {
                    all2 += up[i].ToString().ToUpper();
                }
                

            }
            all2 = str.Replace(all2, new string[] { @"\", "/", ":", ";", "." });
            all = "";


            foreach (var item in all2)
            {

                byte[] bytes = Encoding.ASCII.GetBytes(item.ToString());
                double d = ((int)bytes[0] / all2.Count());
                if (d % 2 == 0)
                {
                    all += d.ToString() + item.ToString();
                }
                else
                {
                    all += Encoding.ASCII.GetString(bytes);
                }




                
            }
            all2 = "";
            for (int i = 0; i < all.Length; i++)
            {
                if (i % 2 == 0)
                {
                    all2 += all[i].ToString();
                }
                


            }

            all = all2;


            // 72H84T84T80P83S86V75K67C111o77M84T101e83S116t491502513491502513

            return all;
        }


    }
}
