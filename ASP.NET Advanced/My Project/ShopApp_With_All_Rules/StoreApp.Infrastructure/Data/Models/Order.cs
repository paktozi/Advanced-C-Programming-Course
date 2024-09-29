using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShopApp.Infrastructure.Constants.ValidationConstants;

namespace ShopApp.Infrastructure.Data.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(orderMaxNumber)]
        public required string Number { get; set; }

        [MaxLength(dateMaxLength)]
        public required string CreateDate { get; set; }

        public decimal Sum { get; set; }

        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }

        public required Client Client { get; set; }

        [ForeignKey(nameof(Seller))]
        public Guid SellerId { get; set; }

        public required Seller Seller { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; } = new HashSet<OrderDetails>();
    }
}
