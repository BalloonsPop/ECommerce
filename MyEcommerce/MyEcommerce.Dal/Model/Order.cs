using MyEcommerce.Dal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce.Dal.Model
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal Total { get; set; }
        
        public decimal GST { get; set; }

        public decimal PST { get; set; }
        
        public PaymentType PaymentMethod { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int ShippingAddressId { get; set; }

        public UserAddress UserAddress { get; set; }

        public List<OrderItem> Items { get; set; }

    }
}
