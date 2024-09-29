using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShopApp.Infrastructure.Constants.ValidationConstants;

namespace ShopApp.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(productNameMaxLength)]
        public required string Name { get; set; }

        public decimal Price { get; set; }

        public double PackagingSize { get; set; }

        public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; } = new HashSet<WarehouseProduct>();
        public virtual ICollection<OrderDetails> OrderDetails { get; set; } = new HashSet<OrderDetails>();
    }
}
