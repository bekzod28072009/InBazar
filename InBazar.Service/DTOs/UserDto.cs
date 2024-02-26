using InBazar.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBazar.Service.DTOs
{
    public class UserDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public List<Product> Products { get; set; }

        public string Payment { get; set; }
    }
}
