using Core.Entities;

namespace Core.Interfaces
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        List<Customer> GetAll();
    }
}
