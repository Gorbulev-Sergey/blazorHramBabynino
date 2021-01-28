using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public class ViewBagService
    {
        string _PageTitle="";
        public string PageTitle {
            get => _PageTitle;
            set
            {
                _PageTitle = value;
            }
        }
        public string BackUrl { get; set; }
    }
}
