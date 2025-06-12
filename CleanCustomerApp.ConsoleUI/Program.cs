using Application.Services;
using Infrastructure.Repositories;

namespace CleanCustomerApp.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new InMemoryCustomerRepository();
            var service = new CustomerService(repo);

            service.CreateCustomer("Anna");
            service.CreateCustomer("Björn");

            foreach (var customer in service.GetCustomers())
            {
                Console.WriteLine($"Kund {customer.Id}: {customer.Name}");
            }
        }
    }
}
