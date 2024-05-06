using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeSession
{
    internal class Book
    {
        public int ID { get; set; }
        [Required]
        public string Titile { get; set; } 
        public string? Description { get; set; }
        public DateTime DatePuplish { get; set; }

    }
}
