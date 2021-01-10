﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Models
{
    [Table(name: "tags")]
    public class tag
    {
        public int ID { get; set; }
        [Display(Name = "Тег")]
        public string text { get; set; }

        [DataType(DataType.Date)]
        public DateTime created { get; set; } = DateTime.Now;

        public List<post> posts { get; set; } = new List<post>();
    }
}
