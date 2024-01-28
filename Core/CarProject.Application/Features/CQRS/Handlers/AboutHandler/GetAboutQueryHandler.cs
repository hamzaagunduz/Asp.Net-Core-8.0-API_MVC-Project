using CarProject.Application.Features.CQRS.Results.AboutResults;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.AboutHandler
{
    public class GetAboutQueryHandler
    {   
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        
        public async Task<List<GetAboutQueryResults>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResults
            {
                AboutID = x.AboutID,
                Title= x.Title,
                Description = x.Description,
                ImageURL = x.ImageURL,
            }).ToList();
        }
    }
}
