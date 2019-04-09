using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APITddDemo.Models
{
    public class Project
    {
        [Key]
        public int ProjId { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
    }
}
