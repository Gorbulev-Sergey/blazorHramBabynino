using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public class PostsService : ICRUD<post>
    {
        DbContextOptions<ApplicationDbContext> options;

        public PostsService(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }

        public void add(post item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.posts.Add(item);
                //await context.SaveChangesAsync();
                //context.posts.Include(t => t.tags).FirstOrDefault(p => p.Equals(post)).tags.AddRange(tags);
                context.SaveChanges();
            }
        }

        public async Task addAsync(post item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                await context.posts.AddAsync(item);
                //await context.SaveChangesAsync();
                //context.posts.Include(t => t.tags).FirstOrDefault(p => p.Equals(post)).tags.AddRange(tags);
                await context.SaveChangesAsync();
            }
        }

        public void delete(post item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.posts.Remove(item);
                context.SaveChanges();
            }
        }

        public async Task deleteAsync(post item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.posts.Remove(item);
                await context.SaveChangesAsync();
            }
        }

        public List<post> get()
        {
            using (var context = new ApplicationDbContext(options))
            {
                var posts = context.posts.Include(pt => pt.posttags).Include(p => p.comments).Include(p => p.likes).ToList();
                return posts.OrderBy(p => p.created).ToList();
            }
        }

        public async Task<List<post>> getAsync()
        {
            using (var context = new ApplicationDbContext(options))
            {
                var posts = await context.posts.Include(pt => pt.posttags).Include(p => p.comments).Include(p => p.likes).ToListAsync();
                return posts.OrderBy(p => p.created).ToList();
            }
        }

        public post itemById(int id)
        {
            using (var context = new ApplicationDbContext(options))
            {
                return context.posts.Include(pt => pt.posttags).Include(p => p.comments).Include(p => p.likes).FirstOrDefault(p => p.ID == id);
            }
        }

        public async Task<post> itemByIdAsync(int id)
        {
            using (var context = new ApplicationDbContext(options))
            {
                return await context.posts.Include(pt => pt.posttags).Include(p => p.comments).Include(p => p.likes).FirstOrDefaultAsync(p => p.ID == id);
            }
        }

        public void update(post item)
        {
            // Обновляем всё, кроме тегов
            using (var context = new ApplicationDbContext(options))
            {
                //var tags = post.tags;
                //post.tags = null;
                context.Update(item);
                context.SaveChanges();

                //post.tags = tags;
            }

            // Обновляем теги
            using (var context = new ApplicationDbContext(options))
            {
                //post postDB = context.posts.Include(t => t.tags).FirstOrDefault(p => p.ID == post.ID);

                //// Работаем с тегами
                //List<tag> новыеТеги = post.tags;
                //List<tag> старыеТеги = postDB.tags;
                //List<tag> наДобавление = новыеТеги.Where(t => t.posts.Count == 0).ToList();
                //List<tag> наУдаление = старыеТеги.Where(x => новыеТеги.All(a => a.ID != x.ID)).ToList();

                //postDB.tags.AddRange(наДобавление);
                //foreach (var t in наУдаление)
                //{
                //    postDB.tags.Remove(t);
                //}

                //await context.SaveChangesAsync();
            }
        }

        public async Task updateAsync(post item)
        {


            // Обновляем всё, кроме тегов
            using (var context = new ApplicationDbContext(options))
            {
                //var tags = post.tags;
                //post.tags = null;
                context.Update(item);
                await context.SaveChangesAsync();

                //post.tags = tags;
            }

            // Обновляем теги
            using (var context = new ApplicationDbContext(options))
            {
                //post postDB = context.posts.Include(t => t.tags).FirstOrDefault(p => p.ID == post.ID);

                //// Работаем с тегами
                //List<tag> новыеТеги = post.tags;
                //List<tag> старыеТеги = postDB.tags;
                //List<tag> наДобавление = новыеТеги.Where(t => t.posts.Count == 0).ToList();
                //List<tag> наУдаление = старыеТеги.Where(x => новыеТеги.All(a => a.ID != x.ID)).ToList();

                //postDB.tags.AddRange(наДобавление);
                //foreach (var t in наУдаление)
                //{
                //    postDB.tags.Remove(t);
                //}

                //await context.SaveChangesAsync();
            }
        }
    }
}
