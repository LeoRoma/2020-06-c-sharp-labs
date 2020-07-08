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
using System.Windows.Threading;

namespace lab_12_big_button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string folderName = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button";
  
        Stopwatch stopWatch = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                string pathFile = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton\TheBigButtonTxt{i}.txt";
                try
                {
                    // Check if file exists with its full path    
                    if (File.Exists(System.IO.Path.Combine(folderName, pathFile)))
                    {
                        // If file found, delete it    
                        File.Delete(System.IO.Path.Combine(folderName, pathFile));
                        Console.WriteLine("File deleted.");
                    }
                    else Console.WriteLine("File not found");
                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
            }

        }


        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            //Creates a new folder   
            
            string pathString = System.IO.Path.Combine(folderName, "TheBigButton");
            Directory.CreateDirectory(pathString);
            stopWatch.Start();
     
            //Creates "n" files within a loop
            for (int i = 0; i < 100; i++)
            {
                string line = $"The value of i is {i} at {DateTime.Now} \n";
                string pathFile = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton\TheBigButtonTxt{i}.txt";

                Thread.Sleep(50);
                // The line below will create a text file, my_file.txt, in 
                // the Text_Files folder in D:\ drive.
                // The CreateText method that returns a StreamWriter object
                using (StreamWriter sw = File.CreateText(pathFile)) ;
                File.AppendAllText(pathFile, line);

            }
            stopWatch.Stop();
        }
    }
}
