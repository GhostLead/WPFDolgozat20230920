using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFDoga2023_09_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// </summary>
    //balra: Barizs Márton Dániel
    //jobbra: -
    public partial class MainWindow : Window
    {
        List<Fuvar> fuvarok = File.ReadAllLines("fuvar.csv").Skip(1).Select(x => new Fuvar(x)).ToList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHarmadikFeladat_Click(object sender, RoutedEventArgs e)
        {
            int fuvarokSzama = fuvarok.Count();
            MessageBox.Show($"3.Feladat: {fuvarokSzama} fuvar");
        }

        private void txtAzonositoEllenorzes(object sender, TextCompositionEventArgs e) {

            Regex csakSzamok = new Regex("[^0-9]+");
            e.Handled = csakSzamok.IsMatch(e.Text);
        }
        private void btnNegyedikFeladat_Click(object sender, RoutedEventArgs e)
        {
            int taxiAzon = int.Parse(txtTaxisAzonosito.Text);
            if (fuvarok.Any(x => x.TaxiAzon == taxiAzon) == true)
            {

            }
            else
            {
                MessageBox.Show("Nincsen ilyen azonosítójú taxis");
            }

        }
    }
}
