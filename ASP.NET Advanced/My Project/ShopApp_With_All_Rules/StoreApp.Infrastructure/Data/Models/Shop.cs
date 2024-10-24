using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShopApp.Infrastructure.Constants.ValidationConstants;

namespace ShopApp.Infrastructure.Data.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; } 

        [MaxLength(locationNameMaxLength)]
        public required string Location { get; set; }

        public virtual ICollection<CashBox> CashBoxes { get; set; } = new HashSet<CashBox>();
        public virtual ICollection<Seller> Sellers { get; set; } = new HashSet<Seller>();
        public virtual ICollection<WareHouse> WareHouses { get; set; } = new HashSet<WareHouse>();
    }
}
