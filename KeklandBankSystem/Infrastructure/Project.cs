using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Info { get; set; }
        public int Target { get; set; }
        public int Balance { get; set; }
        public int AuthorId { get; set; }

        public string ImageUrl { get; set; }
    }
}
