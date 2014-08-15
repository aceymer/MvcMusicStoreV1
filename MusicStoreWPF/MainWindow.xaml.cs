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

namespace MusicStoreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Cities = new List<string> {"Kolding", "Esbjerg", "Køge", "Nordby"};

        public MainWindow()
        {
            InitializeComponent();
            CitiesCombo.ItemsSource = Cities;
        }

        private void AddCalcBtn_Click(object sender, RoutedEventArgs e)
        {
            int field1Value;
            int field2Value;

            if (int.TryParse(AddInput1Txt.Text, out field1Value) &&
                int.TryParse(AddInput2Txt.Text, out field2Value))
            {
                AddResultTxt.Text = (field1Value + field2Value).ToString();
            }
        }

        private void SubstractCalcBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CountryCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CitiesCombo.SelectedItem as string)
            {
                case "Kolding":
                    CountryInfoTxt.Text = "Kolding";
                    break;
                default:
                    CountryInfoTxt.Text = "Not Kolding";
                    break;
            }
        }

    }
}
