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

namespace TempConv
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

        private void rbtn_Checked(object sender, RoutedEventArgs e)
        {
            // I need a method to be called to convert the temperature
            TempConvert();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            TempConvert();
        }


        private void TempConvert()
        {
            double temp;


            if (!double.TryParse(txtInput.Text,out temp))
            {
                return;
            }

            if (rbtnCelsiusInput.IsChecked == true)
            {
                if (rbtnCelsiusOutput.IsChecked == true)
                {
                    // Do not convert just show the same
                    result.Content = string.Format("{0:0.0} C", temp);
                }
                if (rbtnFarenheintOutput.IsChecked == true)
                {
                    // Convert from Celsius to Far
                    result.Content = string.Format("{0:0.0} F", ((temp * 9 / 5) + 32));
                }
                else if (rbtnKelvinOutput.IsChecked == true)
                {
                    // Convert from Celsius to Kelvin
                    result.Content = string.Format("{0:0.0} K", (temp + 237.15));
                }
            }

            if (rbtnFarenheintInput.IsChecked == true)
            {
                if (rbtnCelsiusOutput.IsChecked == true)
                {
                    // Convert from Far to Cel
                    // Celsius = (Far - 32) / 1.8
                    result.Content = string.Format("{0:0.0} C", (temp - 32) / 1.8);
                }

                else if (rbtnKelvinOutput.IsChecked == true)
                {
                    // Convert from Far to Kelvin 
                    // Kelvin (K) = (Fahrenheit - 32) / 1.8 + 273.15
                    result.Content = string.Format("{0:0.0} C", (temp - 32) / 1.8 + 273.15);
                }

                else if (rbtnFarenheintOutput.IsChecked == true)
                {
                    // Do not convert
                    result.Content = string.Format("{0:0.0}", temp);
                }
            }

            if (rbtnKelvinInput.IsChecked == true)
            {
                if (rbtnCelsiusOutput.IsChecked == true)
                {
                    // Convert from Kelvin to Celsius
                    // Celsius (°C) = Kelvin - 273.15
                    result.Content = string.Format("{0:0.0} C", temp - 273.15);
                }
                else if (rbtnFarenheintOutput.IsChecked == true)
                {
                    // Convert from Kelvin to Farenheint
                    // Fahrenheit (°F) = Kelvin x 1.8 - 459.67
                    result.Content = string.Format("{0:0.0} C", temp * 1.8 - 459.67);
                }
                else if (rbtnKelvinOutput.IsChecked == true)
                {
                    // Do not convert just show the same amount
                    result.Content = string.Format("{0:0.0}", temp);
                }
            }
        }
    }
}
