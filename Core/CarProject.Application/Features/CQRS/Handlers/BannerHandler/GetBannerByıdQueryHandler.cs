using CarProject.Application.Features.CQRS.Queries.BannerQueries;
using CarProject.Application.Features.CQRS.Results.BannerResults;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.BannerHandler
{
    public class GetBannerByıdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByıdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task <GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);

            return new GetBannerByIdQueryResult
            {
                BannerID = value.BannerID,
                Description = value.Description,
                Title = value.Title,
                VideoDescription = value.VideoDescription,
                VideoUrl = value.VideoUrl
            };
        }



    }
}
