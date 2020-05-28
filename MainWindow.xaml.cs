using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfApp1
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

         struct rondelica
        {
            public float x; //definiranje pozicije za ROND:
            public float y;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            rondelica[] arr = new rondelica[200]; //matrika za ROND.

            float razmak = float.Parse(Razmak.Text, CultureInfo.InvariantCulture.NumberFormat);         //pretvorba float v int
            float odmik = float.Parse(odmik1.Text, CultureInfo.InvariantCulture.NumberFormat); ;
            float polmer = float.Parse(polmer1.Text, CultureInfo.InvariantCulture.NumberFormat); ;
            float sirinaTrak = float.Parse(sirina.Text, CultureInfo.InvariantCulture.NumberFormat); ;

            float dolznia = 100; //začasna dolžina traku
            int steviloRondelic = 0; //stevec ROND.

            float premerRondelice = polmer * 2 + razmak; //"končni" premer ROND.

            int rondelice_po_dolzini = (int)((dolznia - odmik*2)/premerRondelice);
            
            int rondelice_po_sirini = (int)((sirinaTrak - odmik*2) / premerRondelice);

            float Xzacetna = (premerRondelice / 2) + odmik;
            float Yzacetna = (premerRondelice / 2) + odmik;



            for (int i = 0; i < 200; i++)  //postavitev ROND.
            {
                arr[i].x = Xzacetna; //dodelitev koordinata ROND.
                arr[i].y = Yzacetna;
            }

            int steviloRondelice = 1; 

            for (int i = 0; i<= rondelice_po_sirini; i++) // zanka za branje po širini
            {
                for (int j = 1; j <= rondelice_po_dolzini; j++) //zanka za branje ROND. po dolžini
                {
                    arr[steviloRondelice].x = Xzacetna + ( j* premerRondelice); // računanje koordinatov ROND.
                    arr[steviloRondelice].y = Yzacetna + (i * Yzacetna); // računanje koordinatov ROND.
                    steviloRondelice++;
                }
            }

            Label1.Content = arr[2].x; //izpis

        }
    }
}
