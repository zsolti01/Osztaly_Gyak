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

    public int ArSzamolalo()
    {
        double terulet = (hossz / 100.0) * (szelesseg / 100.0);
        if (tipus == "tartólap")
            return (int)(terulet * tartolap);
        else if (tipus == "hátlap")
            return (int)(terulet * hatlap);
        else
            return 0;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
