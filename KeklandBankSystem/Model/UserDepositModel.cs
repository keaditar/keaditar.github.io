using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class UserDepositModel
    {
        public Infrastructure.Deposit dep { get; set; }
        public Infrastructure.User user { get; set; }
    }
}
