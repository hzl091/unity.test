/****************************************************************************************
 * 文件名：Order
 * 作者：黄泽林
 * 创始时间：2017/5/27 11:28:13
 * 创建说明：
****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unity.test.domain
{
    public class Order
    {
        public string OrderNumber { get; set; }

        public string SkuCode { get; set; }

        public decimal Total { get; set; }
    }
}
