using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model.User
{
    public class TransferModel
    {
        [Required(ErrorMessage = "Обязательная строка")]
        public string NameTo { get; set; }

        public string Comment { get; set; }

        [Range(3, int.MaxValue, ErrorMessage = "Минимальное количество кеклар: 3")]
        [Required(ErrorMessage = "Обязательная строка")]
        public int Value { get; set; }
    }
}
