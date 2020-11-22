using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public interface IPostsService
    {
        List<post> posts();
        Task<List<post>> postsAsync();        
        Task<post> post(int id);
        string create(post post);
        Task update(post post);
        Task delete(int id);

        event Action Фильтр_изменён;
        void Изменить_фильтр();
    }

    public class PostsServices : IPostsService
    {
        DbContextOptions<ApplicationDbContext> options;        

        public PostsServices(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
        public List<post> posts()
        {
            using (var context = new ApplicationDbContext(options))
            {
                //var posts = context.posts.Include(p => p.comments).Include(p => p.likes).Include(p => p.tags).ToList();
                var posts = context.posts.Where(p=>p.published==true).Include(pt=>pt.posttags).Include(p => p.comments).Include(p => p.likes).ToList();
                return posts.OrderBy(p => p.created).Reverse().ToList();
            }
        }
        public async Task<List<post>> postsAsync()
        {
            using (var context = new ApplicationDbContext(options))
            {
                //var posts = await context.posts.Include(p => p.comments).Include(p => p.likes).Include(p => p.tags).ToListAsync();
                var posts = await context.posts.Where(p => p.published == true).Include(pt => pt.posttags).Include(p => p.comments).Include(p => p.likes).ToListAsync();
                return posts.OrderBy(p=>p.created).Reverse().ToList();
            }
        }
        public async Task<post> post(int id)
        {
            using (var context = new ApplicationDbContext(options))
            {
                return await context.posts.Where(p => p.published == true).Include(pt => pt.posttags).Include(p => p.comments).Include(p => p.likes).FirstOrDefaultAsync(p=>p.ID==id);
            }
        }

        public string create(post post)
        {
            if (post != null)
            {
                //var tags = post.tags;
                //post.tags = null;

                using (var context = new ApplicationDbContext(options))
                {
                    context.posts.Add(post);
                    //await context.SaveChangesAsync();

                    //context.posts.Include(t => t.tags).FirstOrDefault(p => p.Equals(post)).tags.AddRange(tags);
                    context.SaveChangesAsync();

                    return "Сохранена";
                }
            }
            return "Не сохранена";
        }

        public async Task update(post post)
        {

            // Обновляем всё, кроме тегов
            using (var context = new ApplicationDbContext(options))
            {
                //var tags = post.tags;
                //post.tags = null;
                context.Update(post);
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

        public async Task delete(int id)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.posts.Remove(context.posts.FirstOrDefault(p => p.ID == id));
                await context.SaveChangesAsync();
            }
        }


        public event Action Фильтр_изменён;
        public void Изменить_фильтр()
        {
            Фильтр_изменён?.Invoke();
        }
    }
}
