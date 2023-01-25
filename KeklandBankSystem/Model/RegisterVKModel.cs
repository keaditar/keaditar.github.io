using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class RegisterVKModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public long VKUid { get; set; }
        public string Photo { get; set; }
    }
}
