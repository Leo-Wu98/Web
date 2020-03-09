using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.API.Entities
{
    public class Download
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }
    }
}
