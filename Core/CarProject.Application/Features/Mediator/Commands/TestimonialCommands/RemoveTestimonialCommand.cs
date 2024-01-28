using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand:IRequest
    {
        public RemoveTestimonialCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
