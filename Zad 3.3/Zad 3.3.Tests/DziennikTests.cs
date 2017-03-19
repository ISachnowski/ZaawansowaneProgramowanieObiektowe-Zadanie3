using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace Zad_3._3.Tests
{
    [TestFixture]
    public class DziennikTests
    {
        [Test]
        public void ZmienObecnosc_BoolValue_Updated()
        {
            var przedmiot = new Przedmiot("Chemia");
            var obecnosc = new Obecnosc(true, przedmiot);
            obecnosc.ZmienObecnosc(false);
            Assert.AreEqual(false, obecnosc.obecny);
        }

        [Test]
        public void ZmienOcene_DoubleValueInRange_Updated()
        {
            var przedmiot = new Przedmiot("Chemia");
            var ocena = new Ocena(5.0, przedmiot);
            ocena.ZmienOcene(4.0);
            Assert.AreEqual(4.0, ocena.wartosc);
        }

        [Test]
        public void ZmienOcene_DoubleValueOutOfRange_NotUpdated()
        {
            var przedmiot = new Przedmiot("Chemia");
            var ocena = new Ocena(5.0, przedmiot);
            ocena.ZmienOcene(8.0);
            Assert.AreEqual(5.0, ocena.wartosc);
        }

        [Test]
        public void DodajOcene_DoubleValueInRange_Updated()
        {
            var przedmiot = new Przedmiot("Chemia");
            var ocena = new Ocena(5.0, przedmiot);
            var uczen = new Uczen("test", "test");
            uczen.DodajOcene(ocena);
            Assert.IsTrue(uczen.Oceny.Contains(ocena));
        }

        [Test]
        public void DodajOcene_DoubleValueOutOfRange_NotUpdated()
        {
            var przedmiot = new Przedmiot("Chemia");
            var ocena = new Ocena(8.0, przedmiot);
            var uczen = new Uczen("test", "test");
            uczen.DodajOcene(ocena);
            Assert.IsTrue(!uczen.Oceny.Contains(ocena));
        }

        [Test]
        public void ObliczSrednia_CalculateGrades_Calculated()
        {
            var przedmiot = new Przedmiot("Chemia");
            var ocena1 = new Ocena(5.0, przedmiot);
            przedmiot = new Przedmiot("Przyroda");
            var ocena2 = new Ocena(3.0, przedmiot);
            przedmiot = new Przedmiot("Religia");
            var ocena3 = new Ocena(3.0, przedmiot);
            przedmiot = new Przedmiot("WOS");
            var ocena4 = new Ocena(5.0, przedmiot);
            var uczen = new Uczen("test", "test");
            uczen.DodajOcene(ocena1);
            uczen.DodajOcene(ocena2);
            uczen.DodajOcene(ocena3);
            uczen.DodajOcene(ocena4);
            Assert.AreEqual(4.0, uczen.ObliczSredniaOcen());
        }

        [Test]
        public void EdytujNazwe_ValidString_Updated()
        {
            var przedmiot = new Przedmiot("Chemia");
            przedmiot.EdytujNazwe("Przyroda");
            Assert.AreEqual("Przyroda", przedmiot.name);
        }

        [Test]
        public void EdytujNazwe_EmptyString_NotUpdated()
        {
            var przedmiot = new Przedmiot("Chemia");
            przedmiot.EdytujNazwe("");
            Assert.AreEqual("Chemia", przedmiot.name);
        }


    }
}
