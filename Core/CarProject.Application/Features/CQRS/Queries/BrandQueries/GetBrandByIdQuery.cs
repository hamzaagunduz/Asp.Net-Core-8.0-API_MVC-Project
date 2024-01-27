using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {

        public GetBrandByIdQuery(int id)
        {
            this.Id = id;
        }
        public int Id;

    }
}
