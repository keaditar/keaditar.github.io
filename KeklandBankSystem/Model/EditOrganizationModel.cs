using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class EditOrganizationModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }

        public string NewStatus { get; set; }
        public string[] NewStatuses = new[] { "Заморожено", "Работает", "Выключено" };
        // status_frozzen - заморожено; status_ok - работает; status_off - выключено

        public string VkUrl { get; set; }

        public int Influence { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Short_Desc { get; set; } // Краткое описание

        [Required(ErrorMessage = "Обязательная строка.")]
        public int Balance { get; set; }
    }
}
