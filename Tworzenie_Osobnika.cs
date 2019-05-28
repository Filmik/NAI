using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump
{
    public class Tworzenie_Osobnika<T>
    {
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
            this.funkcjaFitness = funkcjaFitness;

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
