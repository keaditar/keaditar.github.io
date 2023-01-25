using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class Statistic
    {
        [Key]
        public int Id { get; set; }

        public long Date { get; set; }
        public int Spent { get; set; } // Потрачено
        public int Recd { get; set; } // Получено

        public int ViewUser { get; set; } // Просмотр
        public int UniqUser { get; set; }
        public int SpentMoneyAll { get; set; } // Вообщем потрачено денег
    }
}
