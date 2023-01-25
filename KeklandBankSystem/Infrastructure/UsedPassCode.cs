using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Utils;

namespace KeklandBankSystem.Infrastructure
{
    public class UsedPassCode
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int PassCodeId { get; set; }
    }
}
