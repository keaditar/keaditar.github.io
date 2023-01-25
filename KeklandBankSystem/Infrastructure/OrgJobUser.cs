﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class OrgJobUser
    {
        [Key]
        public int Id { get; set; }
        public int OrgJobId { get; set; }
        public int UserId { get; set; }
    }
}
