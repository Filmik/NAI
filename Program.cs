using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           //do osobnej klacy
           /*private*/ void jaki_klawisz(object sender/*co to za typ*/,KeyEventArgs e)
            {
                if (e.KeyValue == (char)Keys.A)
                {
                    //zamiast wiaomosci to zapisz do tebeli zeby dziedziczylo
                    MessageBox.Show("Klawisz A");
                }
                if (e.KeyValue == (char)Keys.W)
                {
                    MessageBox.Show("Klawisz W");
                }
                if (e.KeyValue == (char)Keys.S)
                {
                    MessageBox.Show("Klawisz S");
                }
                if (e.KeyValue == (char)Keys.D)
                {
                    MessageBox.Show("Klawisz D");
                }
            }
        }
    }
}
