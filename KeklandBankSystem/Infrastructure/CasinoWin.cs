using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class CasinoWin
    {
        [Key]
        public int Id { get; set; }

        public int WinnerId { get; set; }
        public float Count { get; set; }
        public long Date { get; set; }
    }
}
