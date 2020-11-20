using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    interface IPhotosService
    {
        Task<List<imageAlbum>> imageAlbums();
        Task<imageAlbum> imageAlbum(int id);
    }

    public class PhotosService : IPhotosService
    {
        DbContextOptions<ApplicationDbContext> _options;

        public PhotosService(ApplicationDbContext context, DbContextOptions<ApplicationDbContext> options)
        {
            _options = options;
        }
        
        public async Task<List<imageAlbum>> imageAlbums()
        {
            using (var context=new ApplicationDbContext(_options))
            {
                return await context.imageAlbums.Include(i => i.images).ToListAsync();
            }                
        }
        public async Task<imageAlbum> imageAlbum(int id)
        {
            using (var context = new ApplicationDbContext(_options))
            {
                return await context.imageAlbums.Include(i => i.images).FirstOrDefaultAsync(a => a.ID == id);
            }            
        }
    }
}
