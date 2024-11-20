using Basit_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basit_Mvc.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {

            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ayşe",
                LastName = "Yılmaz",
                Email = "ayse.yilmaz@example.com"
            };
            var orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    ProductName = "Laptop",
                    Price = 7500.50m,
                    Quantity = 1
                },
                new Order
                {
                    Id = 2,
                    ProductName = "Telefon",
                    Price = 3200.00m,
                    Quantity = 2
                },
                new Order
                {
                    Id = 3,
                    ProductName = "Kulaklık",
                    Price = 150.75m,
                    Quantity = 3
                }


            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);



        }
    }
}
