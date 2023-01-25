using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class BankTransaction
    {
        [Key]
        public int Id { get; set; }

        public long Date { get; set; }

        public int Value { get; set; } // Количество
        public string Text { get; set; } // Текст

        public int Id1 { get; set; } // От пользователя 
        public int BankId2 { get; set; } // В банк

        public int BankId1 { get; set; } // От банка
        public int Id2 { get; set; } //  к пользователю
    }
}
