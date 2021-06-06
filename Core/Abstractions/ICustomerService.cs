using Core.Entities;
using System.Collections.Generic;

namespace Core.Abstractions
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomerList();

        Customer GetCustomer(int id);
    }
}