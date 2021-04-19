using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace razorHramBabynino.Pages.Tests
{
    public interface IContactsService
    {
        contacts contacts { get; set; }
        void addScheduleString(KeyValuePair<string, string> pare);
        void addPhonesString(KeyValuePair<string, string> pare);
        void addSocialsString(KeyValuePair<string, string> pare);
        void replaceMap(KeyValuePair<string, string> pare);
    }

    public class ContactsService : IContactsService
    {
        public contacts contacts
        {
            get
            {
                using (StreamReader reader = new StreamReader(new FileStream(path: "contacts.json", mode: FileMode.OpenOrCreate)))
                {
                    return JsonConvert.DeserializeObject<contacts>(reader.ReadToEnd());
                }
            }
            set
            {
                using (StreamWriter writer = new StreamWriter(new FileStream(path: "contacts.json", mode: FileMode.Truncate)))
                {
                    writer.Write(JsonConvert.SerializeObject(value));
                }
            }
            
        }
        public void addScheduleString(KeyValuePair<string, string> pare)
        {
            var new_contacts = contacts;
            new_contacts.schedule.Add(pare.Key, pare.Value);
            contacts = new_contacts;
        }

        public void addPhonesString(KeyValuePair<string, string> pare)
        {
            var new_contacts = contacts;
            new_contacts.phones.Add(pare.Key, pare.Value);
            contacts = new_contacts;
        }

        public void addSocialsString(KeyValuePair<string, string> pare)
        {
            var new_contacts = contacts;
            new_contacts.socials.Add(pare.Key, pare.Value);
            contacts = new_contacts;
        }

        public void replaceMap(KeyValuePair<string, string> pare)
        {
            var new_contacts = contacts;
            new_contacts.map = pare;
            contacts = new_contacts;
        }

        
    }
}
