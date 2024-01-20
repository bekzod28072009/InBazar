using InBazar.Domain.Common;
using InBazar.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBazar.Domain.Entity.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public List<Product> Products { get; set; }

        public string Payment { get; set; }

        public User()
        {
            Products = new List<Product>();
        }
    }
}
