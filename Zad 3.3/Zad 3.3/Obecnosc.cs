using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_3._3
{
    public class Obecnosc
    {
        public bool obecny;
        private DateTime data;
        private Przedmiot przedmiot;

        public Obecnosc(bool obecny, Przedmiot przedmiot)
        {
            this.obecny = obecny;
            this.przedmiot = przedmiot;
            this.data = DateTime.Today;
        }

        public Obecnosc(bool obecny, Przedmiot przedmiot, DateTime data)
        {
            this.obecny = obecny;
            this.przedmiot = przedmiot;
            this.data = data;
        }

        public void ZmienObecnosc(bool obecny)
        {
            this.obecny = obecny;
        }
    }
}
