using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concencrate
{
    public class NewsLater
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public bool EmailStatus { get; set; }
    }
}
