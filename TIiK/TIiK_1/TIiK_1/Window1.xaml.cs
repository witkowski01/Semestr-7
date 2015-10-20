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
using System.Windows.Controls.DataVisualization.Charting;
namespace TIiK_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Dictionary<char, int> dict;
        public Window1(Dictionary<char, int> dict)
        {
            this.dict = dict;
            InitializeComponent();
        }

        private void mcChart_Loaded(object sender, RoutedEventArgs e)
        {
            ZaladujDane1();
        }

        //Dane String i Int (Odpowiadajace wartościom CHART w XAML
        //     IndependentValueBinding="{Binding Path=Key}"
        //     DependentValueBinding="{Binding Path=Value}">
        private void ZaladujDane1()
        {
            ((PieSeries)mcChart.Series[0]).ItemsSource = dict;
            List<KeyValuePair<string, string>> kvpList = new List<KeyValuePair<string, string>>();
            int j = 0;
            foreach (var i in dict)
            {
                kvpList.Insert(j, new KeyValuePair<string, string>(i.Key.ToString(),i.Value.ToString()));
                j++;
            }

        }
    }
}
