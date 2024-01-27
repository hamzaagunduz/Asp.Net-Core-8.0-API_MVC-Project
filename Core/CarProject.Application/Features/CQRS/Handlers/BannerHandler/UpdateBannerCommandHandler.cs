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
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.BannerID);
            value.VideoDescription = command.VideoDescription;
            value.Title = command.Title;
            value.VideoUrl = command.VideoUrl;
            value.Description = command.Description;
            await _repository.UpdateAsync(value);
        }
    }
}
