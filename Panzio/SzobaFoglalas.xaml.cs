using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Panzio
{
    /// <summary>
    /// Interaction logic for SzobaFoglalas.xaml
    /// </summary>
    public partial class SzobaFoglalas : Window
    {
        public SzobaFoglalas()
        {
            InitializeComponent();
            Cbx_Szobaszam.ItemsSource = Adatforras.Szobak;
            Cbx_Szobaszam.DisplayMemberPath = "Szobaszam";
            Cbx_Ugyfel.ItemsSource = Adatforras.Ugyfelek;
            Cbx_Ugyfel.DisplayMemberPath = "Nev";
            Btn_Foglalas.Click += Btn_Foglalas_Click;
        }

        private void Btn_Foglalas_Click(object sender, RoutedEventArgs e)
        {
            Szoba szoba = (Szoba)Cbx_Szobaszam.SelectedItem;
            Ugyfel ugyfel = (Ugyfel)Cbx_Ugyfel.SelectedItem;
            DateTime erkezesDatum = Dp_ErkezesDatum.SelectedDate.Value;
            DateTime tavozasDatum = Dp_TavozasDatum.SelectedDate.Value;
            int letszam = int.Parse(Tbx_Letszam.Text);

            Foglalas foglalas = new Foglalas(szoba, ugyfel, erkezesDatum, tavozasDatum, letszam);
            Adatforras.Foglalasok.Add(foglalas);

            MessageBox.Show("Foglalás sikeresen mentve!");
            Close();
        }

        private void Btn_Vissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
