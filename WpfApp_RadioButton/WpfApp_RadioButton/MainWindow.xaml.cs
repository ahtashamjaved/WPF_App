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

namespace WpfApp_RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbMayBe.IsChecked = true;
        }

        private void rbYes_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "Thank you";
        }

        private void rbNo_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "Still you can click yes";

        }

        private void rbMayBe_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "Saying yes is better to strengthen our relations";

        }
    }
}
