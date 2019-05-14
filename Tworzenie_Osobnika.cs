using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public class Tworzenie_Osobnika<T>
    {

        /*void jaki_klawisz(object sender/*co to za typ, KeyEventArgs e)
        {
            // Get a handle to an application window.
        /* [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,string lpWindowName);

        int x;//kolor pikseli konczoncy pentle
            for (x = 100; x == 0; x--)
            {
                Random random = new Random();//Tworzenie obiektu, do czego słuzylo
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
                 }
            }
        }*/

        public T[] Geny { get; private set; }
        public float Fitness { get; private set; }
        private  Random random;
        private Func<T> losowyGen;
        private Func<int, float> funkcjaFitness;

        public Tworzenie_Osobnika(int size, Random random, Func<T> losowyGen, Func<int, float> funkcjaFitness, bool czylosGeny=true)
        {
            Geny = new T[size];
            this.random=random;
            this.losowyGen = losowyGen;
            this.funkcjaFitness = funkcjaFitness;//jak to przypisywanie dzialalo

            if (czylosGeny)//nie marnuje czasu na losowanie genow jesli i tak je zamienimy
            {
                for (int i = 0; i < Geny.Length; i++)
                {
                    Geny[i] = losowyGen();
                }
            }
            
        }

        public float ObliczFitness(int index)//jak duza szansa na reprodukcje
        {
            Fitness = funkcjaFitness(index);
            return Fitness;
        }

        public Tworzenie_Osobnika<T> Mieszanie(Tworzenie_Osobnika<T> Rodzic_dwa)
        {
            Tworzenie_Osobnika<T> dziecko = new Tworzenie_Osobnika<T>(Geny.Length, random, losowyGen, funkcjaFitness, czylosGeny: false);
            
            for (int i = 0; i < Geny.Length; i++)
            {
                dziecko.Geny[i] = random.NextDouble()< 0.5 ? Geny[i] : Rodzic_dwa.Geny[i];
            }
            return dziecko;
        }

        public void Mutacja(float szansaMutacji)
        {
            for (int i = 0; i < Geny.Length; i++)
            {
                if (random.NextDouble() < szansaMutacji)
                {
                    Geny[i] = losowyGen();
                }
            }
        }
    }
}
