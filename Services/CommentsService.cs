using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public class CommentsService
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
        public void add(comment comment)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (comment != null)
                {
                    context.comments.Add(comment);
                    context.SaveChanges();
                }
            }
        }

        public void delete(comment comment)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (comment != null)
                {
                    context.comments.Remove(comment);
                    context.SaveChanges();
                }
            }
        }
    }
}
