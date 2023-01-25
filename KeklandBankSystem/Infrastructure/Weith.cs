using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class WeithLevel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } // Имя уровня
    }
}
