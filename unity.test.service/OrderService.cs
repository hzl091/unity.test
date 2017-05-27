using unity.test.idal;
using unity.test.iservice;

namespace unity.test.service
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public string CreateOrder(string skuCode, decimal total)
        {
            var order =_orderRepository.CreateOrder(skuCode, total);
            return order.OrderNumber;
        }
    }
}
