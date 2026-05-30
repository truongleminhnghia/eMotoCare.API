using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMotoCare.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameDatabaseObjectsToSnakeCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parts",
                table: "Parts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pages",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actions",
                table: "Actions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StageVehicles",
                table: "StageVehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffProfiles",
                table: "StaffProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlotTimes",
                table: "SlotTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceCenters",
                table: "ServiceCenters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RMAs",
                table: "RMAs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RMADetails",
                table: "RMADetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartTypes",
                table: "PartTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartModels",
                table: "PartModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartItems",
                table: "PartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenanceStages",
                table: "MaintenanceStages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenanceStageDetails",
                table: "MaintenanceStageDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenancePlans",
                table: "MaintenancePlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportNotes",
                table: "ImportNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportNoteDetails",
                table: "ImportNoteDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExportNotes",
                table: "ExportNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExportNoteDetails",
                table: "ExportNoteDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EVChecks",
                table: "EVChecks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EVCheckDetails",
                table: "EVCheckDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "vehicles");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "profiles");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "permissions");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "payments");

            migrationBuilder.RenameTable(
                name: "Parts",
                newName: "parts");

            migrationBuilder.RenameTable(
                name: "Pages",
                newName: "pages");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "modules");

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "inventories");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "appointments");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "addresses");

            migrationBuilder.RenameTable(
                name: "Actions",
                newName: "actions");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "accounts");

            migrationBuilder.RenameTable(
                name: "VehicleModels",
                newName: "vehicle_models");

            migrationBuilder.RenameTable(
                name: "StageVehicles",
                newName: "stage_vehicles");

            migrationBuilder.RenameTable(
                name: "StaffProfiles",
                newName: "staff_profiles");

            migrationBuilder.RenameTable(
                name: "SlotTimes",
                newName: "slot_times");

            migrationBuilder.RenameTable(
                name: "ServiceCenters",
                newName: "service_centers");

            migrationBuilder.RenameTable(
                name: "RolePermissions",
                newName: "role_permissions");

            migrationBuilder.RenameTable(
                name: "RMAs",
                newName: "rm_as");

            migrationBuilder.RenameTable(
                name: "RMADetails",
                newName: "rma_details");

            migrationBuilder.RenameTable(
                name: "PartTypes",
                newName: "part_types");

            migrationBuilder.RenameTable(
                name: "PartModels",
                newName: "part_models");

            migrationBuilder.RenameTable(
                name: "PartItems",
                newName: "part_items");

            migrationBuilder.RenameTable(
                name: "MaintenanceStages",
                newName: "maintenance_stages");

            migrationBuilder.RenameTable(
                name: "MaintenanceStageDetails",
                newName: "maintenance_stage_details");

            migrationBuilder.RenameTable(
                name: "MaintenancePlans",
                newName: "maintenance_plans");

            migrationBuilder.RenameTable(
                name: "ImportNotes",
                newName: "import_notes");

            migrationBuilder.RenameTable(
                name: "ImportNoteDetails",
                newName: "import_note_details");

            migrationBuilder.RenameTable(
                name: "ExportNotes",
                newName: "export_notes");

            migrationBuilder.RenameTable(
                name: "ExportNoteDetails",
                newName: "export_note_details");

            migrationBuilder.RenameTable(
                name: "EVChecks",
                newName: "ev_checks");

            migrationBuilder.RenameTable(
                name: "EVCheckDetails",
                newName: "ev_check_details");

            migrationBuilder.RenameTable(
                name: "AccountRoles",
                newName: "account_roles");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "vehicles",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "vehicles",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "WarrantyStartDate",
                table: "vehicles",
                newName: "warranty_start_date");

            migrationBuilder.RenameColumn(
                name: "WarrantyEndDate",
                table: "vehicles",
                newName: "warranty_end_date");

            migrationBuilder.RenameColumn(
                name: "VehicleModelId",
                table: "vehicles",
                newName: "vehicle_model_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "vehicles",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "vehicles",
                newName: "purchase_date");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "vehicles",
                newName: "profile_id");

            migrationBuilder.RenameColumn(
                name: "LicensePlateNUmber",
                table: "vehicles",
                newName: "license_plate_n_umber");

            migrationBuilder.RenameColumn(
                name: "EngineNumber",
                table: "vehicles",
                newName: "engine_number");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "vehicles",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ClassisNumber",
                table: "vehicles",
                newName: "classis_number");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "vehicles",
                newName: "vehicle_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "roles",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "roles",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "roles",
                newName: "role_name");

            migrationBuilder.RenameColumn(
                name: "RoleCode",
                table: "roles",
                newName: "role_code");

            migrationBuilder.RenameColumn(
                name: "LastEditBy",
                table: "roles",
                newName: "last_edit_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "roles",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "roles",
                newName: "create_by");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "roles",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "profiles",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "profiles",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "profiles",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "profiles",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "profiles",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ProfileType",
                table: "profiles",
                newName: "profile_type");

            migrationBuilder.RenameColumn(
                name: "ProfileCode",
                table: "profiles",
                newName: "profile_code");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "profiles",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "profiles",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "profiles",
                newName: "date_of_birth");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "profiles",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "profiles",
                newName: "address_id");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "profiles",
                newName: "profile_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "permissions",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "PageId",
                table: "permissions",
                newName: "page_id");

            migrationBuilder.RenameColumn(
                name: "ActionId",
                table: "permissions",
                newName: "action_id");

            migrationBuilder.RenameColumn(
                name: "PermissionId",
                table: "permissions",
                newName: "permission_id");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "payments",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "payments",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "payments",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TransactionReference",
                table: "payments",
                newName: "transaction_reference");

            migrationBuilder.RenameColumn(
                name: "TotalPaidAmount",
                table: "payments",
                newName: "total_paid_amount");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "payments",
                newName: "total_amount");

            migrationBuilder.RenameColumn(
                name: "RemainingAmount",
                table: "payments",
                newName: "remaining_amount");

            migrationBuilder.RenameColumn(
                name: "PaymentTime",
                table: "payments",
                newName: "payment_time");

            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "payments",
                newName: "payment_status");

            migrationBuilder.RenameColumn(
                name: "PaymentMethod",
                table: "payments",
                newName: "payment_method");

            migrationBuilder.RenameColumn(
                name: "PaymentCode",
                table: "payments",
                newName: "payment_code");

            migrationBuilder.RenameColumn(
                name: "PaidAmount",
                table: "payments",
                newName: "paid_amount");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "payments",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AttachmentUrl",
                table: "payments",
                newName: "attachment_url");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "payments",
                newName: "appointment_id");

            migrationBuilder.RenameColumn(
                name: "PayemntId",
                table: "payments",
                newName: "payemnt_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "parts",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "parts",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "WarrantyPeriod",
                table: "parts",
                newName: "warranty_period");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "parts",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "UnitWarrnty",
                table: "parts",
                newName: "unit_warrnty");

            migrationBuilder.RenameColumn(
                name: "PartTypeId",
                table: "parts",
                newName: "part_type_id");

            migrationBuilder.RenameColumn(
                name: "PartName",
                table: "parts",
                newName: "part_name");

            migrationBuilder.RenameColumn(
                name: "PartCode",
                table: "parts",
                newName: "part_code");

            migrationBuilder.RenameColumn(
                name: "IsWarranty",
                table: "parts",
                newName: "is_warranty");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "parts",
                newName: "image_url");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "parts",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CostPrice",
                table: "parts",
                newName: "cost_price");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "parts",
                newName: "part_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "pages",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "pages",
                newName: "icon");

            migrationBuilder.RenameColumn(
                name: "PageUrl",
                table: "pages",
                newName: "page_url");

            migrationBuilder.RenameColumn(
                name: "PageCode",
                table: "pages",
                newName: "page_code");

            migrationBuilder.RenameColumn(
                name: "OrderIndex",
                table: "pages",
                newName: "order_index");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "pages",
                newName: "module_id");

            migrationBuilder.RenameColumn(
                name: "IsMenu",
                table: "pages",
                newName: "is_menu");

            migrationBuilder.RenameColumn(
                name: "PageId",
                table: "pages",
                newName: "page_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "modules",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "OrderIndex",
                table: "modules",
                newName: "order_index");

            migrationBuilder.RenameColumn(
                name: "ModuleName",
                table: "modules",
                newName: "module_name");

            migrationBuilder.RenameColumn(
                name: "ModuleCode",
                table: "modules",
                newName: "module_code");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "modules",
                newName: "module_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "inventories",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ServiceCenterId",
                table: "inventories",
                newName: "service_center_id");

            migrationBuilder.RenameColumn(
                name: "InventoryManager",
                table: "inventories",
                newName: "inventory_manager");

            migrationBuilder.RenameColumn(
                name: "InventoryCode",
                table: "inventories",
                newName: "inventory_code");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "inventories",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "inventories",
                newName: "address_id");

            migrationBuilder.RenameColumn(
                name: "InventoryId",
                table: "inventories",
                newName: "inventory_id");

            migrationBuilder.RenameColumn(
                name: "VehicleStageId",
                table: "appointments",
                newName: "vehicle_stage_id");

            migrationBuilder.RenameColumn(
                name: "VehicleCode",
                table: "appointments",
                newName: "vehicle_code");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "appointments",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "StaffCode",
                table: "appointments",
                newName: "staff_code");

            migrationBuilder.RenameColumn(
                name: "SlotTime",
                table: "appointments",
                newName: "slot_time");

            migrationBuilder.RenameColumn(
                name: "ServiceCenterCode",
                table: "appointments",
                newName: "service_center_code");

            migrationBuilder.RenameColumn(
                name: "ProfileCode",
                table: "appointments",
                newName: "profile_code");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "appointments",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AppointmentStatus",
                table: "appointments",
                newName: "appointment_status");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "appointments",
                newName: "appointment_date");

            migrationBuilder.RenameColumn(
                name: "AppointmentCode",
                table: "appointments",
                newName: "appointment_code");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "appointments",
                newName: "appointment_id");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "addresses",
                newName: "address_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "actions",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "ActionName",
                table: "actions",
                newName: "action_name");

            migrationBuilder.RenameColumn(
                name: "ActionCode",
                table: "actions",
                newName: "action_code");

            migrationBuilder.RenameColumn(
                name: "ActionId",
                table: "actions",
                newName: "action_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "accounts",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "accounts",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "accounts",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "accounts",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "LastLogin",
                table: "accounts",
                newName: "last_login");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "accounts",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "accounts",
                newName: "account_id");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "vehicle_models",
                newName: "width");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "vehicle_models",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "vehicle_models",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "vehicle_models",
                newName: "length");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "vehicle_models",
                newName: "height");

            migrationBuilder.RenameColumn(
                name: "Colors",
                table: "vehicle_models",
                newName: "colors");

            migrationBuilder.RenameColumn(
                name: "WarrantyPeriod",
                table: "vehicle_models",
                newName: "warranty_period");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "vehicle_models",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "StandardChargingTime",
                table: "vehicle_models",
                newName: "standard_charging_time");

            migrationBuilder.RenameColumn(
                name: "ShockAbsorbers",
                table: "vehicle_models",
                newName: "shock_absorbers");

            migrationBuilder.RenameColumn(
                name: "RearBrakes",
                table: "vehicle_models",
                newName: "rear_brakes");

            migrationBuilder.RenameColumn(
                name: "RangePerCharge",
                table: "vehicle_models",
                newName: "range_per_charge");

            migrationBuilder.RenameColumn(
                name: "MotorType",
                table: "vehicle_models",
                newName: "motor_type");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "vehicle_models",
                newName: "model_name");

            migrationBuilder.RenameColumn(
                name: "ModelCode",
                table: "vehicle_models",
                newName: "model_code");

            migrationBuilder.RenameColumn(
                name: "MaximumSpeed",
                table: "vehicle_models",
                newName: "maximum_speed");

            migrationBuilder.RenameColumn(
                name: "MaximumPower",
                table: "vehicle_models",
                newName: "maximum_power");

            migrationBuilder.RenameColumn(
                name: "MaintenancePlanId",
                table: "vehicle_models",
                newName: "maintenance_plan_id");

            migrationBuilder.RenameColumn(
                name: "FrontBrakes",
                table: "vehicle_models",
                newName: "front_brakes");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "vehicle_models",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "BatteryType",
                table: "vehicle_models",
                newName: "battery_type");

            migrationBuilder.RenameColumn(
                name: "BatteryCapacity",
                table: "vehicle_models",
                newName: "battery_capacity");

            migrationBuilder.RenameColumn(
                name: "VehicleModelId",
                table: "vehicle_models",
                newName: "vehicle_model_id");

            migrationBuilder.RenameColumn(
                name: "VehicleStageStatus",
                table: "stage_vehicles",
                newName: "vehicle_stage_status");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "stage_vehicles",
                newName: "vehicle_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "stage_vehicles",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "MaintenaceStageId",
                table: "stage_vehicles",
                newName: "maintenace_stage_id");

            migrationBuilder.RenameColumn(
                name: "ExpectedEndDate",
                table: "stage_vehicles",
                newName: "expected_end_date");

            migrationBuilder.RenameColumn(
                name: "ExpectedDate",
                table: "stage_vehicles",
                newName: "expected_date");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "stage_vehicles",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ActualExecutionDate",
                table: "stage_vehicles",
                newName: "actual_execution_date");

            migrationBuilder.RenameColumn(
                name: "StageVehicleId",
                table: "stage_vehicles",
                newName: "stage_vehicle_id");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "staff_profiles",
                newName: "position");

            migrationBuilder.RenameColumn(
                name: "StaffCode",
                table: "staff_profiles",
                newName: "staff_code");

            migrationBuilder.RenameColumn(
                name: "ServiceCenterId",
                table: "staff_profiles",
                newName: "service_center_id");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "staff_profiles",
                newName: "profile_id");

            migrationBuilder.RenameColumn(
                name: "StaffProfileId",
                table: "staff_profiles",
                newName: "staff_profile_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "slot_times",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "slot_times",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "slot_times",
                newName: "start_time");

            migrationBuilder.RenameColumn(
                name: "ServiceCenterId",
                table: "slot_times",
                newName: "service_center_id");

            migrationBuilder.RenameColumn(
                name: "LastEditBy",
                table: "slot_times",
                newName: "last_edit_by");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "slot_times",
                newName: "end_time");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "slot_times",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "slot_times",
                newName: "create_by");

            migrationBuilder.RenameColumn(
                name: "SlotTimeId",
                table: "slot_times",
                newName: "slot_time_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "service_centers",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "service_centers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "service_centers",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "service_centers",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ServiceCenterName",
                table: "service_centers",
                newName: "service_center_name");

            migrationBuilder.RenameColumn(
                name: "ServiceCenterCode",
                table: "service_centers",
                newName: "service_center_code");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "service_centers",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "service_centers",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "service_centers",
                newName: "address_id");

            migrationBuilder.RenameColumn(
                name: "ServiceCenterId",
                table: "service_centers",
                newName: "service_center_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "role_permissions",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PermissionId",
                table: "role_permissions",
                newName: "permission_id");

            migrationBuilder.RenameColumn(
                name: "LastEditBy",
                table: "role_permissions",
                newName: "last_edit_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "role_permissions",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "role_permissions",
                newName: "create_by");

            migrationBuilder.RenameColumn(
                name: "RolePermissionId",
                table: "role_permissions",
                newName: "role_permission_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "rm_as",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "rm_as",
                newName: "vehicle_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "rm_as",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "RMACode",
                table: "rm_as",
                newName: "rma_code");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "rm_as",
                newName: "profile_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "rm_as",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "rm_as",
                newName: "create_by");

            migrationBuilder.RenameColumn(
                name: "ApprovedBy",
                table: "rm_as",
                newName: "approved_by");

            migrationBuilder.RenameColumn(
                name: "RMAId",
                table: "rm_as",
                newName: "rma_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "rma_details",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Decision",
                table: "rma_details",
                newName: "decision");

            migrationBuilder.RenameColumn(
                name: "VehiclePartItemId",
                table: "rma_details",
                newName: "vehicle_part_item_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "rma_details",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ReferenceSource",
                table: "rma_details",
                newName: "reference_source");

            migrationBuilder.RenameColumn(
                name: "RMAId",
                table: "rma_details",
                newName: "rma_id");

            migrationBuilder.RenameColumn(
                name: "IssueDescription",
                table: "rma_details",
                newName: "issue_description");

            migrationBuilder.RenameColumn(
                name: "InspectionResult",
                table: "rma_details",
                newName: "inspection_result");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "rma_details",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "RMADetailId",
                table: "rma_details",
                newName: "rma_detail_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "part_types",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "part_types",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PartTypeName",
                table: "part_types",
                newName: "part_type_name");

            migrationBuilder.RenameColumn(
                name: "PartTypeCode",
                table: "part_types",
                newName: "part_type_code");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "part_types",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "PartTypeId",
                table: "part_types",
                newName: "part_type_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "part_models",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "VehicleModelId",
                table: "part_models",
                newName: "vehicle_model_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "part_models",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "UnitWarrnty",
                table: "part_models",
                newName: "unit_warrnty");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "part_models",
                newName: "part_id");

            migrationBuilder.RenameColumn(
                name: "IsWarranty",
                table: "part_models",
                newName: "is_warranty");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "part_models",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "PartModelId",
                table: "part_models",
                newName: "part_model_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "part_items",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "part_items",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "part_items",
                newName: "serial_number");

            migrationBuilder.RenameColumn(
                name: "PartItemStatus",
                table: "part_items",
                newName: "part_item_status");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "part_items",
                newName: "part_id");

            migrationBuilder.RenameColumn(
                name: "InvetoryId",
                table: "part_items",
                newName: "invetory_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "part_items",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "PartItemId",
                table: "part_items",
                newName: "part_item_id");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "maintenance_stages",
                newName: "unit");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "maintenance_stages",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "maintenance_stages",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "maintenance_stages",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TimeMaintenance",
                table: "maintenance_stages",
                newName: "time_maintenance");

            migrationBuilder.RenameColumn(
                name: "OrderIndex",
                table: "maintenance_stages",
                newName: "order_index");

            migrationBuilder.RenameColumn(
                name: "MaintenanceStageName",
                table: "maintenance_stages",
                newName: "maintenance_stage_name");

            migrationBuilder.RenameColumn(
                name: "MaintenanceStageCode",
                table: "maintenance_stages",
                newName: "maintenance_stage_code");

            migrationBuilder.RenameColumn(
                name: "MaintenancePlanId",
                table: "maintenance_stages",
                newName: "maintenance_plan_id");

            migrationBuilder.RenameColumn(
                name: "MaintenanceInterval",
                table: "maintenance_stages",
                newName: "maintenance_interval");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "maintenance_stages",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "MaintenanceStageId",
                table: "maintenance_stages",
                newName: "maintenance_stage_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "maintenance_stage_details",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "maintenance_stage_details",
                newName: "part_id");

            migrationBuilder.RenameColumn(
                name: "OrderIndex",
                table: "maintenance_stage_details",
                newName: "order_index");

            migrationBuilder.RenameColumn(
                name: "MaintenanceStageId",
                table: "maintenance_stage_details",
                newName: "maintenance_stage_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "maintenance_stage_details",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ActionType",
                table: "maintenance_stage_details",
                newName: "action_type");

            migrationBuilder.RenameColumn(
                name: "MaintenanceStageDetailId",
                table: "maintenance_stage_details",
                newName: "maintenance_stage_detail_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "maintenance_plans",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "maintenance_plans",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "maintenance_plans",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TotalStage",
                table: "maintenance_plans",
                newName: "total_stage");

            migrationBuilder.RenameColumn(
                name: "MaintenancePlanname",
                table: "maintenance_plans",
                newName: "maintenance_planname");

            migrationBuilder.RenameColumn(
                name: "MaintenancePlanCode",
                table: "maintenance_plans",
                newName: "maintenance_plan_code");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "maintenance_plans",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "MaintenancePlanId",
                table: "maintenance_plans",
                newName: "maintenance_plan_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "import_notes",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TotalPart",
                table: "import_notes",
                newName: "total_part");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "import_notes",
                newName: "total_amount");

            migrationBuilder.RenameColumn(
                name: "ImportType",
                table: "import_notes",
                newName: "import_type");

            migrationBuilder.RenameColumn(
                name: "ImportTo",
                table: "import_notes",
                newName: "import_to");

            migrationBuilder.RenameColumn(
                name: "ImportNoteStatus",
                table: "import_notes",
                newName: "import_note_status");

            migrationBuilder.RenameColumn(
                name: "ImportNoteCode",
                table: "import_notes",
                newName: "import_note_code");

            migrationBuilder.RenameColumn(
                name: "ImportFrom",
                table: "import_notes",
                newName: "import_from");

            migrationBuilder.RenameColumn(
                name: "ImportDate",
                table: "import_notes",
                newName: "import_date");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "import_notes",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "import_notes",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ImportNoteId",
                table: "import_notes",
                newName: "import_note_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "import_note_details",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "import_note_details",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PartItemId",
                table: "import_note_details",
                newName: "part_item_id");

            migrationBuilder.RenameColumn(
                name: "ImportNoteId",
                table: "import_note_details",
                newName: "import_note_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "import_note_details",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ImportNoteDetailId",
                table: "import_note_details",
                newName: "import_note_detail_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "export_notes",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TotalQuantityPart",
                table: "export_notes",
                newName: "total_quantity_part");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "export_notes",
                newName: "total_amount");

            migrationBuilder.RenameColumn(
                name: "ExportType",
                table: "export_notes",
                newName: "export_type");

            migrationBuilder.RenameColumn(
                name: "ExportTo",
                table: "export_notes",
                newName: "export_to");

            migrationBuilder.RenameColumn(
                name: "ExportNoteCode",
                table: "export_notes",
                newName: "export_note_code");

            migrationBuilder.RenameColumn(
                name: "ExportFrom",
                table: "export_notes",
                newName: "export_from");

            migrationBuilder.RenameColumn(
                name: "ExportDate",
                table: "export_notes",
                newName: "export_date");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "export_notes",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "export_notes",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ExportNoteId",
                table: "export_notes",
                newName: "export_note_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "export_note_details",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "export_note_details",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "export_note_details",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PartItemId",
                table: "export_note_details",
                newName: "part_item_id");

            migrationBuilder.RenameColumn(
                name: "ExportNoteId",
                table: "export_note_details",
                newName: "export_note_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "export_note_details",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ExpotNoteDetailId",
                table: "export_note_details",
                newName: "expot_note_detail_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ev_checks",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "ev_checks",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ev_checks",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "ev_checks",
                newName: "total_amount");

            migrationBuilder.RenameColumn(
                name: "ExecutedBy",
                table: "ev_checks",
                newName: "executed_by");

            migrationBuilder.RenameColumn(
                name: "EVCheckCode",
                table: "ev_checks",
                newName: "ev_check_code");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ev_checks",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CheckDate",
                table: "ev_checks",
                newName: "check_date");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "ev_checks",
                newName: "appointment_id");

            migrationBuilder.RenameColumn(
                name: "EVCheckId",
                table: "ev_checks",
                newName: "ev_check_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ev_check_details",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Solution",
                table: "ev_check_details",
                newName: "solution");

            migrationBuilder.RenameColumn(
                name: "Result",
                table: "ev_check_details",
                newName: "result");

            migrationBuilder.RenameColumn(
                name: "VehiclePartItem",
                table: "ev_check_details",
                newName: "vehicle_part_item");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ev_check_details",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "ev_check_details",
                newName: "total_price");

            migrationBuilder.RenameColumn(
                name: "ServicePriceId",
                table: "ev_check_details",
                newName: "service_price_id");

            migrationBuilder.RenameColumn(
                name: "PartPrice",
                table: "ev_check_details",
                newName: "part_price");

            migrationBuilder.RenameColumn(
                name: "PartItemReplacement",
                table: "ev_check_details",
                newName: "part_item_replacement");

            migrationBuilder.RenameColumn(
                name: "IamgeResult",
                table: "ev_check_details",
                newName: "iamge_result");

            migrationBuilder.RenameColumn(
                name: "EVCheckId",
                table: "ev_check_details",
                newName: "ev_check_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ev_check_details",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ActionType",
                table: "ev_check_details",
                newName: "action_type");

            migrationBuilder.RenameColumn(
                name: "EVCheckDetaikId",
                table: "ev_check_details",
                newName: "ev_check_detaik_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "account_roles",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "LastEditBy",
                table: "account_roles",
                newName: "last_edit_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "account_roles",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "account_roles",
                newName: "create_by");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "account_roles",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "account_roles",
                newName: "account_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_vehicles",
                table: "vehicles",
                column: "vehicle_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_roles",
                table: "roles",
                column: "role_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_profiles",
                table: "profiles",
                column: "profile_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_permissions",
                table: "permissions",
                column: "permission_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_payments",
                table: "payments",
                column: "payemnt_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_parts",
                table: "parts",
                column: "part_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_pages",
                table: "pages",
                column: "page_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_modules",
                table: "modules",
                column: "module_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_inventories",
                table: "inventories",
                column: "inventory_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_appointments",
                table: "appointments",
                column: "appointment_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_addresses",
                table: "addresses",
                column: "address_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_actions",
                table: "actions",
                column: "action_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_accounts",
                table: "accounts",
                column: "account_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_vehicle_models",
                table: "vehicle_models",
                column: "vehicle_model_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_stage_vehicles",
                table: "stage_vehicles",
                column: "stage_vehicle_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_staff_profiles",
                table: "staff_profiles",
                column: "staff_profile_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_slot_times",
                table: "slot_times",
                column: "slot_time_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_service_centers",
                table: "service_centers",
                column: "service_center_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_role_permissions",
                table: "role_permissions",
                column: "role_permission_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_rm_as",
                table: "rm_as",
                column: "rma_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_rma_details",
                table: "rma_details",
                column: "rma_detail_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_part_types",
                table: "part_types",
                column: "part_type_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_part_models",
                table: "part_models",
                column: "part_model_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_part_items",
                table: "part_items",
                column: "part_item_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_maintenance_stages",
                table: "maintenance_stages",
                column: "maintenance_stage_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_maintenance_stage_details",
                table: "maintenance_stage_details",
                column: "maintenance_stage_detail_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_maintenance_plans",
                table: "maintenance_plans",
                column: "maintenance_plan_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_import_notes",
                table: "import_notes",
                column: "import_note_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_import_note_details",
                table: "import_note_details",
                column: "import_note_detail_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_export_notes",
                table: "export_notes",
                column: "export_note_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_export_note_details",
                table: "export_note_details",
                column: "expot_note_detail_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ev_checks",
                table: "ev_checks",
                column: "ev_check_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ev_check_details",
                table: "ev_check_details",
                column: "ev_check_detaik_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_account_roles",
                table: "account_roles",
                columns: new[] { "account_id", "role_id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_vehicles",
                table: "vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_profiles",
                table: "profiles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_permissions",
                table: "permissions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_payments",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "pk_parts",
                table: "parts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_pages",
                table: "pages");

            migrationBuilder.DropPrimaryKey(
                name: "pk_modules",
                table: "modules");

            migrationBuilder.DropPrimaryKey(
                name: "pk_inventories",
                table: "inventories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_appointments",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "pk_addresses",
                table: "addresses");

            migrationBuilder.DropPrimaryKey(
                name: "pk_actions",
                table: "actions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_accounts",
                table: "accounts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_vehicle_models",
                table: "vehicle_models");

            migrationBuilder.DropPrimaryKey(
                name: "pk_stage_vehicles",
                table: "stage_vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_staff_profiles",
                table: "staff_profiles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_slot_times",
                table: "slot_times");

            migrationBuilder.DropPrimaryKey(
                name: "pk_service_centers",
                table: "service_centers");

            migrationBuilder.DropPrimaryKey(
                name: "pk_role_permissions",
                table: "role_permissions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_rma_details",
                table: "rma_details");

            migrationBuilder.DropPrimaryKey(
                name: "pk_rm_as",
                table: "rm_as");

            migrationBuilder.DropPrimaryKey(
                name: "pk_part_types",
                table: "part_types");

            migrationBuilder.DropPrimaryKey(
                name: "pk_part_models",
                table: "part_models");

            migrationBuilder.DropPrimaryKey(
                name: "pk_part_items",
                table: "part_items");

            migrationBuilder.DropPrimaryKey(
                name: "pk_maintenance_stages",
                table: "maintenance_stages");

            migrationBuilder.DropPrimaryKey(
                name: "pk_maintenance_stage_details",
                table: "maintenance_stage_details");

            migrationBuilder.DropPrimaryKey(
                name: "pk_maintenance_plans",
                table: "maintenance_plans");

            migrationBuilder.DropPrimaryKey(
                name: "pk_import_notes",
                table: "import_notes");

            migrationBuilder.DropPrimaryKey(
                name: "pk_import_note_details",
                table: "import_note_details");

            migrationBuilder.DropPrimaryKey(
                name: "pk_export_notes",
                table: "export_notes");

            migrationBuilder.DropPrimaryKey(
                name: "pk_export_note_details",
                table: "export_note_details");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ev_checks",
                table: "ev_checks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ev_check_details",
                table: "ev_check_details");

            migrationBuilder.DropPrimaryKey(
                name: "pk_account_roles",
                table: "account_roles");

            migrationBuilder.RenameTable(
                name: "vehicles",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "profiles",
                newName: "Profiles");

            migrationBuilder.RenameTable(
                name: "permissions",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "payments",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "parts",
                newName: "Parts");

            migrationBuilder.RenameTable(
                name: "pages",
                newName: "Pages");

            migrationBuilder.RenameTable(
                name: "modules",
                newName: "Modules");

            migrationBuilder.RenameTable(
                name: "inventories",
                newName: "Inventories");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "Appointments");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "Addresses");

            migrationBuilder.RenameTable(
                name: "actions",
                newName: "Actions");

            migrationBuilder.RenameTable(
                name: "accounts",
                newName: "Accounts");

            migrationBuilder.RenameTable(
                name: "vehicle_models",
                newName: "VehicleModels");

            migrationBuilder.RenameTable(
                name: "stage_vehicles",
                newName: "StageVehicles");

            migrationBuilder.RenameTable(
                name: "staff_profiles",
                newName: "StaffProfiles");

            migrationBuilder.RenameTable(
                name: "slot_times",
                newName: "SlotTimes");

            migrationBuilder.RenameTable(
                name: "service_centers",
                newName: "ServiceCenters");

            migrationBuilder.RenameTable(
                name: "role_permissions",
                newName: "RolePermissions");

            migrationBuilder.RenameTable(
                name: "rma_details",
                newName: "RMADetails");

            migrationBuilder.RenameTable(
                name: "rm_as",
                newName: "RMAs");

            migrationBuilder.RenameTable(
                name: "part_types",
                newName: "PartTypes");

            migrationBuilder.RenameTable(
                name: "part_models",
                newName: "PartModels");

            migrationBuilder.RenameTable(
                name: "part_items",
                newName: "PartItems");

            migrationBuilder.RenameTable(
                name: "maintenance_stages",
                newName: "MaintenanceStages");

            migrationBuilder.RenameTable(
                name: "maintenance_stage_details",
                newName: "MaintenanceStageDetails");

            migrationBuilder.RenameTable(
                name: "maintenance_plans",
                newName: "MaintenancePlans");

            migrationBuilder.RenameTable(
                name: "import_notes",
                newName: "ImportNotes");

            migrationBuilder.RenameTable(
                name: "import_note_details",
                newName: "ImportNoteDetails");

            migrationBuilder.RenameTable(
                name: "export_notes",
                newName: "ExportNotes");

            migrationBuilder.RenameTable(
                name: "export_note_details",
                newName: "ExportNoteDetails");

            migrationBuilder.RenameTable(
                name: "ev_checks",
                newName: "EVChecks");

            migrationBuilder.RenameTable(
                name: "ev_check_details",
                newName: "EVCheckDetails");

            migrationBuilder.RenameTable(
                name: "account_roles",
                newName: "AccountRoles");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Vehicles",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Vehicles",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "warranty_start_date",
                table: "Vehicles",
                newName: "WarrantyStartDate");

            migrationBuilder.RenameColumn(
                name: "warranty_end_date",
                table: "Vehicles",
                newName: "WarrantyEndDate");

            migrationBuilder.RenameColumn(
                name: "vehicle_model_id",
                table: "Vehicles",
                newName: "VehicleModelId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Vehicles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "purchase_date",
                table: "Vehicles",
                newName: "PurchaseDate");

            migrationBuilder.RenameColumn(
                name: "profile_id",
                table: "Vehicles",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "license_plate_n_umber",
                table: "Vehicles",
                newName: "LicensePlateNUmber");

            migrationBuilder.RenameColumn(
                name: "engine_number",
                table: "Vehicles",
                newName: "EngineNumber");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Vehicles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "classis_number",
                table: "Vehicles",
                newName: "ClassisNumber");

            migrationBuilder.RenameColumn(
                name: "vehicle_id",
                table: "Vehicles",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Roles",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Roles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "role_name",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "role_code",
                table: "Roles",
                newName: "RoleCode");

            migrationBuilder.RenameColumn(
                name: "last_edit_by",
                table: "Roles",
                newName: "LastEditBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Roles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "Roles",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "Roles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Profiles",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Profiles",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Profiles",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Profiles",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Profiles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "profile_type",
                table: "Profiles",
                newName: "ProfileType");

            migrationBuilder.RenameColumn(
                name: "profile_code",
                table: "Profiles",
                newName: "ProfileCode");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Profiles",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Profiles",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "date_of_birth",
                table: "Profiles",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Profiles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "Profiles",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "profile_id",
                table: "Profiles",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Permissions",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "page_id",
                table: "Permissions",
                newName: "PageId");

            migrationBuilder.RenameColumn(
                name: "action_id",
                table: "Permissions",
                newName: "ActionId");

            migrationBuilder.RenameColumn(
                name: "permission_id",
                table: "Permissions",
                newName: "PermissionId");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "Payments",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "Payments",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Payments",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "transaction_reference",
                table: "Payments",
                newName: "TransactionReference");

            migrationBuilder.RenameColumn(
                name: "total_paid_amount",
                table: "Payments",
                newName: "TotalPaidAmount");

            migrationBuilder.RenameColumn(
                name: "total_amount",
                table: "Payments",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "remaining_amount",
                table: "Payments",
                newName: "RemainingAmount");

            migrationBuilder.RenameColumn(
                name: "payment_time",
                table: "Payments",
                newName: "PaymentTime");

            migrationBuilder.RenameColumn(
                name: "payment_status",
                table: "Payments",
                newName: "PaymentStatus");

            migrationBuilder.RenameColumn(
                name: "payment_method",
                table: "Payments",
                newName: "PaymentMethod");

            migrationBuilder.RenameColumn(
                name: "payment_code",
                table: "Payments",
                newName: "PaymentCode");

            migrationBuilder.RenameColumn(
                name: "paid_amount",
                table: "Payments",
                newName: "PaidAmount");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Payments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "attachment_url",
                table: "Payments",
                newName: "AttachmentUrl");

            migrationBuilder.RenameColumn(
                name: "appointment_id",
                table: "Payments",
                newName: "AppointmentId");

            migrationBuilder.RenameColumn(
                name: "payemnt_id",
                table: "Payments",
                newName: "PayemntId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Parts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Parts",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "warranty_period",
                table: "Parts",
                newName: "WarrantyPeriod");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Parts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "unit_warrnty",
                table: "Parts",
                newName: "UnitWarrnty");

            migrationBuilder.RenameColumn(
                name: "part_type_id",
                table: "Parts",
                newName: "PartTypeId");

            migrationBuilder.RenameColumn(
                name: "part_name",
                table: "Parts",
                newName: "PartName");

            migrationBuilder.RenameColumn(
                name: "part_code",
                table: "Parts",
                newName: "PartCode");

            migrationBuilder.RenameColumn(
                name: "is_warranty",
                table: "Parts",
                newName: "IsWarranty");

            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "Parts",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Parts",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "cost_price",
                table: "Parts",
                newName: "CostPrice");

            migrationBuilder.RenameColumn(
                name: "part_id",
                table: "Parts",
                newName: "PartId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Pages",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "icon",
                table: "Pages",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "page_url",
                table: "Pages",
                newName: "PageUrl");

            migrationBuilder.RenameColumn(
                name: "page_code",
                table: "Pages",
                newName: "PageCode");

            migrationBuilder.RenameColumn(
                name: "order_index",
                table: "Pages",
                newName: "OrderIndex");

            migrationBuilder.RenameColumn(
                name: "module_id",
                table: "Pages",
                newName: "ModuleId");

            migrationBuilder.RenameColumn(
                name: "is_menu",
                table: "Pages",
                newName: "IsMenu");

            migrationBuilder.RenameColumn(
                name: "page_id",
                table: "Pages",
                newName: "PageId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Modules",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "order_index",
                table: "Modules",
                newName: "OrderIndex");

            migrationBuilder.RenameColumn(
                name: "module_name",
                table: "Modules",
                newName: "ModuleName");

            migrationBuilder.RenameColumn(
                name: "module_code",
                table: "Modules",
                newName: "ModuleCode");

            migrationBuilder.RenameColumn(
                name: "module_id",
                table: "Modules",
                newName: "ModuleId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Inventories",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "service_center_id",
                table: "Inventories",
                newName: "ServiceCenterId");

            migrationBuilder.RenameColumn(
                name: "inventory_manager",
                table: "Inventories",
                newName: "InventoryManager");

            migrationBuilder.RenameColumn(
                name: "inventory_code",
                table: "Inventories",
                newName: "InventoryCode");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Inventories",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "Inventories",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "inventory_id",
                table: "Inventories",
                newName: "InventoryId");

            migrationBuilder.RenameColumn(
                name: "vehicle_stage_id",
                table: "Appointments",
                newName: "VehicleStageId");

            migrationBuilder.RenameColumn(
                name: "vehicle_code",
                table: "Appointments",
                newName: "VehicleCode");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Appointments",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "staff_code",
                table: "Appointments",
                newName: "StaffCode");

            migrationBuilder.RenameColumn(
                name: "slot_time",
                table: "Appointments",
                newName: "SlotTime");

            migrationBuilder.RenameColumn(
                name: "service_center_code",
                table: "Appointments",
                newName: "ServiceCenterCode");

            migrationBuilder.RenameColumn(
                name: "profile_code",
                table: "Appointments",
                newName: "ProfileCode");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Appointments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "appointment_status",
                table: "Appointments",
                newName: "AppointmentStatus");

            migrationBuilder.RenameColumn(
                name: "appointment_date",
                table: "Appointments",
                newName: "AppointmentDate");

            migrationBuilder.RenameColumn(
                name: "appointment_code",
                table: "Appointments",
                newName: "AppointmentCode");

            migrationBuilder.RenameColumn(
                name: "appointment_id",
                table: "Appointments",
                newName: "AppointmentId");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "Addresses",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Actions",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "action_name",
                table: "Actions",
                newName: "ActionName");

            migrationBuilder.RenameColumn(
                name: "action_code",
                table: "Actions",
                newName: "ActionCode");

            migrationBuilder.RenameColumn(
                name: "action_id",
                table: "Actions",
                newName: "ActionId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Accounts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Accounts",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "Accounts",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Accounts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "last_login",
                table: "Accounts",
                newName: "LastLogin");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Accounts",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "Accounts",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "width",
                table: "VehicleModels",
                newName: "Width");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "VehicleModels",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "VehicleModels",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "length",
                table: "VehicleModels",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "height",
                table: "VehicleModels",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "colors",
                table: "VehicleModels",
                newName: "Colors");

            migrationBuilder.RenameColumn(
                name: "warranty_period",
                table: "VehicleModels",
                newName: "WarrantyPeriod");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "VehicleModels",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "standard_charging_time",
                table: "VehicleModels",
                newName: "StandardChargingTime");

            migrationBuilder.RenameColumn(
                name: "shock_absorbers",
                table: "VehicleModels",
                newName: "ShockAbsorbers");

            migrationBuilder.RenameColumn(
                name: "rear_brakes",
                table: "VehicleModels",
                newName: "RearBrakes");

            migrationBuilder.RenameColumn(
                name: "range_per_charge",
                table: "VehicleModels",
                newName: "RangePerCharge");

            migrationBuilder.RenameColumn(
                name: "motor_type",
                table: "VehicleModels",
                newName: "MotorType");

            migrationBuilder.RenameColumn(
                name: "model_name",
                table: "VehicleModels",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "model_code",
                table: "VehicleModels",
                newName: "ModelCode");

            migrationBuilder.RenameColumn(
                name: "maximum_speed",
                table: "VehicleModels",
                newName: "MaximumSpeed");

            migrationBuilder.RenameColumn(
                name: "maximum_power",
                table: "VehicleModels",
                newName: "MaximumPower");

            migrationBuilder.RenameColumn(
                name: "maintenance_plan_id",
                table: "VehicleModels",
                newName: "MaintenancePlanId");

            migrationBuilder.RenameColumn(
                name: "front_brakes",
                table: "VehicleModels",
                newName: "FrontBrakes");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "VehicleModels",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "battery_type",
                table: "VehicleModels",
                newName: "BatteryType");

            migrationBuilder.RenameColumn(
                name: "battery_capacity",
                table: "VehicleModels",
                newName: "BatteryCapacity");

            migrationBuilder.RenameColumn(
                name: "vehicle_model_id",
                table: "VehicleModels",
                newName: "VehicleModelId");

            migrationBuilder.RenameColumn(
                name: "vehicle_stage_status",
                table: "StageVehicles",
                newName: "VehicleStageStatus");

            migrationBuilder.RenameColumn(
                name: "vehicle_id",
                table: "StageVehicles",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "StageVehicles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "maintenace_stage_id",
                table: "StageVehicles",
                newName: "MaintenaceStageId");

            migrationBuilder.RenameColumn(
                name: "expected_end_date",
                table: "StageVehicles",
                newName: "ExpectedEndDate");

            migrationBuilder.RenameColumn(
                name: "expected_date",
                table: "StageVehicles",
                newName: "ExpectedDate");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "StageVehicles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "actual_execution_date",
                table: "StageVehicles",
                newName: "ActualExecutionDate");

            migrationBuilder.RenameColumn(
                name: "stage_vehicle_id",
                table: "StageVehicles",
                newName: "StageVehicleId");

            migrationBuilder.RenameColumn(
                name: "position",
                table: "StaffProfiles",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "staff_code",
                table: "StaffProfiles",
                newName: "StaffCode");

            migrationBuilder.RenameColumn(
                name: "service_center_id",
                table: "StaffProfiles",
                newName: "ServiceCenterId");

            migrationBuilder.RenameColumn(
                name: "profile_id",
                table: "StaffProfiles",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "staff_profile_id",
                table: "StaffProfiles",
                newName: "StaffProfileId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "SlotTimes",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "SlotTimes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "start_time",
                table: "SlotTimes",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "service_center_id",
                table: "SlotTimes",
                newName: "ServiceCenterId");

            migrationBuilder.RenameColumn(
                name: "last_edit_by",
                table: "SlotTimes",
                newName: "LastEditBy");

            migrationBuilder.RenameColumn(
                name: "end_time",
                table: "SlotTimes",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "SlotTimes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "SlotTimes",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "slot_time_id",
                table: "SlotTimes",
                newName: "SlotTimeId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "ServiceCenters",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "ServiceCenters",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "ServiceCenters",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "ServiceCenters",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "service_center_name",
                table: "ServiceCenters",
                newName: "ServiceCenterName");

            migrationBuilder.RenameColumn(
                name: "service_center_code",
                table: "ServiceCenters",
                newName: "ServiceCenterCode");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "ServiceCenters",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "ServiceCenters",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "ServiceCenters",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "service_center_id",
                table: "ServiceCenters",
                newName: "ServiceCenterId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "RolePermissions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "permission_id",
                table: "RolePermissions",
                newName: "PermissionId");

            migrationBuilder.RenameColumn(
                name: "last_edit_by",
                table: "RolePermissions",
                newName: "LastEditBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "RolePermissions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "RolePermissions",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "role_permission_id",
                table: "RolePermissions",
                newName: "RolePermissionId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "RMADetails",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "decision",
                table: "RMADetails",
                newName: "Decision");

            migrationBuilder.RenameColumn(
                name: "vehicle_part_item_id",
                table: "RMADetails",
                newName: "VehiclePartItemId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "RMADetails",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "rma_id",
                table: "RMADetails",
                newName: "RMAId");

            migrationBuilder.RenameColumn(
                name: "reference_source",
                table: "RMADetails",
                newName: "ReferenceSource");

            migrationBuilder.RenameColumn(
                name: "issue_description",
                table: "RMADetails",
                newName: "IssueDescription");

            migrationBuilder.RenameColumn(
                name: "inspection_result",
                table: "RMADetails",
                newName: "InspectionResult");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "RMADetails",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "rma_detail_id",
                table: "RMADetails",
                newName: "RMADetailId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "RMAs",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "vehicle_id",
                table: "RMAs",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "RMAs",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "rma_code",
                table: "RMAs",
                newName: "RMACode");

            migrationBuilder.RenameColumn(
                name: "profile_id",
                table: "RMAs",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "RMAs",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "RMAs",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "approved_by",
                table: "RMAs",
                newName: "ApprovedBy");

            migrationBuilder.RenameColumn(
                name: "rma_id",
                table: "RMAs",
                newName: "RMAId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "PartTypes",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "PartTypes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "part_type_name",
                table: "PartTypes",
                newName: "PartTypeName");

            migrationBuilder.RenameColumn(
                name: "part_type_code",
                table: "PartTypes",
                newName: "PartTypeCode");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "PartTypes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "part_type_id",
                table: "PartTypes",
                newName: "PartTypeId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "PartModels",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "vehicle_model_id",
                table: "PartModels",
                newName: "VehicleModelId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "PartModels",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "unit_warrnty",
                table: "PartModels",
                newName: "UnitWarrnty");

            migrationBuilder.RenameColumn(
                name: "part_id",
                table: "PartModels",
                newName: "PartId");

            migrationBuilder.RenameColumn(
                name: "is_warranty",
                table: "PartModels",
                newName: "IsWarranty");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "PartModels",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "part_model_id",
                table: "PartModels",
                newName: "PartModelId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "PartItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "PartItems",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "serial_number",
                table: "PartItems",
                newName: "SerialNumber");

            migrationBuilder.RenameColumn(
                name: "part_item_status",
                table: "PartItems",
                newName: "PartItemStatus");

            migrationBuilder.RenameColumn(
                name: "part_id",
                table: "PartItems",
                newName: "PartId");

            migrationBuilder.RenameColumn(
                name: "invetory_id",
                table: "PartItems",
                newName: "InvetoryId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "PartItems",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "part_item_id",
                table: "PartItems",
                newName: "PartItemId");

            migrationBuilder.RenameColumn(
                name: "unit",
                table: "MaintenanceStages",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "MaintenanceStages",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "MaintenanceStages",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "MaintenanceStages",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "time_maintenance",
                table: "MaintenanceStages",
                newName: "TimeMaintenance");

            migrationBuilder.RenameColumn(
                name: "order_index",
                table: "MaintenanceStages",
                newName: "OrderIndex");

            migrationBuilder.RenameColumn(
                name: "maintenance_stage_name",
                table: "MaintenanceStages",
                newName: "MaintenanceStageName");

            migrationBuilder.RenameColumn(
                name: "maintenance_stage_code",
                table: "MaintenanceStages",
                newName: "MaintenanceStageCode");

            migrationBuilder.RenameColumn(
                name: "maintenance_plan_id",
                table: "MaintenanceStages",
                newName: "MaintenancePlanId");

            migrationBuilder.RenameColumn(
                name: "maintenance_interval",
                table: "MaintenanceStages",
                newName: "MaintenanceInterval");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "MaintenanceStages",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "maintenance_stage_id",
                table: "MaintenanceStages",
                newName: "MaintenanceStageId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "MaintenanceStageDetails",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "part_id",
                table: "MaintenanceStageDetails",
                newName: "PartId");

            migrationBuilder.RenameColumn(
                name: "order_index",
                table: "MaintenanceStageDetails",
                newName: "OrderIndex");

            migrationBuilder.RenameColumn(
                name: "maintenance_stage_id",
                table: "MaintenanceStageDetails",
                newName: "MaintenanceStageId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "MaintenanceStageDetails",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "action_type",
                table: "MaintenanceStageDetails",
                newName: "ActionType");

            migrationBuilder.RenameColumn(
                name: "maintenance_stage_detail_id",
                table: "MaintenanceStageDetails",
                newName: "MaintenanceStageDetailId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "MaintenancePlans",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "MaintenancePlans",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "MaintenancePlans",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "total_stage",
                table: "MaintenancePlans",
                newName: "TotalStage");

            migrationBuilder.RenameColumn(
                name: "maintenance_planname",
                table: "MaintenancePlans",
                newName: "MaintenancePlanname");

            migrationBuilder.RenameColumn(
                name: "maintenance_plan_code",
                table: "MaintenancePlans",
                newName: "MaintenancePlanCode");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "MaintenancePlans",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "maintenance_plan_id",
                table: "MaintenancePlans",
                newName: "MaintenancePlanId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "ImportNotes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "total_part",
                table: "ImportNotes",
                newName: "TotalPart");

            migrationBuilder.RenameColumn(
                name: "total_amount",
                table: "ImportNotes",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "import_type",
                table: "ImportNotes",
                newName: "ImportType");

            migrationBuilder.RenameColumn(
                name: "import_to",
                table: "ImportNotes",
                newName: "ImportTo");

            migrationBuilder.RenameColumn(
                name: "import_note_status",
                table: "ImportNotes",
                newName: "ImportNoteStatus");

            migrationBuilder.RenameColumn(
                name: "import_note_code",
                table: "ImportNotes",
                newName: "ImportNoteCode");

            migrationBuilder.RenameColumn(
                name: "import_from",
                table: "ImportNotes",
                newName: "ImportFrom");

            migrationBuilder.RenameColumn(
                name: "import_date",
                table: "ImportNotes",
                newName: "ImportDate");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "ImportNotes",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "ImportNotes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "import_note_id",
                table: "ImportNotes",
                newName: "ImportNoteId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "ImportNoteDetails",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "ImportNoteDetails",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "part_item_id",
                table: "ImportNoteDetails",
                newName: "PartItemId");

            migrationBuilder.RenameColumn(
                name: "import_note_id",
                table: "ImportNoteDetails",
                newName: "ImportNoteId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "ImportNoteDetails",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "import_note_detail_id",
                table: "ImportNoteDetails",
                newName: "ImportNoteDetailId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "ExportNotes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "total_quantity_part",
                table: "ExportNotes",
                newName: "TotalQuantityPart");

            migrationBuilder.RenameColumn(
                name: "total_amount",
                table: "ExportNotes",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "export_type",
                table: "ExportNotes",
                newName: "ExportType");

            migrationBuilder.RenameColumn(
                name: "export_to",
                table: "ExportNotes",
                newName: "ExportTo");

            migrationBuilder.RenameColumn(
                name: "export_note_code",
                table: "ExportNotes",
                newName: "ExportNoteCode");

            migrationBuilder.RenameColumn(
                name: "export_from",
                table: "ExportNotes",
                newName: "ExportFrom");

            migrationBuilder.RenameColumn(
                name: "export_date",
                table: "ExportNotes",
                newName: "ExportDate");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "ExportNotes",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "ExportNotes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "export_note_id",
                table: "ExportNotes",
                newName: "ExportNoteId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "ExportNoteDetails",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "ExportNoteDetails",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "ExportNoteDetails",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "part_item_id",
                table: "ExportNoteDetails",
                newName: "PartItemId");

            migrationBuilder.RenameColumn(
                name: "export_note_id",
                table: "ExportNoteDetails",
                newName: "ExportNoteId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "ExportNoteDetails",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "expot_note_detail_id",
                table: "ExportNoteDetails",
                newName: "ExpotNoteDetailId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "EVChecks",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "EVChecks",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "EVChecks",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "total_amount",
                table: "EVChecks",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "executed_by",
                table: "EVChecks",
                newName: "ExecutedBy");

            migrationBuilder.RenameColumn(
                name: "ev_check_code",
                table: "EVChecks",
                newName: "EVCheckCode");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "EVChecks",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "check_date",
                table: "EVChecks",
                newName: "CheckDate");

            migrationBuilder.RenameColumn(
                name: "appointment_id",
                table: "EVChecks",
                newName: "AppointmentId");

            migrationBuilder.RenameColumn(
                name: "ev_check_id",
                table: "EVChecks",
                newName: "EVCheckId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "EVCheckDetails",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "solution",
                table: "EVCheckDetails",
                newName: "Solution");

            migrationBuilder.RenameColumn(
                name: "result",
                table: "EVCheckDetails",
                newName: "Result");

            migrationBuilder.RenameColumn(
                name: "vehicle_part_item",
                table: "EVCheckDetails",
                newName: "VehiclePartItem");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "EVCheckDetails",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "total_price",
                table: "EVCheckDetails",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "service_price_id",
                table: "EVCheckDetails",
                newName: "ServicePriceId");

            migrationBuilder.RenameColumn(
                name: "part_price",
                table: "EVCheckDetails",
                newName: "PartPrice");

            migrationBuilder.RenameColumn(
                name: "part_item_replacement",
                table: "EVCheckDetails",
                newName: "PartItemReplacement");

            migrationBuilder.RenameColumn(
                name: "iamge_result",
                table: "EVCheckDetails",
                newName: "IamgeResult");

            migrationBuilder.RenameColumn(
                name: "ev_check_id",
                table: "EVCheckDetails",
                newName: "EVCheckId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "EVCheckDetails",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "action_type",
                table: "EVCheckDetails",
                newName: "ActionType");

            migrationBuilder.RenameColumn(
                name: "ev_check_detaik_id",
                table: "EVCheckDetails",
                newName: "EVCheckDetaikId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "AccountRoles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "last_edit_by",
                table: "AccountRoles",
                newName: "LastEditBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "AccountRoles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "AccountRoles",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "AccountRoles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "AccountRoles",
                newName: "AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PayemntId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parts",
                table: "Parts",
                column: "PartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pages",
                table: "Pages",
                column: "PageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                column: "ModuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "AppointmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actions",
                table: "Actions",
                column: "ActionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels",
                column: "VehicleModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StageVehicles",
                table: "StageVehicles",
                column: "StageVehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffProfiles",
                table: "StaffProfiles",
                column: "StaffProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlotTimes",
                table: "SlotTimes",
                column: "SlotTimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceCenters",
                table: "ServiceCenters",
                column: "ServiceCenterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions",
                column: "RolePermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RMADetails",
                table: "RMADetails",
                column: "RMADetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RMAs",
                table: "RMAs",
                column: "RMAId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartTypes",
                table: "PartTypes",
                column: "PartTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartModels",
                table: "PartModels",
                column: "PartModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartItems",
                table: "PartItems",
                column: "PartItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenanceStages",
                table: "MaintenanceStages",
                column: "MaintenanceStageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenanceStageDetails",
                table: "MaintenanceStageDetails",
                column: "MaintenanceStageDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenancePlans",
                table: "MaintenancePlans",
                column: "MaintenancePlanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportNotes",
                table: "ImportNotes",
                column: "ImportNoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportNoteDetails",
                table: "ImportNoteDetails",
                column: "ImportNoteDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExportNotes",
                table: "ExportNotes",
                column: "ExportNoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExportNoteDetails",
                table: "ExportNoteDetails",
                column: "ExpotNoteDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EVChecks",
                table: "EVChecks",
                column: "EVCheckId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EVCheckDetails",
                table: "EVCheckDetails",
                column: "EVCheckDetaikId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountRoles",
                table: "AccountRoles",
                columns: new[] { "AccountId", "RoleId" });
        }
    }
}
