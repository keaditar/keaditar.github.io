using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class Ads
    {
        [Key]
        public int Id { get; set; }

        // Каждые 30 минут на сайте меняеться реклама, и береться рандомно из всех доступных реклам, есть два типа рекламы
        // Каждый раз когда меняеться реклама, их возможности уменьшаеться на один
        // Можно купить минимум на 1 раз по 30 минут, максимум на 30 дней.
        // есть два типа рекламы, большой баннер и баннер поменьше
        // В день показываеться 48 раз рекламы
        // Стоимость маленького баннера - 400 на 30 минут, Стоимость большого баннера - 520.
        // С премиумом ты платишь - 300 и 450
        // Размер большое X X
        // Размер малового X X

        public string ImageUrl { get; set; } // Основная картинка
        public bool isBigger { get; set; } // Большой ли баннер?
        public int View { get; set; } // Сколько показов осталось
        public string Url { get; set; }
        public int CreatorId { get; set; } // Кто создал ( ну на всякий )
    }
}
