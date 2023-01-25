using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KeklandBankSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    isBigger = table.Column<bool>(type: "boolean", nullable: false),
                    View = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true),
                    CreatorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MiniText = table.Column<string>(type: "text", nullable: true),
                    HtmlText = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    Id1 = table.Column<int>(type: "integer", nullable: false),
                    BankId2 = table.Column<int>(type: "integer", nullable: false),
                    BankId1 = table.Column<int>(type: "integer", nullable: false),
                    Id2 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CasinoWins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WinnerId = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasinoWins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Money = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityTicketGoverments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatorId = table.Column<int>(type: "integer", nullable: false),
                    VKUrl = table.Column<string>(type: "text", nullable: true),
                    Information = table.Column<string>(type: "text", nullable: true),
                    BGUrl = table.Column<string>(type: "text", nullable: true),
                    FlagUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTicketGoverments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityTicketInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    AdminInformation = table.Column<string>(type: "text", nullable: true),
                    IsItemConf = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTicketInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityTicketOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatorId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    VKUrl = table.Column<string>(type: "text", nullable: true),
                    Information = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTicketOrganizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityTicketProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatorId = table.Column<int>(type: "integer", nullable: false),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Information = table.Column<string>(type: "text", nullable: true),
                    Target = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTicketProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goverments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainOrganizationGovermentId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Information = table.Column<string>(type: "text", nullable: true),
                    ImageCoverUrl = table.Column<string>(type: "text", nullable: true),
                    ImageFlagUrl = table.Column<string>(type: "text", nullable: true),
                    LeaderId = table.Column<int>(type: "integer", nullable: false),
                    FreeOrganizationCreateCount = table.Column<int>(type: "integer", nullable: false),
                    TaxesForOrganization = table.Column<int>(type: "integer", nullable: false),
                    AllOrganizationBalance = table.Column<int>(type: "integer", nullable: false),
                    DaysGovermentTaxes = table.Column<int>(type: "integer", nullable: false),
                    VKurl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goverments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GenerateName = table.Column<string>(type: "text", nullable: true),
                    MainPath = table.Column<string>(type: "text", nullable: true),
                    ScreePath = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    ShopItemId = table.Column<int>(type: "integer", nullable: false),
                    BuyCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    MiniInformation = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
                    Rare = table.Column<int>(type: "integer", nullable: false),
                    ShowsDays = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdminId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    VkUrl = table.Column<string>(type: "text", nullable: true),
                    Short_Desc = table.Column<string>(type: "text", nullable: true),
                    Influence = table.Column<int>(type: "integer", nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: false),
                    isBuy = table.Column<bool>(type: "boolean", nullable: false),
                    isZacrep = table.Column<bool>(type: "boolean", nullable: false),
                    Zam1Name = table.Column<int>(type: "integer", nullable: false),
                    Zam2Name = table.Column<int>(type: "integer", nullable: false),
                    SpecialId = table.Column<string>(type: "text", nullable: true),
                    GovermentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    PayDay = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgJobUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrgJobId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgJobUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionAdmins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdminId = table.Column<int>(type: "integer", nullable: false),
                    CheckTickets = table.Column<bool>(type: "boolean", nullable: false),
                    CheckItems = table.Column<bool>(type: "boolean", nullable: false),
                    CheckNews = table.Column<bool>(type: "boolean", nullable: false),
                    CheckGoverments = table.Column<bool>(type: "boolean", nullable: false),
                    CheckProjects = table.Column<bool>(type: "boolean", nullable: false),
                    CheckOrganization = table.Column<bool>(type: "boolean", nullable: false),
                    GetStatistics = table.Column<bool>(type: "boolean", nullable: false),
                    CreateArticles = table.Column<bool>(type: "boolean", nullable: false),
                    ShowAdminStatistics = table.Column<bool>(type: "boolean", nullable: false),
                    GenerateRegCodes = table.Column<bool>(type: "boolean", nullable: false),
                    CreateOrganization = table.Column<bool>(type: "boolean", nullable: false),
                    CreateProject = table.Column<bool>(type: "boolean", nullable: false),
                    CreatePromoCode = table.Column<bool>(type: "boolean", nullable: false),
                    CreateGoverment = table.Column<bool>(type: "boolean", nullable: false),
                    EconomyPanel = table.Column<bool>(type: "boolean", nullable: false),
                    EditGoverment = table.Column<bool>(type: "boolean", nullable: false),
                    ChangeOrganizationInfo = table.Column<bool>(type: "boolean", nullable: false),
                    ChangeOrganizationEconomy = table.Column<bool>(type: "boolean", nullable: false),
                    ChangeUserInfo = table.Column<bool>(type: "boolean", nullable: false),
                    ChangeUserEconomy = table.Column<bool>(type: "boolean", nullable: false),
                    ChangeUserDeposit = table.Column<bool>(type: "boolean", nullable: false),
                    AddItemUser = table.Column<bool>(type: "boolean", nullable: false),
                    EditItem = table.Column<bool>(type: "boolean", nullable: false),
                    CreateItemOrg = table.Column<bool>(type: "boolean", nullable: false),
                    DeleteItem = table.Column<bool>(type: "boolean", nullable: false),
                    EditZamOrg = table.Column<bool>(type: "boolean", nullable: false),
                    DeleteOrganization = table.Column<bool>(type: "boolean", nullable: false),
                    JobSettings = table.Column<bool>(type: "boolean", nullable: false),
                    DeleteTransaction = table.Column<bool>(type: "boolean", nullable: false),
                    ShowAllOrgOrUserTransaction = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionAdmins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Info = table.Column<string>(type: "text", nullable: true),
                    Target = table.Column<int>(type: "integer", nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSenders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Money = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Short_Desc = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    OrgId = table.Column<int>(type: "integer", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    CreateNum = table.Column<int>(type: "integer", nullable: false),
                    isActived = table.Column<bool>(type: "boolean", nullable: false),
                    isCaseItem = table.Column<bool>(type: "boolean", nullable: false),
                    RareType = table.Column<int>(type: "integer", nullable: false),
                    RarePoint = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItemUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShopItemId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItemUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    Spent = table.Column<int>(type: "integer", nullable: false),
                    Recd = table.Column<int>(type: "integer", nullable: false),
                    ViewUser = table.Column<int>(type: "integer", nullable: false),
                    UniqUser = table.Column<int>(type: "integer", nullable: false),
                    SpentMoneyAll = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemMain",
                columns: table => new
                {
                    Key = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PresidentName = table.Column<string>(type: "text", nullable: true),
                    Stavka = table.Column<float>(type: "real", nullable: false),
                    Stavka_Nalog = table.Column<float>(type: "real", nullable: false),
                    Stavka_Vlojen = table.Column<float>(type: "real", nullable: false),
                    MoneyFromLike = table.Column<int>(type: "integer", nullable: false),
                    Nalog_Item = table.Column<float>(type: "real", nullable: false),
                    Nalog_Project = table.Column<int>(type: "integer", nullable: false),
                    UserGetMoneyProject = table.Column<int>(type: "integer", nullable: false),
                    SiteIsOn = table.Column<bool>(type: "boolean", nullable: false),
                    Skrutka = table.Column<int>(type: "integer", nullable: false),
                    CasinoIsOn = table.Column<bool>(type: "boolean", nullable: false),
                    CasesIsOn = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemMain", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    AdminComment = table.Column<string>(type: "text", nullable: true),
                    Images = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShopItemId = table.Column<int>(type: "integer", nullable: false),
                    newSum = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    AddedInformation = table.Column<string>(type: "text", nullable: true),
                    SellerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    Id1 = table.Column<int>(type: "integer", nullable: false),
                    Id2 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsedPassCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PassCodeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedPassCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Money = table.Column<int>(type: "integer", nullable: false),
                    NonViewTrans = table.Column<bool>(type: "boolean", nullable: false),
                    IsArrested = table.Column<bool>(type: "boolean", nullable: false),
                    Coins = table.Column<float>(type: "real", nullable: false),
                    HaveLegendary = table.Column<bool>(type: "boolean", nullable: false),
                    Welfare = table.Column<int>(type: "integer", nullable: false),
                    WelfareItem = table.Column<int>(type: "integer", nullable: false),
                    PremiumDay = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    IsUniqView = table.Column<bool>(type: "boolean", nullable: false),
                    newViewEntity = table.Column<int>(type: "integer", nullable: false),
                    VKUniqId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeithLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeithLevel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ads");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "BankTransactions");

            migrationBuilder.DropTable(
                name: "CasinoWins");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "EntityTicketGoverments");

            migrationBuilder.DropTable(
                name: "EntityTicketInformations");

            migrationBuilder.DropTable(
                name: "EntityTicketOrganizations");

            migrationBuilder.DropTable(
                name: "EntityTicketProjects");

            migrationBuilder.DropTable(
                name: "Goverments");

            migrationBuilder.DropTable(
                name: "ImageSystems");

            migrationBuilder.DropTable(
                name: "ItemStatistics");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "OrgJobs");

            migrationBuilder.DropTable(
                name: "OrgJobUser");

            migrationBuilder.DropTable(
                name: "PassCodes");

            migrationBuilder.DropTable(
                name: "PermissionAdmins");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectSenders");

            migrationBuilder.DropTable(
                name: "RegCodes");

            migrationBuilder.DropTable(
                name: "ShopItems");

            migrationBuilder.DropTable(
                name: "ShopItemUser");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "SystemMain");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "TradeItems");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UsedPassCodes");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WeithLevel");
        }
    }
}
