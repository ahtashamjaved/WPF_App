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

namespace WpfApp_Checkbox
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

        private void cbAllTopings_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool result = (cbAllTopings.IsChecked == true);
            cbSalami.IsChecked = result;
            cbMozzarella.IsChecked = result;
            cbMushrooms.IsChecked = result;
        }

        private void cbSingleCheck_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllTopings.IsChecked = null;
            if((cbSalami.IsChecked == true) && (cbMozzarella.IsChecked == true) && (cbMushrooms.IsChecked == true))
            {
                cbAllTopings.IsChecked = true;
            }
            if ((cbSalami.IsChecked == false) && (cbMozzarella.IsChecked == false) && (cbMushrooms.IsChecked == false))
            {
                cbAllTopings.IsChecked = false;
            }
        }

        
    }
}
