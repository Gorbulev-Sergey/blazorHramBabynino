﻿using Microsoft.EntityFrameworkCore;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    interface ITagsService
    {
        List<tag> tags();
        Task add(tag tag);
        Task edit(tag tag);
        Task remove(tag tag);
    }

    public class TagsService : ITagsService
    {
        DbContextOptions<ApplicationDbContext> options;
        public TagsService(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }

        public List<tag> tags()
        {
            List<tag> ListTags = new List<tag>();
            using (var context = new ApplicationDbContext(options))
            {                
                ListTags.AddRange(context.tags);
                //ListTags.Insert(0, ListTags.Last());
                //ListTags.RemoveAt(ListTags.Count-1);                
            }
            return ListTags;
        }
        public async Task add(tag tag)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (tag != null && !String.IsNullOrWhiteSpace(tag.name))
                {
                    tag.description = tag.name;
                    context.tags.Add(tag);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task edit(tag tag)
        {
            using (var context = new ApplicationDbContext(options))
            {
                context.tags.Update(tag);
                await context.SaveChangesAsync();
            }
        }

        public async Task remove(tag tag)
        {
            using (var context = new ApplicationDbContext(options))
            {
                if (tag != null)
                {
                    context.tags.Remove(tag);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
