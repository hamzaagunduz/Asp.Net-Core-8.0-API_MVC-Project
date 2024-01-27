using CarProject.Application.Features.CQRS.Commands.BannerCommands;
using CarProject.Application.Features.CQRS.Commands.BrandCommands;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.BrandHandler
{
    public class RemoveBrandCommandHandler
    {

        private readonly IRepository<Brand> _repository;

        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBrandCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);

        }
    }
}
