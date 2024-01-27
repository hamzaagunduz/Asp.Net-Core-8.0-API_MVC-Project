using CarProject.Application.Features.CQRS.Results.ContactResults;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Handlers.ContactHandler
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _repository;
        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactQueryResult
            {
                ContactID = x.ContactID,
                Name = x.Name,
                Email = x.Emil,
                Message = x.Message,
                SendDate = x.SendDate,
                Subject = x.Subjcet
            }).ToList();
        }
    }
}
