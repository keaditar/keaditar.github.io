using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } // Основное имя
        public string Password { get; set; }

        public int Money { get; set; }

        public bool NonViewTrans { get; set; }

        public bool IsArrested { get; set; }
        
        public float Coins { get; set; }
        public bool HaveLegendary { get; set; }
        
        public int Welfare { get; set; }
        public int WelfareItem { get; set; }

        public int PremiumDay { get; set; }

        public string ImageUrl { get; set; }
        
        public bool IsUniqView { get; set; }

        public int newViewEntity { get; set; } // todo

        // vk

        public long  VKUniqId { get; set; }

    }

    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Info { get; set; }

        public int Cost { get; set; }

        public int AddedHealth { get; set; }
        public int AddedDamage { get; set; }
        public int AddedIntelect { get; set; }

        public string Type { get; set; }
    }

    public class UserItem
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public int UserId { get; set; }
    }

    public class BotUser
    {
        [Key]
        public int Id { get; set; }

        public long VkId { get; set; }

        // Bot statistics

        public int Gold { get; set; }

        public string Titul { get; set; }
        // black - чёрнь, robo - рабочие, arist - аристократия, king - король, admin - администратор

        // harakst

        public int BaseHealth { get; set; } // Базовое здоровье
        public int BaseDamage { get; set; } // Базовый урон
        public int BaseIntellect { get; set; } // Базовый интелект

        // EQUP

        public int Head { get; set; }
        public int Body { get; set; }
        public int Legs { get; set; }
        public int Weapon { get; set; }
        public int Accesuar { get; set; }

    }
}
