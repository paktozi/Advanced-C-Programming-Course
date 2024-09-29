using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShopApp.Infrastructure.Constants.ValidationConstants;

namespace ShopApp.Infrastructure.Data.Models
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(firstNameMaxLength)]
        public required string FirstName { get; set; }

        [MaxLength(secondNameMaxLength)]
        public required string LastName { get; set; }

        [MaxLength(phoneNumberMaxLength)]
        public required string PhoneNumber { get; set; }

        public decimal DiscountPercentage { get; set; }

        [MaxLength(descriptionMaxLength)]
        public required string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
