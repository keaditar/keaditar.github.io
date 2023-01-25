using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class WeithUser
    {
        public WeithLevel MyLevel { get; set; }
        public WeithLevel NextLevel { get; set; }
        public int Weith { get; set; }
    }
}
