using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class ShopItemModel
    {
        public ShopItem shopItem { get; set; }
        public string Message { get; set; }
        public bool TypeMessage { get; set; }
    }

    public class ShopItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; } // Image
        public string Short_Desc { get; set; } // Краткое описание

        public int Price { get; set; } // Первоначальная цена

        public int Value { get; set; } // Количество

        public string Type { get; set; }
        // type_car, type_home, type_accsessor ( аксуссуары ), type_clothes ( одежда ), type_other ( остальныое )

        public int OrgId { get; set; }
        public int AuthorId { get; set; }
        public int CreateNum { get; set; }
        public bool isActived { get; set; }

        public bool isCaseItem { get; set; }

        public int RareType { get; set; }
        // 0 - обыденная, 1 - дорогая, 2 - редкая, 3 - эпическая, 4 - легендарная, 5 - мистическая

        public int RarePoint { get; set; }
    }

    public class ShopItemUser
    {
        [Key]
        public int Id { get; set; }
        public int ShopItemId { get; set; }
        public int UserId { get; set; }
        public int Value { get; set; }

        [NotMapped]
        public bool isNeactive { get; set; }
    }
}
