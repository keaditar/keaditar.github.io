using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Utils;

namespace KeklandBankSystem.Infrastructure
{
    public class PassCode
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }
        
        public string Type { get; set; }

        public string Value { get; set; }
        public int Count { get; set; }
    }
}
