using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeklandBankSystem.Infrastructure;

namespace KeklandBankSystem.Model.User
{
    public class BalanceModel
    {
        public Infrastructure.User user { get; set; }

        public List<Transaction> TransList { get; set; }
    }
}
