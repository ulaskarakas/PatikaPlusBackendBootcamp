using Microsoft.AspNetCore.Mvc;
using PatikaBasicMVCApp.Models;

namespace PatikaBasicMVCApp.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customerOne = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            var customerOneOrders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 300.00m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Mouse", Price = 25.99m, Quantity = 2 },
                new Order { Id = 3, ProductName = "Keyboard", Price = 75.50m, Quantity = 1 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customerOne,
                Orders = customerOneOrders
            };

            return View(viewModel);
        }

    }
}