using Core.Abstractions;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Infrastructure
{
    public class CustomerService : ICustomerService
    {
        public static IEnumerable<Customer> Customers => new List<Customer>
        {
            new Customer{ Id = 1, Contact = "123456789", Email="john@gmail.com", FirstName="John", LastName = "Doe"},
            new Customer{ Id = 2, Contact = "564514501", Email="ray@gmail.com", FirstName="Ray", LastName = "Doe"},
            new Customer{ Id = 3, Contact = "141510217", Email="smith@gmail.com", FirstName="Smith", LastName = "Doe"},
            new Customer{ Id = 4, Contact = "254112152", Email="mukesh@gmail.com", FirstName="Mukesh", LastName = "Murugan"},
            new Customer{ Id = 5, Contact = "125452338", Email="helen@gmail.com", FirstName="Helen", LastName = "Doe"},
            new Customer{ Id = 6, Contact = "985171215", Email="jack@gmail.com", FirstName="Jack", LastName = "Doe"},
            new Customer{ Id = 7, Contact = "653107410", Email="marc@gmail.com", FirstName="Marc", LastName = "Doe"},
            new Customer{ Id = 8, Contact = "165357410", Email="tim@gmail.com", FirstName="Tim", LastName = "Doe"},
            new Customer{ Id = 9, Contact = "012543413", Email="jimmy@gmail.com", FirstName="Jimmy", LastName = "Doe"},
            new Customer{ Id = 10, Contact = "124633892", Email="dany@gmail.com", FirstName="Dany", LastName = "Doe"},
        };

        public Customer GetCustomer(int id)
        {
            //Assume Database Response takes 1000 ms
            Thread.Sleep(1000);
            return Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            //Assume Database Response takes 3000 ms
            Thread.Sleep(3000);
            return Customers;
        }
    }
}