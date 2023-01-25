using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class CreatePassCodeModel
    {
        public PassCode passcode { get; set; }
        public List<PassCode> listPassCodes { get; set; }
    }
}
