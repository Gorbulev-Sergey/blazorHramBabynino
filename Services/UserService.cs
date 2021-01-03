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
    public class UsersService : ICRUDstringId<user>
    {
        UserManager<user> userManager;

        public UsersService(UserManager<user> userManager)
        {
            this.userManager = userManager;
        }
        public void add(user item)
        {
            userManager.CreateAsync(item);
        }

        public async Task addAsync(user item)
        {
            await userManager.CreateAsync(item);
        }

        public void delete(user item)
        {
            userManager.DeleteAsync(item);
        }

        public async Task deleteAsync(user item)
        {
            await userManager.DeleteAsync(item);
        }

        public List<user> get()
        {
            return userManager.Users.ToList();
        }

        public async Task<List<user>> getAsync()
        {
            return await userManager.Users.ToListAsync();
        }

        public user itemById(string id)
        {
            return userManager.FindByIdAsync(id).Result;
        }

        public async Task<user> itemByIdAsync(string id)
        {
            return await userManager.FindByIdAsync(id);
        }

        public void update(user item)
        {
            userManager.UpdateAsync(item);
        }

        public async Task updateAsync(user item)
        {
            await userManager.UpdateAsync(item);
        }

        public async Task<List<string>> getUserRolesAsync(user user)
        {
            return (await userManager.GetRolesAsync(user)).ToList();
        }
    }
}
