using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class ErrorModel
    {
        public string UrlVk { get; set; }

        public int ErrorCode { get; set; }
    }
}
