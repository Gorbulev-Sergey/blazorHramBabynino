using Newtonsoft.Json;
using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public interface IAppSettingsService
    {
        appsettings settings { get; set; }
    }

    public class AppSettingsService : IAppSettingsService
    {
        public appsettings settings {
            get
            {
                using (StreamReader reader = new StreamReader(new FileStream(path: "appsettings.json", mode: FileMode.OpenOrCreate)))
                {
                    return JsonConvert.DeserializeObject<appsettings>(reader.ReadToEnd());
                }
            }
            set
            {
                using (StreamWriter writer = new StreamWriter(new FileStream(path: "appsettings.json", mode: FileMode.Truncate)))
                {
                    writer.Write(JsonConvert.SerializeObject(value));
                }
            }
        }
    }
}
