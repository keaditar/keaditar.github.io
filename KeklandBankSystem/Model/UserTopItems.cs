using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class UserTopItems
    {
        public int userId { get; set; }
        public float ItemPoints { get; set; }
    }
}
