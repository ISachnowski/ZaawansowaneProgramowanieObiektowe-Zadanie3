using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_3._3
{
    public class Przedmiot
    {
        public string name;

        public Przedmiot(string name) 
        {
            this.name = name;
        }

        public void EdytujNazwe(string name)
        {
            if (name.Length > 0)
                this.name = name;
        }
    }
}
