using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using unity.test.framework.DIContainer;
using unity.test.iservice;

namespace unity.test.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;
        public HomeController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            string orderNumber = _orderService.CreateOrder("1138", 10);
            return Content(orderNumber);
        }

        public ActionResult Test()
        {
            string orderNumber = _orderService.CreateOrder("1138", 10);
            var service = Engine.Current.Resolve<IOrderService>();
            string name = service.GetType().FullName;
            return Content(name);
        }

    }
}
