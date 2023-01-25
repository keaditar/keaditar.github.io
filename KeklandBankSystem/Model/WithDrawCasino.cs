using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class WithDrawCasino
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Coins { get; set; }
    }
}
