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

        string userInput;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userInput = tmpInput.Text;

            double tempInput;
            double tempOutput;

            try
            {
                 tempInput = double.Parse(userInput);
            }
            catch (Exception)
            {
                // research for how to throw exception in wpf
                throw;
            }

            //if (rbtnCelsiusInput.IsChecked && rbtnFarenheintOutput.IsChecked = true)
            //{
               // tempInput * 3
           // }
           // 
        }
    }
}
