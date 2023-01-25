using KeklandBankSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Model
{
    public class IndexPanelForms
    {
        public List<GovermentPolitical> allGovs { get; set; }

        public Statistic LastStatistics { get; set; }

        public string BigAds { get; set; }
        public string SmallAds { get; set; }

        public string BugUrl { get; set; }
        public string SmallUrl { get; set; }

        // News

        public List<Articles> LastArticles { get; set; }
    }
}
