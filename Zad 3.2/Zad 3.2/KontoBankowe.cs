using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3._2
{
    public class KontoBankowe
    {
        public string Imie;
        public string Nazwisko;
        public string NrKonta;
        public double Fundusze;
        private int id;
        public string status;

        static int nr = 1;

        public KontoBankowe(string Imie, string Nazwisko, string NrKonta, double Fundusze)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.NrKonta = NrKonta;
            this.Fundusze = Fundusze;
            this.id = nr;
            this.status = "Aktywny";
            nr++;
        }

        public void WplacPieniadze(double kwota)
        {
            ZmienFunduszeKonta(this.Fundusze + kwota);
        }

        private void ZmienFunduszeKonta(double fundusze)
        {
            this.Fundusze = fundusze;
        }

        public double AktualnyStanKonta()
        {
            return this.Fundusze;
        }
        public void WyplacPieniadze(double kwota)
        {
            if (kwota <= this.Fundusze)
                ZmienFunduszeKonta(this.Fundusze - kwota);
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public void TransferujKwote(double kwota, KontoBankowe konto)
        {
            this.Fundusze -= kwota;
            konto.WplacPieniadze(kwota);
        }

    }
}
