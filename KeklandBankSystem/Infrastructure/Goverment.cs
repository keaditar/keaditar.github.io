using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class SystemMain
    {
        [Key]
        public int Key { get; set; }

        public string PresidentName { get; set; }

        public float Stavka { get; set; } // 3% - Налог на передачу денег, доступно только кекцарции
        public float Stavka_Nalog { get; set; } // 3% каждые 5 дней. доступно только кекцарции

        public float Stavka_Vlojen { get; set; } // 2% депозит, доустпено только кекцарции
        public int MoneyFromLike { get; set; } // 300, доступно только кекцарции
        public float Nalog_Item { get; set; } // 5% 

        public int Nalog_Project { get; set; } // 20%
        public int UserGetMoneyProject { get; set; } // 20%

        public bool SiteIsOn { get; set; }
        public int Skrutka { get; set; }

        public bool CasinoIsOn { get; set; }
        public bool CasesIsOn { get; set; }
    }

    public class GovermentPolitical
    {
        [Key]
        public int Id { get; set; }
        public int MainOrganizationGovermentId { get; set; }

        public string Name { get; set; }
        public string Information { get; set; }
        public string ImageCoverUrl { get; set; }
        public string ImageFlagUrl { get; set; }

        public int LeaderId { get; set; }
        public int FreeOrganizationCreateCount { get; set; }
        public int TaxesForOrganization { get; set; }

        public int AllOrganizationBalance { get; set; }

        public int DaysGovermentTaxes { get; set; }
        public string VKurl { get; set; }

    }
}
