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
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopWatch = new Stopwatch();
        string currentTime = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                StopwatchDisplay.Content = currentTime;
            }
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            //Creates a new folder   
            string folderName = @"C:\Users\xiajt\Desktop\Sparta Global\Course\C# Week\2020-06-c-sharp-labs\labs\lab_12_big_button";
            string pathString = System.IO.Path.Combine(folderName, "TheBigButton");
            Directory.CreateDirectory(pathString);
            stopWatch.Start();
            dispatcherTimer.Start();
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
