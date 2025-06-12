using Application.Services;
using Microsoft.AspNetCore.Mvc;
using PresentationMVC.Models;

namespace PresentationMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;

            // Seed några kunder (demo)
            _service.CreateCustomer("Anna");
            _service.CreateCustomer("Erik");
        }

        public IActionResult Index()
        {
            var customers = _service.GetCustomers();

            var model = customers.Select(c => new CustomerViewModel
            {
                Id = c.Id,
                Name = c.Name,
            })
                .ToList();

            return View(model);
        }
    }
}
