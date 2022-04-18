using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Abstractions;
using Core.Entities;
using MediatR;

namespace Core.Features.Customers.GetCustomer
{
    public class GetCustomerQuery : IRequest<Customer>, ICacheableMediatrQuery
    {
        public int Id { get; set; }
        public bool BypassCache { get; set; }
        public string CacheKey => $"Customer-{Id}";
        public TimeSpan? SlidingExpiration { get; set; }
    }

    internal class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, Customer>
    {
        private readonly ICustomerService customerService;

        public GetCustomerQueryHandler(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public Task<Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = customerService.GetCustomer(request.Id);
            return Task.FromResult(customer);
        }
    }
}