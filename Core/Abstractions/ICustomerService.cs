using System.Collections.Generic;
using Core.Entities;

namespace Core.Abstractions
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomerList();

        Customer GetCustomer(int id);
    }
}