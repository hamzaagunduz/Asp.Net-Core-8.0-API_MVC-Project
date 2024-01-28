using CarProject.Application.Features.Mediator.Queries.TestimonialQueries;
using CarProject.Application.Features.Mediator.Results.TestimonialResults;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler:IRequestHandler<GetTestimonialQuery,List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values= await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                TestimonialID = x.TestimonialID,
                ImageURL = x.ImageURL,
                Name = x.Name,
                Title = x.Title,
                Comment = x.Comment
            }).ToList();
        }
    }
}
