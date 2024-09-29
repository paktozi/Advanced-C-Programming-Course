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
    public class Seller
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(firstNameMaxLength)]
        public required string FirstName { get; set; }


        [MaxLength(secondNameMaxLength)]
        public required string LastName { get; set; }


        [MaxLength(phoneNumberMaxLength)]
        public required string PhoneNumber { get; set; }


        [MaxLength(descriptionMaxLength)]
        public string Description { get; set; } = null!;


        public decimal Salary { get; set; }

        public decimal SizePercentageOfSales { get; set; }

        public decimal AddedMoneyFromSales { get; set; }

        public decimal PersonalWallet { get; set; }

        [ForeignKey(nameof(Store))]
        public Guid StoreId { get; set; }

        public required Store Store { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
