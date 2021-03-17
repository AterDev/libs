using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gov.Context.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountExtends",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RealName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    NickName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    Birthday = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Province = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    County = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Street = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    AddressDetail = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    WXOpenId = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    WXAvatar = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    WXUnionId = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountExtends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionLogs",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ActionType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    TargetName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ActionPath = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Result = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApproveFlows",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproveFlows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApproveFlowStatuses",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TargetId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Step = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    RoleId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RoleName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ApproveStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproveFlowStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleExtends",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleExtends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorityGroups",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorityGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Sort = table.Column<short>(type: "smallint", nullable: false),
                    Level = table.Column<short>(type: "smallint", nullable: false),
                    ParentId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catalog_Catalog_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Catalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dictionaries",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Key = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ValType = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    IntValue = table.Column<int>(type: "int", nullable: true),
                    DecimalValue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Unit = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnterpriseExtends",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnterpriseExtends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnterpriseInfos",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UnionCode = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    Type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    RegisteredCapital = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationStatus = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    RegDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    EndDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    RegArea = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    RegAddress = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    BusinessScope = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    Corporation = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnterpriseInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DisplayName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Icon = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Path = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsValid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Level = table.Column<short>(type: "smallint", nullable: false),
                    ParentId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Level = table.Column<short>(type: "smallint", nullable: false),
                    Country = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Province = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    County = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Street = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    ParentId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Organizations_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductExtends",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Detail = table.Column<string>(type: "text", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductExtends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Icon = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Email = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    Password = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    Username = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    HashSalt = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    LastLoginTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RetryCount = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: true),
                    PhoneConfirm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmailConfirm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Avatar = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    ExtendId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountExtends_ExtendId",
                        column: x => x.ExtendId,
                        principalTable: "AccountExtends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApproveFlowRelation",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    TargetId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    FlowId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproveFlowRelation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApproveFlowRelation_ApproveFlows_FlowId",
                        column: x => x.FlowId,
                        principalTable: "ApproveFlows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApproveFlowSteps",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Step = table.Column<int>(type: "int", nullable: false),
                    AllApprovel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    RoleId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RoleName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ApproveFlowId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproveFlowSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApproveFlowSteps_ApproveFlows_ApproveFlowId",
                        column: x => x.ApproveFlowId,
                        principalTable: "ApproveFlows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authorities",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    GroupId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authorities_AuthorityGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AuthorityGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Summary = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    AuthorName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Tags = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ExtendId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    CatalogId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleExtends_ExtendId",
                        column: x => x.ExtendId,
                        principalTable: "ArticleExtends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Catalog_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "Catalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RealName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    NickName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    Birthday = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    IdentityCard = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    HireDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    ContractType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    IsFullTime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PositionTitle = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    JobTitle = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Province = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    County = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Street = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    AddressDetail = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    OrganizationId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnels_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UniqueCode = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ExtendId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    CatalogId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Catalog_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "Catalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductExtends_ExtendId",
                        column: x => x.ExtendId,
                        principalTable: "ProductExtends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorityGroupRole",
                columns: table => new
                {
                    AuthorityGroupsId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RolesId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorityGroupRole", x => new { x.AuthorityGroupsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_AuthorityGroupRole_AuthorityGroups_AuthorityGroupsId",
                        column: x => x.AuthorityGroupsId,
                        principalTable: "AuthorityGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorityGroupRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuRole",
                columns: table => new
                {
                    MenusId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RolesId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRole", x => new { x.MenusId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_MenuRole_Menus_MenusId",
                        column: x => x.MenusId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountRole",
                columns: table => new
                {
                    AccountsId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RolesId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRole", x => new { x.AccountsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_AccountRole_Accounts_AccountsId",
                        column: x => x.AccountsId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ArticleId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    Content = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountExtends_City",
                table: "AccountExtends",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_AccountExtends_Country",
                table: "AccountExtends",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_AccountExtends_Province",
                table: "AccountExtends",
                column: "Province");

            migrationBuilder.CreateIndex(
                name: "IX_AccountExtends_RealName",
                table: "AccountExtends",
                column: "RealName");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRole_RolesId",
                table: "AccountRole",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CreatedTime",
                table: "Accounts",
                column: "CreatedTime");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Email",
                table: "Accounts",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_EmailConfirm",
                table: "Accounts",
                column: "EmailConfirm");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ExtendId",
                table: "Accounts",
                column: "ExtendId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_IsDeleted",
                table: "Accounts",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Phone",
                table: "Accounts",
                column: "Phone");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PhoneConfirm",
                table: "Accounts",
                column: "PhoneConfirm");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Username",
                table: "Accounts",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_ActionType",
                table: "ActionLogs",
                column: "ActionType");

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_CreatedTime",
                table: "ActionLogs",
                column: "CreatedTime");

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_Status",
                table: "ActionLogs",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_UserId",
                table: "ActionLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionLogs_Username",
                table: "ActionLogs",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowRelation_FlowId",
                table: "ApproveFlowRelation",
                column: "FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlows_Name",
                table: "ApproveFlows",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowStatuses_CreatedTime",
                table: "ApproveFlowStatuses",
                column: "CreatedTime");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowStatuses_RoleId",
                table: "ApproveFlowStatuses",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowStatuses_TargetId",
                table: "ApproveFlowStatuses",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowStatuses_UserId",
                table: "ApproveFlowStatuses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowSteps_ApproveFlowId",
                table: "ApproveFlowSteps",
                column: "ApproveFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowSteps_RoleId",
                table: "ApproveFlowSteps",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowSteps_Step",
                table: "ApproveFlowSteps",
                column: "Step");

            migrationBuilder.CreateIndex(
                name: "IX_ApproveFlowSteps_UserId",
                table: "ApproveFlowSteps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorName",
                table: "Articles",
                column: "AuthorName");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CatalogId",
                table: "Articles",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CreatedTime",
                table: "Articles",
                column: "CreatedTime");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ExtendId",
                table: "Articles",
                column: "ExtendId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_Status",
                table: "Articles",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_Title",
                table: "Articles",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_GroupId",
                table: "Authorities",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_Name",
                table: "Authorities",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_Type",
                table: "Authorities",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityGroupRole_RolesId",
                table: "AuthorityGroupRole",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityGroups_Name",
                table: "AuthorityGroups",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Level",
                table: "Catalog",
                column: "Level");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Name",
                table: "Catalog",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_ParentId",
                table: "Catalog",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Type",
                table: "Catalog",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Status",
                table: "Comments",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Dictionaries_Key",
                table: "Dictionaries",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_Dictionaries_Type",
                table: "Dictionaries",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Dictionaries_ValType",
                table: "Dictionaries",
                column: "ValType");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_Corporation",
                table: "EnterpriseInfos",
                column: "Corporation");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_EndDate",
                table: "EnterpriseInfos",
                column: "EndDate");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_Name",
                table: "EnterpriseInfos",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_RegDate",
                table: "EnterpriseInfos",
                column: "RegDate");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_RegisteredCapital",
                table: "EnterpriseInfos",
                column: "RegisteredCapital");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_RegistrationStatus",
                table: "EnterpriseInfos",
                column: "RegistrationStatus");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_Type",
                table: "EnterpriseInfos",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_UnionCode",
                table: "EnterpriseInfos",
                column: "UnionCode");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RolesId",
                table: "MenuRole",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Name",
                table: "Menus",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentId",
                table: "Menus",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Status",
                table: "Menus",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Type",
                table: "Menus",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_City",
                table: "Organizations",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_Country",
                table: "Organizations",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_Level",
                table: "Organizations",
                column: "Level");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_Name",
                table: "Organizations",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_ParentId",
                table: "Organizations",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_Province",
                table: "Organizations",
                column: "Province");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_Status",
                table: "Organizations",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_City",
                table: "Personnels",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_Country",
                table: "Personnels",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_HireDate",
                table: "Personnels",
                column: "HireDate");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_IdentityCard",
                table: "Personnels",
                column: "IdentityCard");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_IsFullTime",
                table: "Personnels",
                column: "IsFullTime");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_JobTitle",
                table: "Personnels",
                column: "JobTitle");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_OrganizationId",
                table: "Personnels",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_PositionTitle",
                table: "Personnels",
                column: "PositionTitle");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_Province",
                table: "Personnels",
                column: "Province");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_RealName",
                table: "Personnels",
                column: "RealName");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatalogId",
                table: "Products",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ExtendId",
                table: "Products",
                column: "ExtendId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Status",
                table: "Products",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Title",
                table: "Products",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UniqueCode",
                table: "Products",
                column: "UniqueCode");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Status",
                table: "Roles",
                column: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRole");

            migrationBuilder.DropTable(
                name: "ActionLogs");

            migrationBuilder.DropTable(
                name: "ApproveFlowRelation");

            migrationBuilder.DropTable(
                name: "ApproveFlowStatuses");

            migrationBuilder.DropTable(
                name: "ApproveFlowSteps");

            migrationBuilder.DropTable(
                name: "Authorities");

            migrationBuilder.DropTable(
                name: "AuthorityGroupRole");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Dictionaries");

            migrationBuilder.DropTable(
                name: "EnterpriseExtends");

            migrationBuilder.DropTable(
                name: "EnterpriseInfos");

            migrationBuilder.DropTable(
                name: "MenuRole");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ApproveFlows");

            migrationBuilder.DropTable(
                name: "AuthorityGroups");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "ProductExtends");

            migrationBuilder.DropTable(
                name: "AccountExtends");

            migrationBuilder.DropTable(
                name: "ArticleExtends");

            migrationBuilder.DropTable(
                name: "Catalog");
        }
    }
}
