using CarProject.Application.Features.Mediator.Queries.ServiceQueries;
using CarProject.Application.Features.Mediator.Results.ServiceResults;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetSocialMediaQueryHandler:IRequestHandler<GetSocialMediaQuery,List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;
        public GetSocialMediaQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetServiceQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                Description = x.Description,
                IconURL = x.IconURL,
                Title = x.Title,
                ServiceID = x.ServiceID
            }).ToList();
        }
    }
}
