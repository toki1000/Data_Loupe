using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTool_Data_DataLoupe
{
    public class DataInfo
    {
        public string DatasetName { get; set; }
        public override string ToString()
        {
            return $"{DatasetName}";
        }
    }
}
