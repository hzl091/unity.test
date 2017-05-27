using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unity.test.iservice
{
    public interface IOrderService
    {
        string CreateOrder(string skuCode , decimal total);
    }
}
