using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class SendMoneyProjectModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public int Money { get; set; }

        public int ProjectId { get; set; }
    }
}
