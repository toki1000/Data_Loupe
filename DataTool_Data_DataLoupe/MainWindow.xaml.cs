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

namespace DataTool_Data_DataLoupe
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseBotton(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void ImportButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ラベルなしデータを取り込む処理を追加");
        }


        private void SSLButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("自己教師あり学習により、特徴量を学習");
        }

        private void VisualizeButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("特徴空間上で可視化する処理を加えます");
        }

        private void ImageAnalizeButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ImageJを利用して画像の分析を瞬時に出力します");
        }

        private void DriftButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("運用で利用するデータセットとのドリフト比較検査を行います。");
        }

        private void EvalutionButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EDA評価を実施");
        }
    }


}
