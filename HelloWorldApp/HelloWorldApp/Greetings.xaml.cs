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

namespace HelloWorldApp
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

        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        private void Confirm_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Great.IsChecked == true)
            {
                MessageBox.Show("They are fan-bloody-tastic");
            }
            else if (Worst.IsChecked == true)
            {
                MessageBox.Show("I hate them all");
            }
        }
    }
}
