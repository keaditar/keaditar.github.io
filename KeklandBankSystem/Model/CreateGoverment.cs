using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class CreateGoverment
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string GovermentName { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Information { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string ImageCoverUrl { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string ImageFlagUrl { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string VKurl { get; set; }

        public int Budget { get; set; }
    }
}
