using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model.User
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Обязательная строка.")]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "Код должен быть 10-значный.")]
        //public string RegCode { get; set; }

        [RegularExpression(@"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)", ErrorMessage = "Ссылка введена неправильно")]
        public string VkUrl { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }
    }

    public class EditUserModelSettings
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }

        public string Password { get; set; }

        //[Required(ErrorMessage = "Обязательная строка.")]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "Код должен быть 10-значный.")]
        //public string RegCode { get; set; }

        [RegularExpression(@"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)", ErrorMessage = "Ссылка введена неправильно")]
        public string VkUrl { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }
    }
}
