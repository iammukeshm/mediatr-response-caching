using Core.Abstractions;
using Core.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

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

        public async Task<Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var cutomer = customerService.GetCustomer(request.Id);
            return cutomer;
        }
    }
}