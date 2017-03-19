using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zad_3._3
{
    /// <summary>
    /// Interaction logic for Przedmioty.xaml
    /// </summary>
    public partial class Przedmioty : Page
    {
        public Przedmioty()
        {
            InitializeComponent();
            List<Przedmiot> przedmioty = new List<Przedmiot>();
            przedmioty.Add(new Przedmiot("Matematyka"));
            przedmioty.Add(new Przedmiot("Fizyka"));
            przedmioty.Add(new Przedmiot("Chemia"));

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
