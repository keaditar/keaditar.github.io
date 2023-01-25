using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class AddUserToJob
    {
        [Required(ErrorMessage = "Обязательная строка.")]
        public string Name { get; set; }

        public OrgJob orgJob { get; set; }
    }
}
