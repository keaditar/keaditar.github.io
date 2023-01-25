using KeklandBankSystem.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<BankContext>
    {
        public BankContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankContext>();

            var connectionstring = Environment.GetEnvironmentVariable("API_ConnectionString");

            optionsBuilder.UseNpgsql(connectionstring);

            return new BankContext(optionsBuilder.Options);
        }
    }

    public class BankContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<RegCode> RegCodes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<SystemMain> SystemMain { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<GovermentPolitical> Goverments { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<ShopItemUser> ShopItemUser { get; set; }
        public DbSet<ImageSystem> ImageSystems { get; set; }

        public DbSet<Ads> Ads { get; set; }
        public DbSet<Articles> Articles { get; set; }

        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<OrgJob> OrgJobs { get; set; }
        public DbSet<OrgJobUser> OrgJobUser { get; set; }
        public DbSet<ItemStatistic> ItemStatistics { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectSender> ProjectSenders { get; set; }
        public DbSet<CasinoWin> CasinoWins { get; set; }
        public DbSet<TradeItemShop> TradeItems { get; set; }

        public DbSet<PermissionAdmin> PermissionAdmins { get; set; }

        // ent

        public DbSet<EntityTicketGoverment> EntityTicketGoverments { get; set; }
        public DbSet<EntityTicketOrganization> EntityTicketOrganizations { get; set; }
        public DbSet<EntityTicketProject> EntityTicketProjects { get; set; }
        public DbSet<EntityTicketInformation> EntityTicketInformations { get; set; }

        // end ent

        public DbSet<PassCode> PassCodes { get; set; }
        public DbSet<UsedPassCode> UsedPassCodes { get; set; }

        public DbSet<WeithLevel> WeithLevel { get; set; }
        public DbSet<News> News { get; set; }

        public BankContext(DbContextOptions<BankContext> options) : base(options){ }
        public BankContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();
                options.UseMySql(config.GetValue<string>($"ConnectionStrings:{Program.SystemConfiguration}"));
            }
        }*/
    }
}
