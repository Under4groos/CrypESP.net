using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypESP.net.Controls
{
    
    static class ControlsLib
    {
        public static UIelements.UIErrors EE;

        public static void ERROR(string s)
        {
            EE.adderrors(s);
        }
    }
}
