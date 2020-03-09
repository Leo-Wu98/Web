using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.API.Entities
{
    public class Storage
    {
        [Key]
        public string Pru { get; set; }
        public string Pruspec { get; set; }
        public int Prunum { get; set; }
    }
}
