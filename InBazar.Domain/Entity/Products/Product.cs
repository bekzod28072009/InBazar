using InBazar.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBazar.Domain.Entity.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }

        public string Price { get; set; }

        public string? Quality { get; set; }

        public string? Size { get; set; }

        public string? Description { get; set; }
    }
}
