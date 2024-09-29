using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Infrastructure.Data.Models
{
    public class WareHouse
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [ForeignKey(nameof(Store))]
        public Guid StoreId { get; set; }

        public required Store Store { get; set; }

        public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; } = new HashSet<WarehouseProduct>();

    }
}
