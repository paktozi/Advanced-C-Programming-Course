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
    public class CashBox
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(cashBoxNameMaxLength)]
        public required string Name { get; set; }

        public decimal CashAmount { get; set; }

        [ForeignKey(nameof(Store))]
        public required Guid StoreId { get; set; }

        public required Store Store { get; set; }
    }
}
