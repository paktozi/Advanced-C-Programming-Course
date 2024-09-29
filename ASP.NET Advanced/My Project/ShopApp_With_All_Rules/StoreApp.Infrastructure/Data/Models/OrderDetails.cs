using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Infrastructure.Data.Models
{
    public class OrderDetails
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }

        public required Order Order { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public required Product Product { get; set; }

        public double Quantity { get; set; }
    }
}
