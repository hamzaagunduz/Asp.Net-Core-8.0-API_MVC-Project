using CarProject.Application.Features.CQRS.Commands.AboutCommands;
using CarProject.Application.Features.CQRS.Commands.BannerCommands;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.BannerHandler
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateBannerCommand command)
        {
            await _repository.CreateAsync(new Banner
            {
               Title = command.Title,
               Description = command.Description,
               VideoUrl=command.VideoDescription,
               VideoDescription=command.VideoDescription,

            });
        }
    }
}
