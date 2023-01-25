using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class ImageSystem
    {
        [Key]
        public int Id { get; set; }
        public string GenerateName { get; set; }
        public string MainPath { get; set; } // весь путь
        public string ScreePath { get; set; } // для html
        public int Type { get; set; }
        // -1 = non-deleted, x num - deleted image from x days
    }
}
