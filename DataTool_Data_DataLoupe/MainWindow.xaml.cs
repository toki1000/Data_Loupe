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
using System.Windows.Threading;

namespace DataTool_Data_DataLoupe
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            // 3秒後にRadialMenuを表示するためのタイマーを設定
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            startupImage.Visibility = Visibility.Collapsed;
            radialMenu.Visibility = Visibility.Visible;
            radialMenu.IsOpen = true;
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

        private void DriftButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample5");
        }

        private void EvalutionButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sample6");
        }
    }


}
