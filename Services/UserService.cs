using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public class UsersService : ICRUDstringId<user>
    {
        DbContextOptions<ApplicationDbContext> options;

        public UsersService(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
        public void add(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.Users.Add(item);
                context.SaveChanges();
            }
        }

        public async Task addAsync(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                await context.Users.AddAsync(item);
                await context.SaveChangesAsync();
            }
        }

        public void delete(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.Users.Remove(item);
                context.SaveChanges();
            }
        }

        public async Task deleteAsync(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.Users.Remove(item);
                await context.SaveChangesAsync();
            }
        }

        public List<user> get()
        {
            using (var context=new ApplicationDbContext(options))
            {
                return context.Users.ToList();
            }
        }

        public async Task<List<user>> getAsync()
        {
            using (var context = new ApplicationDbContext(options))
            {
                return await context.Users.ToListAsync();
            }
        }

        public user itemById(string id)
        {
            using (var context= new ApplicationDbContext(options))
            {
                return context.Users.FirstOrDefault(u=>u.Id==id);
            }
        }

        public async Task<user> itemByIdAsync(string id)
        {
            using (var context = new ApplicationDbContext(options))
            {
                return await context.Users.FirstOrDefaultAsync(u => u.Id == id);
            }
        }

        public void update(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.Users.Update(item);
                context.SaveChanges();
            }
        }

        public async Task updateAsync(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.Users.Update(item);
                await context.SaveChangesAsync();
            }
        }
    }
}
