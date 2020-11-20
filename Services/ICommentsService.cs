using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public interface ICommentsService
    {
        Task<List<comment>> comments(int postId);

        Task add(comment comment);
    }

    public class CommentsService : ICommentsService
    {
        DbContextOptions<ApplicationDbContext> options;
        public CommentsService(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
        public async Task<List<comment>> comments(int postId)
        {
            using (var context = new ApplicationDbContext(options))
            {
                return await context.comments.Where(p => p.postID == postId).ToListAsync();
            }            
        }
        public async Task add(comment comment)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (comment != null)
                {
                    context.comments.Add(comment);
                    await context.SaveChangesAsync();
                }
            }
        }             
    }
}
