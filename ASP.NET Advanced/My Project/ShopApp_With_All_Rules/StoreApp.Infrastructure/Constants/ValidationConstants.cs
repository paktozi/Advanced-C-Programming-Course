using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Infrastructure.Constants
{
    public static class ValidationConstants
    {
        public const int locationNameMinLength = 3;
        public const int locationNameMaxLength = 30;

        public const int cashBoxNameMinLength = 3;
        public const int cashBoxNameMaxLength = 30;

        public const int firstNameMinLength = 3;
        public const int firstNameMaxLength = 20;
        public const int secondNameMinLength = 3;
        public const int secondNameMaxLength = 30;

        public const int phoneNumberMinLength = 6;
        public const int phoneNumberMaxLength = 35;
        public const int descriptionMaxLength = 500;

        public const int orderMinNumber = 1;
        public const int orderMaxNumber = 50000;

        public const int dateMinLength = 8;
        public const int dateMaxLength = 10;

        public const int productNameMinLength = 2;
        public const int productNameMaxLength = 60;

    }
}
