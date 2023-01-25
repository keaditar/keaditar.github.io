using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class TradeItemShop
    {
        [Key]
        public int Id { get; set; }

        public int ShopItemId { get; set; }

        public int newSum { get; set; }
        public int Count { get; set; }
        public string AddedInformation { get; set; }
        public int SellerId { get; set; }
    }
}
