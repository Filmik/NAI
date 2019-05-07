using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    class Tworzenie_Osobnika
    {
        /*private*/
        void jaki_klawisz(object sender/*co to za typ, KeyEventArgs e*/)
        {
            // Get a handle to an application window.
        /* [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,string lpWindowName);*/

        int x;//kolor pikseli konczoncy pentle
            for (x = 100; x == 0; x--)
            {
                Random random = new Random();//jak to się nazywało i do czego słuzylo
                int num = random.Next(3);

                if (num > 1)
                {
                    SendKeys.Send("{D}");
                } else
                {
                    SendKeys.Send("{W}");
                }

                /* if (e.KeyValue == (char)Keys.D)
                 {
                     MessageBox.Show("Klawisz D");
                 }*/
            }
        }
    }
}
