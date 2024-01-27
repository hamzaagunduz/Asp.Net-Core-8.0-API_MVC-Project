using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Commands.CarCommands
{
    public class RemoveCarCommand
    {
        public int Id;

        public RemoveCarCommand(int id)
        {
            Id = id;
        }
    }
}
