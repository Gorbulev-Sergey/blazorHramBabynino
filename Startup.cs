using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using razorHramBabynino.Data;
using razorHramBabynino.Models;
using razorHramBabynino.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<user, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();
            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    IConfigurationSection googleAuthNSection =
                        Configuration.GetSection("Authentication:Google");

                    options.ClientId = "690639073976-4iho06or9f2nhcmh7astsan11lvvdgb9.apps.googleusercontent.com";
                    options.ClientSecret = "EldG9O1qTxFzACRdFgkag-PZ";
                })
                .AddVkontakte(options =>
                {
                    IConfigurationSection vkAuthNSection =
                        Configuration.GetSection("Authentication:Vk");

                    options.ClientId = "7609221";
                    options.ClientSecret = "QGB9vZBryvr7gpEXB7vK";
                });
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddTransient<IPostsService, PostsServices>();
            services.AddTransient<ITagsService, TagsService>();
            services.AddTransient<IPostTagsService, PostTagsService>();
            services.AddTransient<ICommentsService, CommentsService>();
            services.AddTransient<ILikesService, LikesService>();
            services.AddTransient<ISchedulesService, ScheduleService>();
            services.AddTransient<IPhotosService, PhotosService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/Shared/_Host");
            });
        }
    }
}
