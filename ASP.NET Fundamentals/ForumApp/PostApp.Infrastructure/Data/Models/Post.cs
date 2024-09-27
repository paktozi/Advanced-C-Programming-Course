using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static PostApp.Infrastructure.Constants.ValidationConstants;

namespace PostApp.Infrastructure.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(titleMaxLength)]
        public required string Title { get; set; }

        [MaxLength(contentMaxLength)]
        public required string Content { get; set; }

    }
}
