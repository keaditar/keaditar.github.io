using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string MiniInformation { get; set; }

        public string Url { get; set; }

        public int Rare { get; set; }
        // 6,5,4,3

        public int ShowsDays { get; set; }
        
        // 14, 9, 5, 2

        public string Type { get; set; }
        // type_ok, type_timing

    }

    public class NewsModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string MiniInformation { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Url { get; set; }
    }

    public class CheckNewsModel
    {
        public bool isOk { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string MiniInformation { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Url { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public int Rare { get; set; }
    }
}
