using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce.Dal.Model
{
    public class UserAddressInstruction
    {
        public int Id { get; set; }

        public string InstructionDescription { get; set; }

        public UserAddress UserAddress { get; set; }

        public int UserAddressId { get; set; }

    }
}
