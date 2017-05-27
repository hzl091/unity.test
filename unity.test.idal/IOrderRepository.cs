using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unity.test.domain;

namespace unity.test.idal
{
    public interface IOrderRepository
    {
        Order CreateOrder(string skuCode,decimal total);
    }
}
