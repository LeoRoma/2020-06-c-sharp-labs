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
using RadioApp;

namespace RadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radio = new Radio();
        static string display = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 1;
            display = radio.Play();
            LabelDisplay.Content = display;
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 2;
            display = radio.Play();
            LabelDisplay.Content = display;
        }

        private void Button03_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 3;
            display = radio.Play();
            LabelDisplay.Content = display;
        }

        private void Button04_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 4;
            display = radio.Play();
            LabelDisplay.Content = display;
        }


        private void ButtonIncreaseVolume_Click(object sender, RoutedEventArgs e)
        {
            display = $"Volume: {radio.IncreaseVolume()}";
            LabelDisplay.Content = display;
        }

        private void ButtonDecreaseVolume_Click(object sender, RoutedEventArgs e)
        {
            display = $"Volume: {radio.DecreaseVolume()}";
            LabelDisplay.Content = display;
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            if (radio.On == false)
            {
                radio.TurnOn();
                display = "Power on";
                LabelDisplay.Content = display;
            }
            else
            {
                radio.TurnOff();
                display = "Power off";
                LabelDisplay.Content = display;
            }

        }
    }
}
