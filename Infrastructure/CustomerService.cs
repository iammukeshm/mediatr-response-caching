using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Core.Abstractions;
using Core.Entities;

namespace Infrastructure
{
    public class CustomerService : ICustomerService
    {
        private static IEnumerable<Customer> Customers => new List<Customer>
        {
            new() { Id = 1, Contact = "123456789", Email = "john@gmail.com", FirstName = "John", LastName = "Doe" },
            new() { Id = 2, Contact = "564514501", Email = "ray@gmail.com", FirstName = "Ray", LastName = "Doe" },
            new() { Id = 3, Contact = "141510217", Email = "smith@gmail.com", FirstName = "Smith", LastName = "Doe" },
            new()
            {
                Id = 4, Contact = "254112152", Email = "mukesh@gmail.com", FirstName = "Mukesh", LastName = "Murugan"
            },
            new() { Id = 5, Contact = "125452338", Email = "helen@gmail.com", FirstName = "Helen", LastName = "Doe" },
            new() { Id = 6, Contact = "985171215", Email = "jack@gmail.com", FirstName = "Jack", LastName = "Doe" },
            new() { Id = 7, Contact = "653107410", Email = "marc@gmail.com", FirstName = "Marc", LastName = "Doe" },
            new() { Id = 8, Contact = "165357410", Email = "tim@gmail.com", FirstName = "Tim", LastName = "Doe" },
            new() { Id = 9, Contact = "012543413", Email = "jimmy@gmail.com", FirstName = "Jimmy", LastName = "Doe" },
            new() { Id = 10, Contact = "124633892", Email = "dany@gmail.com", FirstName = "Dany", LastName = "Doe" }
        };

        public Customer GetCustomer(int id)
        {
            //Assume Database Response takes 1000 ms
            Thread.Sleep(1000);
            return Customers.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            //Assume Database Response takes 3000 ms
            Thread.Sleep(3000);
            return Customers;
        }
    }
}