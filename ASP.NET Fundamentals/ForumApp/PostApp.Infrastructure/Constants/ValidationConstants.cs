using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Infrastructure.Constants
{
    public static class ValidationConstants
    {
        public const int titleMaxLength = 50;
        public const int titleMinLength = 3;
        public const int contentMinLength = 3;
        public const int contentMaxLength = 1500;
        public const string RequireErrorMessage = "The {0} filed is required";
        public const string StringLengthErrorMessage = "The {0} field  must be between {2} and {1} characters long";
    }
}
