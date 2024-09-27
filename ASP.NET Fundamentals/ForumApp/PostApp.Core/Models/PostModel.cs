using System.ComponentModel.DataAnnotations;
using static PostApp.Infrastructure.Constants.ValidationConstants;

namespace ForumApp.Core.Models
{
    public class PostModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(titleMaxLength, MinimumLength = titleMinLength, ErrorMessage = StringLengthErrorMessage)]
        public string Title { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(titleMaxLength, MinimumLength = titleMinLength, ErrorMessage = StringLengthErrorMessage)]
        public string Content { get; set; }


    }
}
