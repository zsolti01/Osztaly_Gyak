using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Gyak
{
    public class Butorlap
    {
        private int hossz;
        private int szelesseg;
        private string tipus;

        public const int tartolap = 5000;
        public const int hatlap = 500;
    }
    
    public Butorlap(string tipus, int hossz, int szelesseg)
    {
        this.tipus = tipus;
        this.hossz = hossz;
        this.szelesseg = szelesseg;
    }

    public int ArSzamlalo()
    {
        double terulet = (hossz / 100.0) * (szelesseg / 100.0);
        if (tipus == "tartólap")
            return (int)(terulet * tartolap);
        else if (tipus == "hátlap")
            return (int)(terulet * hatlap);
        else
            return 0;
    }

    public class Butor
    {
        private Butorlap[] lapok;
        private int lapokSzama;

        public Butor()
        {
            lapok = new Butorlap[100];
            lapokSzama = 0;
        }

        public void LapHozzaad(Butorlap lap)
        {
            if (lapokSzama < lapok.Length)
            {
                lapok[lapokSzama] = lap;
                lapokSzama++;
            }
        }

        public int ArSzamol()
        {
            int osszeg = 0;
            for (int i = 0; i < lapokSzama; i++)
            {
                osszeg += lapok[i].ArSzamlalo();
            }
            return osszeg;
        }

        public override string ToString()
        {
            return $"Butor - lapok: {lapokSzama}, ar {ArSzamol()} Ft";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var butor = new butorgyar.Butor();

            var lap1 = new butorgyar.Butorlap("tartólap", 200, 60);
            var lap2 = new butorgyar.Butorlap("tartólap", 100, 60);
            var lap3 = new butorgyar.Butorlap("hátlap", 200, 100);

            butor.LapHozzaad(lap1);
            butor.LapHozzaad(lap2);
            butor.LapHozzaad(lap3);

            Console.WriteLine(butor);
        }
    }
}
