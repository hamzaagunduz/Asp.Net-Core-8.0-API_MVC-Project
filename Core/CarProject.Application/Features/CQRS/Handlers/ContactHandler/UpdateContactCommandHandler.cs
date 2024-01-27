using CarProject.Application.Features.CQRS.Commands.ContactCommands;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.ContactHandler
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            values.Name = command.Name;
            values.Emil = command.Email;
            values.Message = command.Message;
            values.SendDate = command.SendDate;
            values.Subjcet = command.Subject;
            await _repository.UpdateAsync(values);
        }
    }
}
