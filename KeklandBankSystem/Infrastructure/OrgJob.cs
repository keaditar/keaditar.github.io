using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class OrgJob
    {
        [Key]
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public int PayDay { get; set; }
    }
}
