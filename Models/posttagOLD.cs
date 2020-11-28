using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Models
{
    [Table(name: "posttagOLD")]
    public class posttagOLD
    {
        [Key]
        public int postsID { get; set; }
        public post post { get; set; } = new post();

        [Key]
        public int tagsID { get; set; }
        public tag tag { get; set; } = new tag();
    }
}
