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

namespace WpfFacture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowxxx : Window
    {
        public MainWindowxxx()
        {
            InitializeComponent();
        }

        private void Toto(object sender, RoutedEventArgs e)
        {
            MonLabel.Content = "tcho";
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MonBouton.Content = "double";
        }
    }
}
