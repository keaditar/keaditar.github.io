using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        public int AdminId { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; } // Image
        public string Status { get; set; }
        // status_frozzen - заморожено; status_ok - работает; status_off - выключено

        public string VkUrl { get; set; }

        public string Short_Desc { get; set; } // Краткое описание
        public int Influence { get; set; } // Сколько прибавляется денег, раз в три дня ( т.е финансирование банка )

        public int Balance { get; set; }

        public bool isBuy { get; set; } // Куплена ли организация?
        public bool isZacrep { get; set; } // Закреплена ли?

        public int Zam1Name { get; set; } // 1 заместитель
        public int Zam2Name { get; set; } // 2 заместитель

        public string SpecialId { get; set; } // для крутых организаций
        public int GovermentId { get; set; } // -1 = Nuetral

    }
}
