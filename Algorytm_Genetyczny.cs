using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump
{
    class Algorytm_Genetyczny<T>
    {
        public List<Tworzenie_Osobnika<T>> Populacja { get; private set; }
        public int Generacja { get; private set; }
        public float NajlepszyFitness { get; private set; }
        public T[] NajleszeGeny { get; private set; }


        public float SzansaMutacji;

        private Random random;
        private float wielkośćFitness;

        public Algorytm_Genetyczny(int populacja, int wielkośćDNA, Random random, Func<T> losowyGen, Func<int, float> funkcjaFitness, float szansamutacji = 0.01f)
        {
            Generacja = 1;
            SzansaMutacji = szansamutacji;
            Populacja = new List<Tworzenie_Osobnika<T>>();
            this.random = random;

            NajleszeGeny = new T[wielkośćDNA];

            for (int i = 0; i < populacja; i++)
            {
                Populacja.Add(new Tworzenie_Osobnika<T>(wielkośćDNA, random, losowyGen, funkcjaFitness, czylosGeny: true));
            }
        }

        public void NowaGenerazja()
        {
            if (Populacja.Count <= 0) {
                return;
            }

            ObliczFitness();

            List<Tworzenie_Osobnika<T>> nowaPopulacja = new List<Tworzenie_Osobnika<T>>();

            for (int i = 0; i < Populacja.Count; i++)
            {
                Tworzenie_Osobnika<T> rodzic1 = WybieranieRodzica();
                Tworzenie_Osobnika<T> rodzic2 = WybieranieRodzica();

                Tworzenie_Osobnika<T> dziecko = rodzic1.Mieszanie(rodzic2);

                dziecko.Mutacja(SzansaMutacji);

                nowaPopulacja.Add(dziecko);
            }

            Populacja = nowaPopulacja;

            Generacja++;
        }

        public void ObliczFitness()
        {
            wielkośćFitness = 0;
            Tworzenie_Osobnika<T> Najlepszy= Populacja[0];
            for (int i = 0; i < Populacja.Count; i++)
            {
                wielkośćFitness+=Populacja[i].ObliczFitness(i);

                if (Populacja[i].Fitness > Najlepszy.Fitness)
                {
                    Najlepszy = Populacja[i];
                }
            }

            NajlepszyFitness =Najlepszy.Fitness;
            Najlepszy.Geny.CopyTo(NajleszeGeny, 0);
        }

        private Tworzenie_Osobnika<T> WybieranieRodzica()
        {
            double losowaLiczba = random.NextDouble() * wielkośćFitness;
            for (int i = 0; i < Populacja.Count; i++)
            {
                if (losowaLiczba < wielkośćFitness)
                {
                    return Populacja[i];
                }

                losowaLiczba -= Populacja[i].Fitness;
            }

            return null;
        }

    }
}
