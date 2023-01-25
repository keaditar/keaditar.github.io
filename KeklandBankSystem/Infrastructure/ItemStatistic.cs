using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class ItemStatistic
    {
        [Key]
        public int Id { get; set; }
        public long Date { get; set; }
        public int ShopItemId { get; set; }
        public int BuyCount { get; set; }
    }
}
