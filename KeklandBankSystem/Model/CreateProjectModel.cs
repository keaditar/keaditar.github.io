using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class CreateProejcttModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Info { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public int Target { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string AuthorName { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }
    }
}
