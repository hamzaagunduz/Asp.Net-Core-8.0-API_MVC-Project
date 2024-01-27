using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdQueries
    {
        public int Id;

        public GetCarByIdQueries(int id)
        {
            Id = id;
        }
    }
}
