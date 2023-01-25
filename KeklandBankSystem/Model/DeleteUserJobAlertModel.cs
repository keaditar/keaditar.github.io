using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class DeleteUserJobAlertModel
    {
        public int OrganizationId { get; set; }
        public int OrganizationJobId { get; set; }
        public int UserId { get; set; }
    }
}
