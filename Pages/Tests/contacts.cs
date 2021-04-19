using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Pages.Tests
{
    public class contacts
    {
        public Dictionary<string, string> schedule { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> phones { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> socials { get; set; } = new Dictionary<string, string>();
        public KeyValuePair<string, string> map { get; set; } = new KeyValuePair<string, string>();
    }
}
