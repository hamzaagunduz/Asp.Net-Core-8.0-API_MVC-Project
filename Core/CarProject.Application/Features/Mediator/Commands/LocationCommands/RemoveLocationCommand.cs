using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Commands.LocationCommands
{
    public class RemoveLocationCommand:IRequest
    {
        public RemoveLocationCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
