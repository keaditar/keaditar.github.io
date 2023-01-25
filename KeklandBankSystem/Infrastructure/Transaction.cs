using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public long Date { get; set; }

        public int Value { get; set; } // Количество
        public string Text { get; set; } // Текст

        public int Id1 { get; set; }

        public int Id2 { get; set; }
    }

    public class AllUserTrans
    {
        public int id { get; set; }
        public List<Transaction> list { get; set; }
    }
    public class AllOrgTrans
    {
        public int id { get; set; }
        public List<BankTransaction> list { get; set; }
    }
}
