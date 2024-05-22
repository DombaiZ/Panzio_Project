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
            for (int i = 1; i < 7; i++)
            {
                Cbx_Szobaszam.ItemsSource += i.ToString();
            }
            for (int i = 2; i < 5; i++)
            {
                Cbx_Ferohelyek.ItemsSource += i.ToString();
            }

        }

        private void Btn_Vissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
