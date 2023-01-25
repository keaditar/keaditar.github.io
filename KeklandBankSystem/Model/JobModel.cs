using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class JobModel
    {
        public List<OrgJob> orgJobs { get; set; }
        public int id { get; set; }
    }
}
