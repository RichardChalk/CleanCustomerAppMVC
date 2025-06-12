using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Repositories
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();
        private int _idCounter = 1;

        public void Add(Customer customer)
        {
            customer.Id = _idCounter++;
            _customers.Add(customer);
        }

        public List<Customer> GetAll() => _customers;
    }
}
