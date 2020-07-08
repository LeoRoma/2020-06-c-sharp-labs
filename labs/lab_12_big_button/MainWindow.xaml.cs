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
        string folderName1 = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button";

        string folderToDelete1 = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton1";
        string folderToDelete2 = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton2";
        string folderToDelete3 = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton3";

        Stopwatch stopWatch = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();

            //Delete files from folder 1
            for (int i = 0; i < 100; i++)
            {
                string pathFile = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton1\TheBigButtonTxt{i}.txt";
                try
                {
                    // Check if file exists with its full path    
                    if (File.Exists(System.IO.Path.Combine(folderToDelete1, pathFile)))
                    {
                        // If file found, delete it    
                        File.Delete(System.IO.Path.Combine(folderToDelete1, pathFile));
                        Console.WriteLine("File deleted.");
                    }
                    else Console.WriteLine("File not found");
                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
            }

            //Delete files from folder 2
            for (int i = 0; i < 100; i++)
            {
                string pathFile = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton2\TheBigButtonTxt{i}.txt";
                try
                {
                    // Check if file exists with its full path    
                    if (File.Exists(System.IO.Path.Combine(folderToDelete2, pathFile)))
                    {
                        // If file found, delete it    
                        File.Delete(System.IO.Path.Combine(folderToDelete2, pathFile));
                        Console.WriteLine("File deleted.");
                    }
                    else Console.WriteLine("File not found");
                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
            }

            //Delete files from folder 3
            for (int i = 0; i < 100; i++)
            {
                string pathFile = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton3\TheBigButtonTxt{i}.txt";
                try
                {
                    // Check if file exists with its full path    
                    if (File.Exists(System.IO.Path.Combine(folderToDelete3, pathFile)))
                    {
                        // If file found, delete it    
                        File.Delete(System.IO.Path.Combine(folderToDelete3, pathFile));
                        Console.WriteLine("File deleted.");
                    }
                    else Console.WriteLine("File not found");
                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
            }

            //Delete TheBigButton1 folder
            try
            {
                Directory.Delete(folderToDelete1);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }

            //Delete TheBigButton2 folder
            try
            {
                Directory.Delete(folderToDelete2);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }

            //Delete TheBigButton3 folder
            try
            {
                Directory.Delete(folderToDelete3);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }
        }


        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            //Creates a new folders   
            
            string pathString1 = System.IO.Path.Combine(folderName1, "TheBigButton1");
            string pathString2 = System.IO.Path.Combine(folderName1, "TheBigButton2");
            string pathString3 = System.IO.Path.Combine(folderName1, "TheBigButton3");

            Directory.CreateDirectory(pathString1);
            Directory.CreateDirectory(pathString2);
            Directory.CreateDirectory(pathString3);

            stopWatch.Start();
     
            //Creates "n" files within a loop into TheBigButton1 folder 
            for (int i = 0; i < 100; i++)
            {
                string line = $"The value of i is {i} at {DateTime.Now} \n";
                string pathFile1 = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton1\TheBigButtonTxt{i}.txt";

                Thread.Sleep(1000);
                // The line below will create a text file, my_file.txt, in 
                // the Text_Files folder in D:\ drive.
                // The CreateText method that returns a StreamWriter object
                using (StreamWriter sw = File.CreateText(pathFile1)) ;
                for (int n = 0; n < 5; n++)
                {
                    File.AppendAllText(pathFile1, line);
                }
                
            }

            //Creates "n" files within a loop into TheBigButton2 folder
            for (int i = 0; i < 100; i++)
            {
                string line = $"The value of i is {i} at {DateTime.Now} \n";
                string pathFile2 = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton2\TheBigButtonTxt{i}.txt";

                Thread.Sleep(1000);
                using (StreamWriter sw = File.CreateText(pathFile2)) ;
                for (int n = 0; n < 10; n++)
                {
                    File.AppendAllText(pathFile2, line);
                }
            }

            //Creates "n" files within a loop into TheBigButton3 folder
            for (int i = 0; i < 100; i++)
            {
                string line = $"The value of i is {i} at {DateTime.Now} \n";
                string pathFile3 = $@"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button\TheBigButton3\TheBigButtonTxt{i}.txt";

                Thread.Sleep(1000);
                using (StreamWriter sw = File.CreateText(pathFile3)) ;
                for (int n = 0; n < 15; n++)
                {
                    File.AppendAllText(pathFile3, line);
                }
            }
            stopWatch.Stop();
        }
    }
}
