using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypESP.net
{
    [Serializable]
    public class Data
    {
        public string URL
        {
            get;set;
        } = "";
        public string PASSWORD
        {
            get; set;
        } = "";
        public string PASSWORD_save
        {
            get; set;
        } = "";

        public int LEN_URL
        {
            get; set;
        } = 0;
        public int LEN_PASSWORD
        {
            get; set;
        } = 0;

        //public Data(string u , string p , int lu , int lp)
        //{
        //    URL = u;
        //    PASSWORD = p;
        //    LEN_URL = lu;
        //    LEN_PASSWORD = lp;
        //}

        //public (string , string, int , int) GetAll() => (URL, PASSWORD, LEN_URL, LEN_URL);


    }
}
