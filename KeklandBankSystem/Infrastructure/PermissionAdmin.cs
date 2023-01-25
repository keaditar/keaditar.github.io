using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class PermissionAdmin
    {
        [Key]
        public int Id { get; set; }

        public string RoleName { get; set; }

        public bool CheckTickets { get; set; }
        public bool CheckItems { get; set; }
        public bool CheckNews { get; set; }
        public bool CheckGoverments { get; set; }
        public bool CheckProjects { get; set; }
        public bool CheckOrganization { get; set; }
        public bool GetStatistics { get; set; }
        public bool CreateArticles { get; set; }
        public bool ShowAdminStatistics { get; set; }
        public bool GenerateRegCodes { get; set; }
        public bool CreateOrganization { get; set; }
        public bool CreateProject { get; set; }
        public bool CreatePromoCode { get; set; }
        public bool CreateGoverment { get; set; }
        public bool EconomyPanel { get; set; }
        public bool EditGoverment { get; set; }
        public bool ChangeOrganizationInfo { get; set; }
        public bool ChangeOrganizationEconomy { get; set; }
        public bool ChangeUserInfo { get; set; }
        public bool ChangeUserEconomy { get; set; }
        public bool ChangeUserDeposit { get; set; }
        public bool AddItemUser { get; set; }
        public bool EditItem { get; set; }
        public bool CreateItemOrg { get; set; }
        public bool DeleteItem { get; set; }
        public bool EditZamOrg { get; set; }
        public bool DeleteOrganization { get; set; }
        public bool JobSettings { get; set; }
        public bool DeleteTransaction { get; set; }
        public bool ShowAllOrgOrUserTransaction { get; set; }
    }

    public enum AdminPermission
    {
        CheckTickets = 0,
        CheckItems = 1,
        CheckNews = 2,
        CheckGoverments = 3,
        CheckProjects = 4,
        CheckOrganization = 5,
        GetStatistics = 6, // Все пользователи и все товары
        CreateArticles = 7,
        ShowAdminStatistics = 8,
        GenerateRegCodes = 9,
        CreateOrganization = 10,
        CreateProject = 11,
        CreatePromoCode = 12,
        CreateGoverment = 13,
        EconomyPanel = 14,
        EditGoverment = 15,
        ChangeOrganizationInfo = 16,
        ChangeOrganizationEconomy = 17,
        ChangeUserInfo = 18,
        ChangeUserEconomy = 19,
        ChangeUserDeposit = 20,
        AddItemUser = 21,
        EditItem = 22,
        CreateItemOrg = 23,
        DeleteItem = 24,
        EditZamOrg = 25,
        DeleteOrganization = 26,
        JobSettings = 27,
        DeleteTransaction = 28,
        ShowAllOrgOrUserTransaction = 29
    }
}
