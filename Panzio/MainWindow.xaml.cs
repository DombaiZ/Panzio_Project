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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Panzio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void MI_Szobafoglalas_Click(object sender, RoutedEventArgs e)
        {
            SzobaFoglalas szobafoglalasAblak = new SzobaFoglalas();
            szobafoglalasAblak.ShowDialog();
        }

        private void MI_Ugyfeladatok_Click(object sender, RoutedEventArgs e)
        {
            UgyfelAdatok ugyfelAdatok = new UgyfelAdatok();
            ugyfelAdatok.ShowDialog();
        }

        private void MI_Lista_Click(object sender, RoutedEventArgs e)
        {
            FoglalasokLista foglalasoklista = new FoglalasokLista();
            foglalasoklista.ShowDialog();
        }
    }
}
