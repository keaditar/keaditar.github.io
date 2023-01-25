using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }

        public string MiniText { get; set; }
        public string HtmlText { get; set; }
        public long Date { get; set; }

        public string ImageUrl { get; set; }
    }

    public class ArticlesModel
    {
        public string MiniText { get; set; }
        public string HtmlText { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string ImageUrlString { get; set; }
    }
}
