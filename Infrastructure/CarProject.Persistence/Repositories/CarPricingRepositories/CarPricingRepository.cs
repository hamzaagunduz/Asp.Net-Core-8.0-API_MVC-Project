using CarProject.Application.Interfaces.CarIPricingnterfaces;
using CarProject.Domain.Entities;
using CarProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Persistence.Repositories.CarPricingRepositories
{
	public class CarPricingRepository : ICarPricingRepository
	{
		private readonly CarBookContext _context;

		public CarPricingRepository(CarBookContext context)
		{
			this._context = context;
		}

		public List<CarPricing> GetCarPricingWithCars()
		{
			var values = _context.CarPricings.Include(x => x.Car).ThenInclude(z => z.Brand).
				Include(z => z.Pricing).Where(z=>z.PricingID==2).ToList();
			return values;
		}
	}
}
