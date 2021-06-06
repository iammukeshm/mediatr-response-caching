using Core.Abstractions;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Features.Customers.GetCustomerList
{
    public class GetCustomerListQuery : IRequest<List<Customer>>, ICacheableMediatrQuery
    {
        public int Id { get; set; }
        public bool BypassCache { get; set; }
        public string CacheKey => $"CustomerList";
        public TimeSpan? SlidingExpiration { get; set; }
    }

    internal class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQuery, List<Customer>>
    {
        private readonly ICustomerService customerService;

        public GetCustomerListQueryHandler(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public async Task<List<Customer>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var cutomers = customerService.GetCustomerList();
            return cutomers.ToList();
        }
    }
}