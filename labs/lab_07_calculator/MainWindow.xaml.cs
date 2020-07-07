using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace lab_07_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string display = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            display = "";
            LabelDisplay.Content = display;
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            display += "1";
            LabelDisplay.Content = display;
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            display += "2";
            LabelDisplay.Content = display;
        }

        private void Button03_Click(object sender, RoutedEventArgs e)
        {
            display += "3";
            LabelDisplay.Content = display;
        }

        private void Button04_Click(object sender, RoutedEventArgs e)
        {
            display += "4";
            LabelDisplay.Content = display;
        }

        private void Button05_Click(object sender, RoutedEventArgs e)
        {
            display += "5";
            LabelDisplay.Content = display;
        }

        private void Button06_Click(object sender, RoutedEventArgs e)
        {
            display += "6";
            LabelDisplay.Content = display;
        }

        private void Button07_Click(object sender, RoutedEventArgs e)
        {
            display += "7";
            LabelDisplay.Content = display;
        }

        private void Button08_Click(object sender, RoutedEventArgs e)
        {
            display += "8";
            LabelDisplay.Content = display;
        }

        private void Button09_Click(object sender, RoutedEventArgs e)
        {
            display += "9";
            LabelDisplay.Content = display;
        }

        private void Button00_Click(object sender, RoutedEventArgs e)
        {
            display += "0";
            LabelDisplay.Content = display;
        }

        private void ButtonFullStop_Click(object sender, RoutedEventArgs e)
        {
            display += ".";
            LabelDisplay.Content = display;
        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {
            display += " / ";
            LabelDisplay.Content = display;
        }

        private void ButtonMoltiplication_Click(object sender, RoutedEventArgs e)
        {
            display += " * ";
            LabelDisplay.Content = display;
        }

        private void ButtonSubstraction_Click(object sender, RoutedEventArgs e)
        {
            display += " - ";
            LabelDisplay.Content = display;
        }

        private void ButtonAddition_Click(object sender, RoutedEventArgs e)
        {
            display += " + ";
            LabelDisplay.Content = display;
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = display.Split(" ");
            float firstNumber = float.Parse(numbers[0]);
            float secondNumber = float.Parse(numbers[2]);
            string arithmeticOperator = numbers[1];
            float total = 0;

            switch (arithmeticOperator)
            {
                case "+":
                    total += (firstNumber + secondNumber);
                    break;
                case "-":
                    total += (firstNumber - secondNumber);
                    break;
                case "*":
                    total += (firstNumber * secondNumber);
                    break;
                case "/":
                    total += (firstNumber / secondNumber);
                    break;

            }

            LabelDisplay.Content = total;
        }
    }
}
