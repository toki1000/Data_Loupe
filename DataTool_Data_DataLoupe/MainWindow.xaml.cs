using CircularProgressBarExample;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Diagnostics;
using System.IO;
using RadialMenu.Controls;
using System.Collections.Generic;

namespace DataTool_Data_DataLoupe
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private MainViewModel viewModel;

        public static List<RadialMenuItem> GlobalRadialMenuItems;

        public MainWindow()
        {
            InitializeComponent();

            // 前回開いたラジアルアイテムを保存する為
            GlobalRadialMenuItems = radialMenu.Items;

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


        private async void ExtractionButton(object sender, RoutedEventArgs e)
        {
 
            //MessageBox.Show("sample4");
            radialMenu.IsOpen = false;
            await Task.Delay(400);
            radialMenu.Items = GlobalRadialMenuItems;
            radialmenu_extraction.IsOpen = true;
        }

        private void VisualizeButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample3");
        }


        private async void ImproveButton(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("sample4");
            radialMenu.IsOpen = false;
            await Task.Delay(400);
            radialMenu.Items = GlobalRadialMenuItems;
            radialmenu_Improve.IsOpen = true;
        }

        private async void DriftButton(object sender, RoutedEventArgs e)
        {

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

        private async void ImproveBackBotton(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("sample4");
            radialmenu_Improve.IsOpen = false;
            await Task.Delay(400);
            radialMenu.Items = GlobalRadialMenuItems;
            radialMenu.IsOpen = true;

        }

        private async void RedundantButton(object sender, RoutedEventArgs e)
        {
            // プログレスバーを動かすためのタイマー
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(100); // 10秒待機
                viewModel.ProgressValue = i;
            }


        }

        private async void CleansingButton(object sender, RoutedEventArgs e)
        {

            // プログレスバーを動かすためのタイマー
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(100); // 10秒待機
                viewModel.ProgressValue = i;
            }
        }

        private void SettingButton(object sender, RoutedEventArgs e)
        {

        }

        private async void ExtractionBackBotton(object sender, RoutedEventArgs e)
        {
            radialmenu_extraction.IsOpen = false;
            await Task.Delay(400);
            radialMenu.Items = GlobalRadialMenuItems;
            radialMenu.IsOpen = true;
        }

        private async void ZeroLabelButton(object sender, RoutedEventArgs e)
        {
            radialmenu_extraction.IsOpen = false;
            await Task.Delay(400);
            radialMenu.Items = GlobalRadialMenuItems;
            radialmenu_setinfo.IsOpen = true;

            // データの情報を表示するためのウィンドウを表示
            var f= new DataInfoWindow();
            f.ShowDialog();
        }

        private void AllLabelButton(object sender, RoutedEventArgs e)
        {

        }

        private void HalfLabelButton(object sender, RoutedEventArgs e)
        {

        }

        private void OpenFolderButton(object sender, RoutedEventArgs e)
        {

        }

        private void OpenParamButton(object sender, RoutedEventArgs e)
        {

        }

        private void TrainingButton(object sender, RoutedEventArgs e)
        {

        }

        private async void ExtractionSettingBackBotton(object sender, RoutedEventArgs e)
        {
            radialmenu_setinfo.IsOpen = false;
            await Task.Delay(400);
            radialMenu.Items = GlobalRadialMenuItems;
            radialmenu_extraction.IsOpen = true;
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
