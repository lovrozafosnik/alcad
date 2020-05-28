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
            public float x;
            public float y;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            rondelica[] arr = new rondelica[200];

            float razmak = float.Parse(Razmak.Text, CultureInfo.InvariantCulture.NumberFormat);
            float odmik = float.Parse(odmik1.Text, CultureInfo.InvariantCulture.NumberFormat); ;
            float polmer = float.Parse(polmer1.Text, CultureInfo.InvariantCulture.NumberFormat); ;
            float sirinaTrak = float.Parse(sirina.Text, CultureInfo.InvariantCulture.NumberFormat); ;

            float dolznia = 100;
            int steviloRondelic = 0;

            float premerRondelice = polmer * 2 + razmak;

            int rondelice_po_dolzini = (int)((dolznia - odmik*2)/premerRondelice);
            
            int rondelice_po_sirini = (int)((sirinaTrak - odmik*2) / premerRondelice);

            float Xzacetna = (premerRondelice / 2) + odmik;
            float Yzacetna = (premerRondelice / 2) + odmik;



            for (int i = 0; i < 200; i++)
            {
                arr[i].x = Xzacetna;
                arr[i].y = Yzacetna;
            }

            int steviloRondelice = 1;

            for (int i = 0; i<= rondelice_po_sirini; i++)
            {
                for (int j = 1; j <= rondelice_po_dolzini; j++)
                {
                    arr[steviloRondelice].x = Xzacetna + ( j* premerRondelice);
                    arr[steviloRondelice].y = Yzacetna + (i * Yzacetna);
                    steviloRondelice++;
                }
            }

            Label1.Content = arr[2].x;

        }
    }
}
