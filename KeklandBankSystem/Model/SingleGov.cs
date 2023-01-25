using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class SingleGov
    {
        public GovermentPolitical GovermentPolitical { get; set; }
        public List<Organization> OrganizationsList { get; set; }
    }

    public class GovermentStatistics
    {
        public GovermentPolitical gov { get; set; }
        public int Balance { get; set; }
    }
}
