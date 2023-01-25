using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class TransferOrganizationModel
    {
        public int orgId { get; set; }
        public string Comment { get; set; }

        [Range(3, int.MaxValue, ErrorMessage = "Минимальное количество кеклар: 3")]
        [Required(ErrorMessage = "Обязательная строка")]
        public int Value { get; set; }
    }
}
