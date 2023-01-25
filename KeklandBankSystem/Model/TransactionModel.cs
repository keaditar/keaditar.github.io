using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model.User
{
    public class TransactionModel
    {
        public Infrastructure.User InUser { get; set; }
        public Infrastructure.User ToUser { get; set; }
        public int Value { get; set; }
    }
}
