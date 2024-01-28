using CarProject.Application.Features.CQRS.Results.AboutResults;
using CarProject.Application.Features.Mediator.Queries.TestimonialQueries;
using CarProject.Application.Features.Mediator.Results.LocationResults;
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
    public class GetTestimonialByIdQueryHandler:IRequestHandler<GetTestimonialByIdQuery,GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetTestimonialByIdQueryResult
            {
                TestimonialID = value.TestimonialID,
                Comment = value.Comment,
                Title = value.Title,
                Name = value.Name,
                ImageURL = value.ImageURL
            };
        }



    }
}
