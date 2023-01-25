using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model.User
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Обязательная строка")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательная строка")]
        public string Password { get; set; }
    }
}
