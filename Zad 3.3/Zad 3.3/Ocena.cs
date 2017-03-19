using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_3._3
{
    public class Ocena
    {
        public double wartosc;
        private Przedmiot przedmiot;
        public Ocena(double wartosc, Przedmiot przedmiot)
        {
            this.wartosc = wartosc;
            this.przedmiot = przedmiot;
        }

        public void ZmienOcene(double ocena)
        {
            if (ocena >= 1.0 && ocena <= 6.0)
                this.wartosc = ocena;
        }

    }
}
