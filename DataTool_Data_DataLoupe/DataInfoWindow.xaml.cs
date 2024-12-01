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
using System.Windows.Shapes;

namespace DataTool_Data_DataLoupe
{
    /// <summary>
    /// datainfo.xaml の相互作用ロジック
    /// </summary>
    

    public partial class DataInfoWindow : Window
    {
        private List<DataInfo> _datainfo = new List<DataInfo>();
        private List<ParamInfo> _paraminfo = new List<ParamInfo>();
        public DataInfoWindow()
        {
            InitializeComponent();
            _datainfo.Add(new DataInfo { DatasetName = "COCO"});
            DataInfoListView.ItemsSource = _datainfo;

            _paraminfo.Add(new ParamInfo { ParamFileName = "COCO_ImageClass" });
            ParamInfoListView.ItemsSource = _paraminfo;
        }
    }
}
