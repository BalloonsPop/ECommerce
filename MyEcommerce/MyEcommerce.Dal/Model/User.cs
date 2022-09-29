using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce.Dal.Model
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string EncryptedPassword { get; set; }

        public int PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public List<UserAddress> UserAddresses { get; set; }
    }
}
