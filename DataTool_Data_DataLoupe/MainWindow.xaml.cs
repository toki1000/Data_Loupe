using CircularProgressBarExample;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;
using System.IO;

namespace DataTool_Data_DataLoupe
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private MainViewModel viewModel;




        public MainWindow()
        {
            InitializeComponent();
            // 3秒後にRadialMenuを表示するためのタイマーを設定
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();

            viewModel = new MainViewModel();
            DataContext = viewModel;
        
        }
                


        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            startupImage.Visibility = Visibility.Collapsed;
            radialMenu.Visibility = Visibility.Visible;
            radialMenu.IsOpen = true;
            progressbar.Visibility = Visibility.Visible;

        }

        private void CloseBotton(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void ImportButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample1");
        }


        private void SSLButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample2");
        }

        private void VisualizeButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample3");
        }

        private void ImageAnalizeButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample4");
        }

        private async void DriftButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample5");

            // プログレスバーを動かすためのタイマー
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(100); // 10秒待機
                viewModel.ProgressValue = i;
            }



        }

        private async void EvalutionButton(object sender, RoutedEventArgs e)
        {

            string relativeFilePath = @"Scripts\editor.bat"; // 実行したいバッチファイルのパス
            string batchFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeFilePath);

            try { 
                ProcessStartInfo processStartInfo = new ProcessStartInfo(batchFilePath)
                { 
                    UseShellExecute = false, CreateNoWindow = true
                }; 
                Process process = new Process { StartInfo = processStartInfo }; 
                process.Start();
                await process.WaitForExitAsync(); // プロセスの終了を待機

            } catch (Exception ex) 
            { 
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error); 
            }


        }


    }
    public static class ProcessExtensions
    {
        public static Task WaitForExitAsync(this Process process)
        {
            if (process == null) throw new ArgumentNullException(nameof(process));
            var tcs = new TaskCompletionSource<object>(); process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.SetResult(null);
            if (process.HasExited) tcs.SetResult(null);
            return tcs.Task;
        }
    }



}
