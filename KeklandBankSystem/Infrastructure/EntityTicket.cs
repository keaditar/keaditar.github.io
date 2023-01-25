using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class EntityTicketInformation
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Text { get; set; }
        public long Date { get; set; }
        public string Status { get; set; }
        public string AdminInformation { get; set; }

        public bool IsItemConf { get; set; }
    }

    public class EntityTicketProject
    {
        [Key]
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public string ProjectName { get; set; }

        public string ImageUrl { get; set; }
        public string Information { get; set; }
        public int Target { get; set; }
    }

    public class EntityTicketProjectModel
    {
        public List<EntityTicketInformation> lastTickets { get; set; }
        public EntityTicketProject ticketProj { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }
    }

    public class AdminEntityProjectTicket
    {
        public int ProjId { get; set; }
        public bool isOk { get; set; }
        public List<EntityTicketInformation> lastTickets { get; set; }
        public string image { get; set; }
        public string ProjectName { get; set; }
        public string Information { get; set; }
        public int Target { get; set; }
        public int AuthorId { get; set; }
        public string AdminInformation { get; set; }

    }

    // org

    public class EntityTicketOrganization
    {
        [Key]
        public int Id { get; set; }

        public int CreatorId { get; set; }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string VKUrl { get; set; }
        public string Information { get; set; }
    }

    public class EntityTicketOrganizationModel
    {
        public List<EntityTicketInformation> lastTickets { get; set; }
        public EntityTicketOrganization ticketOrg { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string ImageStringUrl { get; set; }
    }

    public class AdminEntityOrganizationTicket
    {
        public int OrgId { get; set; }
        public bool isOk { get; set; }
        public List<EntityTicketInformation> lastTickets { get; set; }
        public string Name { get; set; }
        public string image { get; set; }
        public string VKUrl { get; set; }
        public string Information { get; set; }
        public int AuthorId { get; set; }
        public int Influence { get; set; }
        public string AdminInformation { get; set; }

    }

    // gov

    public class EntityTicketGoverment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public string VKUrl { get; set; }
        public string Information { get; set; }

        public string BGUrl { get; set; }
        public string FlagUrl { get; set; }
    }

    public class EntityTicketGovermentModel
    {
        public List<EntityTicketInformation> lastTickets { get; set; }
        public EntityTicketGoverment ticketGov { get; set; }

        public IFormFile ImageUrlBG { get; set; }
        public string ImageStringUrlBG { get; set; }

        public IFormFile ImageUrlFlag { get; set; }
        public string ImageStringUrlFlag { get; set; }
    }

    public class AdminEntityGovermentTicket
    {
        public int GovId { get; set; }
        public bool isOk { get; set; }
        public List<EntityTicketInformation> lastTickets { get; set; }
        public string imageFlag { get; set; }
        public string imageBG { get; set; }
        public string Name { get; set; }
        public string VKUrl { get; set; }
        public string Information { get; set; }
        public int Budget { get; set; }
        public int AuthorId { get; set; }
        public string AdminInformation { get; set; }

    }
}
