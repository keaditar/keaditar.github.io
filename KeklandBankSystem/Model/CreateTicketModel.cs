using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class TransferOrgToOrgModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string OrgName { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public int Count { get; set; }

        public int orgId { get; set; }
    }

    public class CreateTicketModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public int Value { get; set; }
        public string Text { get; set; }
        public IFormFileCollection ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }
    }

    public class CreateAdModel
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public int Value { get; set; }
        public bool isBigger { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }
        public bool UserIsPrem { get; set; }

        [Required(ErrorMessage = "Обязательная строка.")]
        public string Url { get; set; }
    }
}
