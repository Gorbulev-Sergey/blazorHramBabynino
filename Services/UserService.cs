using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public class UserService
    {
        DbContextOptions<ApplicationDbContext> options;

        public UserService(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
        
        public List<user> getAll()
        {
            List<user> users = new List<user>();
            using (var context=new ApplicationDbContext(options))
            {
                users = context.AspNetUsers.ToList();
            }
            return users;
        }

        public user itemById(string id)
        {
            user user = new user();
            using (var context = new ApplicationDbContext(options))
            {
                user = context.AspNetUsers.FirstOrDefault(u=>u.Id==id);
            }
            return user;
        }

        public List<IdentityRole> rolesAll()
        {
            List<IdentityRole> roles = new List<IdentityRole>();
            using (var context = new ApplicationDbContext(options))
            {
                roles = context.ASPNetRoles.ToList();
            }
            return roles;
        }

        public List<string> rolesById(string userId)
        {
            List<string> rolesId = new List<string>();
            List<string> roles = new List<string>();
            using (var context = new ApplicationDbContext(options))
            {
                rolesId = context.ASPNetUserRoles.Where(u => u.UserId == userId).Select(r=>r.RoleId).ToList();
                foreach(var id in rolesId)
                {
                    roles.Add(context.ASPNetRoles.FirstOrDefault(r => r.Id == id).Name);
                }            
            }
            
            return roles;
        }

        public void add(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (item != null)
                {
                    context.AspNetUsers.Add(item);
                    context.SaveChanges();
                }
            }
        }

        public void delete(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (item != null)
                {
                    context.AspNetUsers.Remove(item);
                    context.SaveChanges();
                }
            }
        }            

        public void update(user item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (item != null)
                {
                    context.AspNetUsers.Update(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
