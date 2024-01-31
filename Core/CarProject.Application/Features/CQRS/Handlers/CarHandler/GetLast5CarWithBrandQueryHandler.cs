using CarProject.Application.Features.CQRS.Results.CarResults;
using CarProject.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetLast5CarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLast5CarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetLast5CarWithBrandQueryResult> Handle()
        {
            var values = _repository.GetCarsListWithBrands();
            return values.Select(x => new GetLast5CarWithBrandQueryResult
            {
                BrandName = x.Brand.Name,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
