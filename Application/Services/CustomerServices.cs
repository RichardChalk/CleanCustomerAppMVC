using Core.Entities;
using Core.Interfaces;

namespace Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public void CreateCustomer(string name)
        {
            var customer = new Customer { Name = name };
            _repo.Add(customer);
        }

        public List<Customer> GetCustomers() => _repo.GetAll();
    }
}
