﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public class PhotosService
    {
        DbContextOptions<ApplicationDbContext> options;

        public PhotosService(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }

        public void add(imageAlbum item)
        {
            item.images = item.images.ToList().Where(i => !string.IsNullOrEmpty(i.url)).ToList();
            using (var context = new ApplicationDbContext(options))
            {
                context.imageAlbums.Add(item);
                context.SaveChanges();
            }
        }

        public async Task addAsync(imageAlbum item)
        {
            item.images = item.images.ToList().Where(i => !string.IsNullOrEmpty(i.url)).ToList();
            //foreach (var i in item.images)
            //{
            //    if (string.IsNullOrEmpty(i.url)) item.images.Remove(i);
            //}

            using (var context = new ApplicationDbContext(options))
            {
                context.imageAlbums.Add(item);
                await context.SaveChangesAsync();
            }
        }

        public void delete(imageAlbum item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.imageAlbums.Remove(item);
                context.SaveChanges();
            }
        }

        public async Task deleteAsync(imageAlbum item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.imageAlbums.Remove(item);
                await context.SaveChangesAsync();
            }
        }

        public List<imageAlbum> get()
        {
            using (var context = new ApplicationDbContext(options))
            {
                return context.imageAlbums.Include(i => i.images).OrderBy(i=>i.ID).ToList();
            }
        }

        public async Task<List<imageAlbum>> getAsync()
        {
            using (var context = new ApplicationDbContext(options))
            {
                return await context.imageAlbums.Include(i => i.images).OrderBy(i => i.ID).ToListAsync();
            }
        }

        public imageAlbum itemById(int id)
        {
            using (var context = new ApplicationDbContext(options))
            {
                return context.imageAlbums.Include(i => i.images).FirstOrDefault(a => a.ID == id);
            }
        }

        public async Task<imageAlbum> itemByIdAsync(int id)
        {
            using (var context = new ApplicationDbContext(options))
            {
                return await context.imageAlbums.Include(i => i.images).FirstOrDefaultAsync(a => a.ID == id);
            }
        }

        public void update(imageAlbum item)
        {
            using (var context = new ApplicationDbContext(options))
            {
                var album = context.imageAlbums.Include(i => i.images).FirstOrDefault(a => a.ID == item.ID);
                album.images.Clear();
                context.SaveChanges();
            }
            
            item.images = item.images.ToList().Where(i => !string.IsNullOrEmpty(i.url)).ToList();
            using (var context = new ApplicationDbContext(options))
            {
                var album = context.imageAlbums.Include(i => i.images).FirstOrDefault(a => a.ID == item.ID);
                foreach (var i in item.images)
                {
                    i.ID = 0;
                    album.images.Add(i);
                }
                context.SaveChanges();
            }
        }

        public async Task updateAsync(imageAlbum item)
        {            
            update(item);
        }
    }
}
