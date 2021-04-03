using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class elev
    {
        //date private
        private double media;
        private string nume_prenume;
        //proprietati
        public double Media { set { media = value; } get { return media; } }
        public string NumePrenume { set { nume_prenume = value; } get { return nume_prenume; } }
        //constructori
        public elev() { }
        public elev(double m, string np) { media = m; nume_prenume = np; }
        //metode
        public string afisare() { return nume_prenume + " " + media; }
    }

    class clasa
    {
        //date private
        private string denumire;
        private elev[] elevi;
        //proprietati
        public string Denumire { set { denumire = value; } get { return denumire; } }
        public int Length { get { return elevi.Length; } }
        //indexatori
        public elev this[int i] //pe bza de indice
        {
            set { if (i >= 0 && i < elevi.Length) elevi[i] = value; }
            get
            {
                if (i < 0) return elevi[0];
                else if (i > elevi.Length) return elevi[elevi.Length - 1];
                else return elevi[i];
            }
        }

        public elev this[string s]//dupa nume prenume
        {
            get
            {
                for (int i = 0; i < elevi.Length; i++)
                    if (elevi[i].NumePrenume == s)
                        return elevi[i];
                return new elev(0, "JD");
            }
        }

        //constructori
        public clasa() { }
        public clasa(string d, int n)
        {
            denumire = d;
            elevi = new elev[n];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fin = new StreamReader("elevi.txt");//fisier cu denumire, apoi elevii pe randuri separate (nume prenume media)
            int n = 0;
            string s = fin.ReadLine();
            while (!fin.EndOfStream)
            {
                s = fin.ReadLine();
                n++;
            }
            fin.Close();
            fin = new StreamReader("elevi.txt");
            s = fin.ReadLine();
            clasa C = new clasa(s, n);
            int i = 0;
            while (!fin.EndOfStream)
            {
                s = fin.ReadLine();
                string[] S = s.Split();
                string np = "";
                for (int j = 0; j < S.Length - 1; j++)
                    np = np + S[j] + " ";
                np = np.TrimEnd();
                double m = double.Parse(S[S.Length - 1]);
                elev e = new elev(m, np);
                C[i] = e;
                i++;
            }
            fin.Close();
            for (i = 0; i < C.Length; i++)
                Console.WriteLine(C[i].afisare());
            Console.WriteLine(C["Bob Dinu"].afisare());

            Console.ReadKey();
        }
    }

}
