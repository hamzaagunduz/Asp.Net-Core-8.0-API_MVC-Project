using CarProject.Application.Features.Mediator.Queries.CarPricingQueries;
using CarProject.Application.Features.Mediator.Results.CarPricingResults;
using CarProject.Application.Interfaces.CarIPricingnterfaces;
using CarProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
	{
		private readonly ICarPricingRepository _repository;

		public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
		{
			this._repository = repository;
		}

		public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
		{
			var value = _repository.GetCarPricingWithCars();
			return value.Select(x => new GetCarPricingWithCarQueryResult
			{
				Amount = x.Amount,
				Brand=x.Car.Brand.Name,
				CarPricingId=x.CarPricingID,
				CoverImageUrl=x.Car.CoverImageUrl,
				Model=x.Car.Model,
			}).ToList();
		}
	}
}
