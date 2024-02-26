using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBazar.Service.DTOs
{
    public class ProductDto
    {
        public string Name { get; set; }

        public string Price { get; set; }

        public string? Quality { get; set; }

        public string? Size { get; set; }

        public string? Description { get; set; }
    }
}
