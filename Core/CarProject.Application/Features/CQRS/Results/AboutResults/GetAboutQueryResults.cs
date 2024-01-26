﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Results.AboutResults
{
    public class GetAboutQueryResults
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
