using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class SingleOrganizationModel
    {
        public Organization organization { get; set; }
        public List<ShopItem> LastUserItems { get; set; }
        public GovermentPolitical GovermentPolitical { get; set; }
    }
}
