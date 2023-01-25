using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        // Акивные роли:
        // Owner ( +test )
        // Administrator  ( +test )
        // User
        // Tester
        // Moderator ( +test )

        public int UserId { get; set; }
        public string RoleName { get; set; }

    }
}
