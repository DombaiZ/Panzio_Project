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
    /// Interaction logic for FoglalasokLista.xaml
    /// </summary>
    public partial class FoglalasokLista : Window
    {
        public FoglalasokLista()
        {
            InitializeComponent();
            Dgr_adatok.ItemsSource = Adatforras.Foglalasok;
        }

        
    }
}
