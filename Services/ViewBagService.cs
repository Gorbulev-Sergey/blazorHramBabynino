using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public class ViewBagService
    {
        public string PageTitle { get; set; }
        public string BackUrl { get; set; } = "/posts/новости и объявления";
    }
}
