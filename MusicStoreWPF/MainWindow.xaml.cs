using MusicStoreWPF.Model;
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
        public MainWindow()
        {
            InitializeComponent();
            
            CountriesCombo.ItemsSource = new FakeCountryDb().GetCountries();

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
            int field1Value;
            int field2Value;

            if (int.TryParse(SubstractInput1Txt.Text, out field1Value) &&
                int.TryParse(SubstractInput2Txt.Text, out field2Value))
            {
                SubstractResultTxt.Text = (field1Value - field2Value).ToString();
            }
        }

        private void CountryCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CountriesCombo.SelectedItem is Country) {
                CountryInfoTxt.Text = (CountriesCombo.SelectedItem as Country).Info;
            }
        }

        private void MultiplyInputTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int field1Value;
            int field2Value;

            if (int.TryParse(MultiplyInput1Txt.Text, out field1Value) &&
                int.TryParse(MultiplyInput2Txt.Text, out field2Value))
            {
                MultiplyImg.Visibility = Visibility.Hidden;
                MultiplyResultTxt.Text = (field1Value * field2Value).ToString();
            }
            else
            {
                MultiplyImg.Visibility = Visibility.Visible;
                MultiplyImg.ToolTip = "Both fields must be a integer value";
                MultiplyResultTxt.Text = "-";
            }
        }

        private void DivideInputTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int field1Value;
            int field2Value;

            if (int.TryParse(DivideInput1Txt.Text, out field1Value) &&
                int.TryParse(DivideInput2Txt.Text, out field2Value))
            {
                
                if (field2Value != 0)
                {
                    DevideImg.Visibility = Visibility.Hidden;
                    DivideResultTxt.Text = ((double)field1Value / (double)field2Value).ToString();
                }
                else 
                {
                    DevideImg.Visibility = Visibility.Visible;
                    DevideImg.ToolTip = "When dividing with zero the result is really huge!";
                }
            }
            else
            {
                DevideImg.Visibility = Visibility.Visible;
                DevideImg.ToolTip = "Both fields must be a integer value";
                DivideResultTxt.Text = "-";
            }
        }

    }
}
