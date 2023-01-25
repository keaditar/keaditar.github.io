using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class CheckTicketModel
    {
        public Ticket ticket { get; set; }
        public int NewValue { get; set; }

        public Infrastructure.User user { get; set; } 

        public string AdminComment { get; set; }

        public string NewStatus { get; set; }
        public string[] NewStatuses = new[] { "Отказать", "Разрешить" };

        public bool OutBank { get; set; }

        public List<string> ImagesUrl { get; set; }
    }
}
