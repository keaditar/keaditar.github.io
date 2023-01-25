using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class DepostModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public int Col { get; set; }

        public int UserId { get; set; }
    }
}
