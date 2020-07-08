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
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace lab_12_big_button
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

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            string folderName = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button";
            string pathString = System.IO.Path.Combine(folderName, "TheBigButton");
            Directory.CreateDirectory(pathString);

            //string pathFile = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton\TheBigButtonTxt.txt";

            //// The line below will create a text file, my_file.txt, in 
            //// the Text_Files folder in D:\ drive.
            //// The CreateText method that returns a StreamWriter object
            //using (StreamWriter sw = File.CreateText(pathFile))

                Console.WriteLine("Path to my file: {0}\n", pathString);

            for (int i = 0; i < 10; i++)
            {
                string pathFile = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton\TheBigButtonTxt{i}.txt";

                // The line below will create a text file, my_file.txt, in 
                // the Text_Files folder in D:\ drive.
                // The CreateText method that returns a StreamWriter object
                using (StreamWriter sw = File.CreateText(pathFile)) ;
            }

            stopwatch.Stop();

        }
    }
}
