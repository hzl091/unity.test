using unity.test.domain;
using unity.test.idal;

namespace unity.test.dal
{
    public class OrderRepository : IOrderRepository
    {
        Order IOrderRepository.CreateOrder(string skuCode, decimal total)
        {
            return new Order {SkuCode = skuCode, Total = total, OrderNumber = "yg88888888"};
        }
    }
}
