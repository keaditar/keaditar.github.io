using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class CreateItemModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Short_Desc { get; set; } // Краткое описание

        [Required(ErrorMessage = "Обязательная строка.")]
        public int Price { get; set; } // Первоначальная цена

        [Required(ErrorMessage = "Обязательная строка.")]
        public int Count { get; set; } // Количество

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Type { get; set; } // Количество

        [Required(ErrorMessage = "Обязательная строка.")]
        public int CreateNum { get; set; } // Себестоимость

        public int Id { get; set; }
    }
}
