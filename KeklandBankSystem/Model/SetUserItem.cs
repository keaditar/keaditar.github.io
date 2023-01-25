using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class SetUserItemModel
    {
        public Infrastructure.User User { get; set; }
        public int ItemId { get; set; }
        public int Col { get; set; }
    }
}
