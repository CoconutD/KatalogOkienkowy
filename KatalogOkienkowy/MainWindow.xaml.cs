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

namespace KatalogOkienkowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Produkt> produkty = new List<Produkt>
            {
                new Produkt("Mleko", 2.5, "Nabiał", 10),
                new Produkt("Chleb", 3.0, "Pieczywo", 5),
                new Produkt("Jajka", 1.5, "Nabiał", 20),
                new Produkt("Masło", 4.0, "Nabiał", 8),
                new Produkt("Ser żółty", 6.0, "Nabiał", 12)
            };
            EtykietaLiczbaProduktow.Text = $"Produktów: {produkty.Count}";
        }
    }
}