using MyEcommerce.Dal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce.Dal.Model
{
    public class UserAddress
    {
        public int Id { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Province { get; set;}

        public string PostalCode { get; set; }

        public AddressType Type { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }     

        public UserAddressInstruction UserAddressInstruction { get; set; }
    }
}
