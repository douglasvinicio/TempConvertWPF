﻿using System;
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

        private void TempCovert()
        {
            double temp;

            if (!double.TryParse(txtInput.Text,out temp))
            {
                return;
            }

            if (rbtnCelsiusInput.IsChecked == true)
            {
                if (rbtnFarenheintOutput.IsChecked == true)
                {

                }
                else if (rbtnKelvinOutput.IsChecked == true)
                {

                }
            }

            if (rbtnFarenheintInput.IsChecked == true)
            {
                if (rbtnCelsiusOutput.IsChecked == true)
                {
                    result.Content = string.Format("{0:0:0}",2131);
                }

                else if (rbtnKelvinOutput.IsChecked == true)
                {

                }
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
