using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMotoCare.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountRoles",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastEditBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRoles", x => new { x.AccountId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    ActionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.ActionId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleStageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SlotTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCenterCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "EVCheckDetails",
                columns: table => new
                {
                    EVCheckDetaikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EVCheckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehiclePartItem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solution = table.Column<int>(type: "int", nullable: false),
                    IamgeResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartItemReplacement = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServicePriceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVCheckDetails", x => x.EVCheckDetaikId);
                });

            migrationBuilder.CreateTable(
                name: "EVChecks",
                columns: table => new
                {
                    EVCheckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EVCheckCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CheckDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVChecks", x => x.EVCheckId);
                });

            migrationBuilder.CreateTable(
                name: "ExportNoteDetails",
                columns: table => new
                {
                    ExpotNoteDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExportNoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportNoteDetails", x => x.ExpotNoteDetailId);
                });

            migrationBuilder.CreateTable(
                name: "ExportNotes",
                columns: table => new
                {
                    ExportNoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExportFrom = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExportTo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExportNoteCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExportType = table.Column<int>(type: "int", nullable: false),
                    ExportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalQuantityPart = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportNotes", x => x.ExportNoteId);
                });

            migrationBuilder.CreateTable(
                name: "ImportNoteDetails",
                columns: table => new
                {
                    ImportNoteDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportNoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportNoteDetails", x => x.ImportNoteDetailId);
                });

            migrationBuilder.CreateTable(
                name: "ImportNotes",
                columns: table => new
                {
                    ImportNoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportTo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImportFrom = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportNoteCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportType = table.Column<int>(type: "int", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPart = table.Column<int>(type: "int", nullable: false),
                    ImportNoteStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportNotes", x => x.ImportNoteId);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryManager = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                });

            migrationBuilder.CreateTable(
                name: "MaintenancePlans",
                columns: table => new
                {
                    MaintenancePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaintenancePlanname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintenancePlanCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalStage = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenancePlans", x => x.MaintenancePlanId);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceStageDetails",
                columns: table => new
                {
                    MaintenanceStageDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaintenanceStageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceStageDetails", x => x.MaintenanceStageDetailId);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceStages",
                columns: table => new
                {
                    MaintenanceStageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaintenancePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaintenanceStageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaintenanceStageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    MaintenanceInterval = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeMaintenance = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceStages", x => x.MaintenanceStageId);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    PageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMenu = table.Column<bool>(type: "bit", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.PageId);
                });

            migrationBuilder.CreateTable(
                name: "PartItems",
                columns: table => new
                {
                    PartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartItemStatus = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    InvetoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartItems", x => x.PartItemId);
                });

            migrationBuilder.CreateTable(
                name: "PartModels",
                columns: table => new
                {
                    PartModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsWarranty = table.Column<bool>(type: "bit", nullable: false),
                    UnitWarrnty = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartModels", x => x.PartModelId);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsWarranty = table.Column<bool>(type: "bit", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false),
                    UnitWarrnty = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartId);
                });

            migrationBuilder.CreateTable(
                name: "PartTypes",
                columns: table => new
                {
                    PartTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PartTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTypes", x => x.PartTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PayemntId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    TransactionReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalPaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RemainingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PayemntId);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileType = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "RMADetails",
                columns: table => new
                {
                    RMADetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RMAId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehiclePartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceSource = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IssueDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectionResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decision = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMADetails", x => x.RMADetailId);
                });

            migrationBuilder.CreateTable(
                name: "RMAs",
                columns: table => new
                {
                    RMAId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RMACode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMAs", x => x.RMAId);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RolePermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastEditBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.RolePermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastEditBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCenters",
                columns: table => new
                {
                    ServiceCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceCenterCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCenterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCenters", x => x.ServiceCenterId);
                });

            migrationBuilder.CreateTable(
                name: "SlotTimes",
                columns: table => new
                {
                    SlotTimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastEditBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotTimes", x => x.SlotTimeId);
                });

            migrationBuilder.CreateTable(
                name: "StaffProfiles",
                columns: table => new
                {
                    StaffProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffProfiles", x => x.StaffProfileId);
                });

            migrationBuilder.CreateTable(
                name: "StageVehicles",
                columns: table => new
                {
                    StageVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaintenaceStageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleStageStatus = table.Column<int>(type: "int", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualExecutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageVehicles", x => x.StageVehicleId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    VehicleModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaintenancePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatteryType = table.Column<int>(type: "int", nullable: true),
                    StandardChargingTime = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MotorType = table.Column<int>(type: "int", nullable: false),
                    MaximumPower = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShockAbsorbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatteryCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaximumSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RangePerCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FrontBrakes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RearBrakes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.VehicleModelId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassisNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlateNUmber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarrantyStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarrantyEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRoles");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "EVCheckDetails");

            migrationBuilder.DropTable(
                name: "EVChecks");

            migrationBuilder.DropTable(
                name: "ExportNoteDetails");

            migrationBuilder.DropTable(
                name: "ExportNotes");

            migrationBuilder.DropTable(
                name: "ImportNoteDetails");

            migrationBuilder.DropTable(
                name: "ImportNotes");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "MaintenancePlans");

            migrationBuilder.DropTable(
                name: "MaintenanceStageDetails");

            migrationBuilder.DropTable(
                name: "MaintenanceStages");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "PartItems");

            migrationBuilder.DropTable(
                name: "PartModels");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "PartTypes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "RMADetails");

            migrationBuilder.DropTable(
                name: "RMAs");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ServiceCenters");

            migrationBuilder.DropTable(
                name: "SlotTimes");

            migrationBuilder.DropTable(
                name: "StaffProfiles");

            migrationBuilder.DropTable(
                name: "StageVehicles");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
