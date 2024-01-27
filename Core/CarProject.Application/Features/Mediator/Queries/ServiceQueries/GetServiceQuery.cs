using CarProject.Application.Features.Mediator.Results.ServiceResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
