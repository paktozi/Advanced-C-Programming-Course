using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostApp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private Post[] initialPost =
        {
            new Post(){Id=1, Title="One",Content="One post" },
            new Post(){Id=2, Title="Two",Content="Two post" },
            new Post(){Id=3, Title="Three",Content="Three post" }
        };

        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(initialPost);
        }
    }
}
