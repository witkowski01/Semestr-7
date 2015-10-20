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


namespace TIiK_1
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

        public string wej1=null, wej2=null, wyj1, wyj2;
        public Dictionary<char, int> dict1,dict2;
        private bool czywczytany1=false
            , czywczytany2=false;

        private void Wykresy2_Click(object sender, RoutedEventArgs e)
        {
            var i = new Window1(dict2);
            i.Show();
        }

        private void Wykresy_Click(object sender, RoutedEventArgs e)
        {
            var i = new Window1(dict1);
            i.Show();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            var zapisz1 = new Zapisz(wyj1);
            var zapisz2 = new Zapisz(wyj2);

        }

        private void Wykonaj_Click(object sender, RoutedEventArgs e)
        {
            var wynik1 = new Wykonaj();
            var wynik2 = new Wykonaj();
            if(wej2!=null && wej1 != null) { 
            wyj1 = wynik1.wynik(wej1);
            wyj2 = wynik2.wynik(wej2);
                dict1 = wynik1.wynikDictionary(wej1);
                dict2 = wynik2.wynikDictionary(wej2);
                Wyj1TextBox.Text = wyj1;
                Wyj2TextBox.Text = wyj2;
                Zapisz.IsEnabled = true;
                Wykresy.IsEnabled = true;
                Wykresy_Copy.IsEnabled = true;
            }

        }


        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var wczyt = new Wczytaj();
            wej2 = wczyt.odczyt_zawartosci();
            czywczytany2 = true;
            if (czywczytany2 && czywczytany1)
            {
                Wykonaj.IsEnabled = true;
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var wczyt = new Wczytaj();
            wej1=wczyt.odczyt_zawartosci();
            czywczytany1 = true;
            if (czywczytany1 && czywczytany2)
            {
                Wykonaj.IsEnabled = true;
            }
        }
    }
}
