using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public string Status { get; set; } 
        // status_ok - ok; status_declaim - no ok; status_timing - ожидайте

        public long Date { get; set; }

        public int Value { get; set; }
        public string Text { get; set; }

        public string AdminComment { get; set; }
        public string Images { get; set; }
    }
}
