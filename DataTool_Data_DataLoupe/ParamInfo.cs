using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTool_Data_DataLoupe
{
    internal class ParamInfo
    {

        public string ParamFileName { get; set; }
        public override string ToString()
        {
            return $"{ParamFileName}";
        }
    }
}
