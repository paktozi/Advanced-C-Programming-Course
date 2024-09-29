using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Infrastructure.Data.Models
{
    public class WarehouseProduct
    {
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public required Product Product { get; set; }

        [ForeignKey(nameof(WareHouse))]
        public Guid WareHouseId { get; set; }

        public required WareHouse WareHouse { get; set; }
    }
}
