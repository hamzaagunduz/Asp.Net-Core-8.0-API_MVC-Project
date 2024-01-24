using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Emil { get; set; }
        public string Subjcet { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
