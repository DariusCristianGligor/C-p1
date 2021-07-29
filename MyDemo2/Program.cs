using System;

namespace MyDemo2
{
    public class Animal
    {
        public string Nume;
        public int AnNastere;

        public override string ToString()
        {
            return $"(Numele meu este: {Nume} si sunt nascut in:{AnNastere})";
        }


    }

    public class Train
    {//static constructor
        protected static DateTime oraActuala;
        static Train()
        {

            oraActuala = DateTime.Now;
            Console.WriteLine("Momentul in care am creat trenuletul este: " + oraActuala);

        }
        //

    }
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            int a = 20;
            a++;
            bool b = true;
            b = false;
            double v = 23.21;
            v = v + 21.123;
            //
            //Reference Types
            Animal caine = new Animal { Nume = "Grivei", AnNastere = 2012 };
            //
            a = 22;
            vaccin(caine, a);
            Console.WriteLine("vaccin : " + caine + "     " + a);
            Animal caine1 = new Animal { Nume = "Grivei", AnNastere = 2012 };
            a = 22;
            vaccinn1(caine1, a);
            Console.WriteLine("vaccinn1: " + caine1 + "     " + a);
            a = 22;
            Animal caine2 = new Animal { Nume = "Grivei", AnNastere = 2012 };
            vaccin2(ref caine2, ref a);
            Console.WriteLine("vaccin2: " + caine2 + "     " + a);
            a = 22;
            Animal caine3 = new Animal { Nume = "Grivei", AnNastere = 2012 };
            vaccin3(out caine3, out a);
            Console.WriteLine("vaccin3: " + caine3 + "     " + a);

            //boxing
            int? i = 23;
            object o = i;
            Console.WriteLine(o);
            //
            //unboxing
            int k = (int)o;
            Console.WriteLine(k);
            //

            Train train = new Train();

        }
        static void vaccin(Animal caine, int medieDeani)
        {
            caine.AnNastere = 1192;
            medieDeani = 23;
            //valoarea ramane aceasi pentru medieDeani, dar se schimba pentru caine
        }
        static void vaccinn1(Animal caine, int medieDeani)
        {
            caine = new Animal();
            caine.AnNastere = 1192;

            medieDeani = 23;
            //valorile ramane aceasi pentru ambele
        }
        static void vaccin2(ref Animal caine, ref int medieDeani)
        {
            caine.Nume = "Bruno";
            medieDeani = 1;
            //ambele valori se modifica cand revenim in main 
        }
        static void vaccin3(out Animal caine, out int medieDeani)
        {
            caine = new Animal();
            caine.AnNastere = 1997;
            medieDeani = 123;
            medieDeani++;
            //ambele valori se schimba in main;
        }

    }
}