
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CrypESP.net.Controls;

namespace CrypESP.net
{
    public class BinaryFormatterLib
    {

        public string Name
        {
            get; set;
        } = "Data.dat";


        public void Serialize(object o)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(Name, FileMode.OpenOrCreate))
                {

                    formatter.Serialize(fs, o);

                }
            }
            catch (Exception)
            {
                ControlsLib.ERROR("Serialize ERROR!");
            }
            
        }

        public Data Deserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Data o = new Data();
            try
            {
                using (FileStream fs = new FileStream(Name, FileMode.OpenOrCreate))
                {
                    o = (Data)formatter.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                ControlsLib.ERROR("Deserialize ERROR!");
            }

            return o;
        }
        public Data Deserialize(string name)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Data o = new Data();
            try
            {
                using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
                {
                    o = (Data)formatter.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                ControlsLib.ERROR("Deserialize ERROR!");
            }

            return o;
        }
    }
}
