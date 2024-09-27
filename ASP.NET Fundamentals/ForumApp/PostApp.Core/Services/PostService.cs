using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using PostApp.Infrastructure.Data;
using PostApp.Infrastructure.Data.Models;


namespace ForumApp.Core.Services
{
    public class PostService(ForumDbContext context) : IPostService
    {
        public async Task AddAsync(PostModel model)
        {
            var entity = new Post()    //Create new Post with model values
            {
                Content = model.Content,
                Title = model.Title
            };
            await context.AddAsync(entity);   //  add to database
            await context.SaveChangesAsync();  // Save
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.FindAsync<Post>(id);

            if (entity == null)
            {
                throw new ApplicationException("Invalid Post!");
            }
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task EditAsync(PostModel model)
        {
            var entity = await context.FindAsync<Post>(model.Id);
            if (entity == null)
            {
                throw new ApplicationException("Invalid Post!");
            }

            entity.Title = model.Title;
            entity.Content = model.Content;
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PostModel>> GetAllPostsAsync()
        {
            return await context.Posts
                .Select(p => new PostModel()  // Create Projection 
                {
                    Id = p.Id,
                    Content = p.Content,
                    Title = p.Title,
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<PostModel?> GetByIdAsync(int id)
        {
            return await context.Posts
                .Where(p => p.Id == id)
                .Select(p => new PostModel()
                {
                    Id = p.Id,
                    Content = p.Content,
                    Title = p.Title
                }
                )
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}
