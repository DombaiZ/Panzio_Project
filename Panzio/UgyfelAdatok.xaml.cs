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
    /// Interaction logic for UgyfelAdatok.xaml
    /// </summary>
    public partial class UgyfelAdatok : Window
    {
        public static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        public UgyfelAdatok()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            ugyfelek.Add(new Ugyfel(Tbx_UgyfelID.Text, Tbx_UgyfelNev.Text, DateTime.Parse(Dpr_szulEv.Text),Tbx_Email.Text, Cbx_VIP.IsChecked==true));
            Close();
        }

        private void Btn_Vissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Tbx_UgyfelNev_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] nev = Dpr_szulEv.Text.Split('.');
            Tbx_UgyfelID.Text = Tbx_UgyfelNev.Text + nev[0];
        }

        private void Dpr_szulEv_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] nev = Dpr_szulEv.Text.Split('.');
            Tbx_UgyfelID.Text = Tbx_UgyfelNev.Text + nev[0];
        }
    }
}
