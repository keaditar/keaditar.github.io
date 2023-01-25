using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class EditGovermentPolitical
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Information { get; set; }
        public IFormFile ImageUrlCover { get; set; }
        public string ImageStringUrlCover { get; set; }
        public IFormFile ImageUrlFlag { get; set; }
        public string ImageStringUrlFlag { get; set; }
        [Required(ErrorMessage = "Обязательная строка.")]
        public string LeaderName { get; set; }
        public int FreeOrganizationCreateCount { get; set; } // admin

        [Required(ErrorMessage = "Обязательная строка.")]
        public int TaxesForOrganization { get; set; }

        public string VKurl { get; set; }
    }
}
