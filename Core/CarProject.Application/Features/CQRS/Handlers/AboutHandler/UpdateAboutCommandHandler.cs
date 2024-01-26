using CarProject.Application.Features.CQRS.Commands.AboutCommands;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.AboutHandler
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.AboutID);
            value.Description = command.Description;
            value.Title = command.Title;
            value.ImageURL = command.ImageURL;
            await _repository.UpdateAsync(value);
        }
    }
}
