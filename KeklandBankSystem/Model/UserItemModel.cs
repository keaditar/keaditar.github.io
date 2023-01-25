using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class UserItemModel
    {
        public Infrastructure.User user { get; set; }
        public List<Infrastructure.ShopItemUser> items { get; set; }
        public string Message { get; set; }
        public bool TypeMessage { get; set; }

        // 1 - ok 0 - error
    }


    public class TradeShopItem
    {
        public Infrastructure.ShopItem item { get; set; }
        public Infrastructure.TradeItemShop itemShop { get; set; }
    }
}
