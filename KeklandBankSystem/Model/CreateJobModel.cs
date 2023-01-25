using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class CreateJobModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public int PayDay { get; set; }
    }
}
