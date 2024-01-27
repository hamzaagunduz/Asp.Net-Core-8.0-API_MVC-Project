using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand :IRequest
    {
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
    }
}
