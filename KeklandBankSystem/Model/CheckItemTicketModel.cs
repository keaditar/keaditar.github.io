using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class CheckItemTicketModel
    {
        public ShopItem shopItem { get; set; }
        public int Col { get; set; }

        public string IsActive { get; set; }
        public string AdminInformation { get; set; }
    }
}
