using System;
using System.Collections.Generic;
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
                name: "account_roles",
                columns: table => new
                {
                    account_id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_id = table.Column<Guid>(type: "uuid", nullable: false),
                    create_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_edit_by = table.Column<Guid>(type: "uuid", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_account_roles", x => new { x.account_id, x.role_id });
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    account_id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    last_login = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accounts", x => x.account_id);
                });

            migrationBuilder.CreateTable(
                name: "actions",
                columns: table => new
                {
                    action_id = table.Column<Guid>(type: "uuid", nullable: false),
                    action_code = table.Column<string>(type: "text", nullable: false),
                    action_name = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_actions", x => x.action_id);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    address_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_addresses", x => x.address_id);
                });

            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    appointment_id = table.Column<Guid>(type: "uuid", nullable: false),
                    appointment_code = table.Column<string>(type: "text", nullable: false),
                    vehicle_stage_id = table.Column<Guid>(type: "uuid", nullable: false),
                    profile_code = table.Column<string>(type: "text", nullable: false),
                    vehicle_code = table.Column<string>(type: "text", nullable: false),
                    appointment_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    slot_time = table.Column<string>(type: "text", nullable: false),
                    service_center_code = table.Column<string>(type: "text", nullable: false),
                    staff_code = table.Column<string>(type: "text", nullable: false),
                    appointment_status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointments", x => x.appointment_id);
                });

            migrationBuilder.CreateTable(
                name: "ev_check_details",
                columns: table => new
                {
                    ev_check_detaik_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ev_check_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vehicle_part_item = table.Column<Guid>(type: "uuid", nullable: false),
                    action_type = table.Column<int>(type: "integer", nullable: false),
                    result = table.Column<string>(type: "text", nullable: true),
                    solution = table.Column<int>(type: "integer", nullable: false),
                    iamge_result = table.Column<string>(type: "text", nullable: true),
                    part_item_replacement = table.Column<Guid>(type: "uuid", nullable: true),
                    part_price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: true),
                    service_price_id = table.Column<Guid>(type: "uuid", nullable: true),
                    total_price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ev_check_details", x => x.ev_check_detaik_id);
                });

            migrationBuilder.CreateTable(
                name: "ev_checks",
                columns: table => new
                {
                    ev_check_id = table.Column<Guid>(type: "uuid", nullable: false),
                    appointment_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ev_check_code = table.Column<string>(type: "text", nullable: true),
                    executed_by = table.Column<Guid>(type: "uuid", nullable: true),
                    check_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    note = table.Column<string>(type: "text", nullable: true),
                    total_amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ev_checks", x => x.ev_check_id);
                });

            migrationBuilder.CreateTable(
                name: "export_note_details",
                columns: table => new
                {
                    expot_note_detail_id = table.Column<Guid>(type: "uuid", nullable: false),
                    export_note_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_item_id = table.Column<Guid>(type: "uuid", nullable: false),
                    price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_export_note_details", x => x.expot_note_detail_id);
                });

            migrationBuilder.CreateTable(
                name: "export_notes",
                columns: table => new
                {
                    export_note_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    export_from = table.Column<Guid>(type: "uuid", nullable: true),
                    export_to = table.Column<Guid>(type: "uuid", nullable: true),
                    export_note_code = table.Column<string>(type: "text", nullable: false),
                    total_amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    export_type = table.Column<int>(type: "integer", nullable: false),
                    export_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    total_quantity_part = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_export_notes", x => x.export_note_id);
                });

            migrationBuilder.CreateTable(
                name: "import_note_details",
                columns: table => new
                {
                    import_note_detail_id = table.Column<Guid>(type: "uuid", nullable: false),
                    import_note_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_item_id = table.Column<Guid>(type: "uuid", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_import_note_details", x => x.import_note_detail_id);
                });

            migrationBuilder.CreateTable(
                name: "import_notes",
                columns: table => new
                {
                    import_note_id = table.Column<Guid>(type: "uuid", nullable: false),
                    import_to = table.Column<Guid>(type: "uuid", nullable: true),
                    import_from = table.Column<Guid>(type: "uuid", nullable: true),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    import_note_code = table.Column<string>(type: "text", nullable: false),
                    import_type = table.Column<int>(type: "integer", nullable: false),
                    import_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    total_amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    total_part = table.Column<int>(type: "integer", nullable: false),
                    import_note_status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_import_notes", x => x.import_note_id);
                });

            migrationBuilder.CreateTable(
                name: "inventories",
                columns: table => new
                {
                    inventory_id = table.Column<Guid>(type: "uuid", nullable: false),
                    inventory_code = table.Column<string>(type: "text", nullable: false),
                    service_center_id = table.Column<Guid>(type: "uuid", nullable: false),
                    address_id = table.Column<Guid>(type: "uuid", nullable: false),
                    inventory_manager = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_inventories", x => x.inventory_id);
                });

            migrationBuilder.CreateTable(
                name: "maintenance_plans",
                columns: table => new
                {
                    maintenance_plan_id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenance_planname = table.Column<string>(type: "text", nullable: true),
                    maintenance_plan_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    total_stage = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_maintenance_plans", x => x.maintenance_plan_id);
                });

            migrationBuilder.CreateTable(
                name: "maintenance_stage_details",
                columns: table => new
                {
                    maintenance_stage_detail_id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenance_stage_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_id = table.Column<Guid>(type: "uuid", nullable: false),
                    action_type = table.Column<int>(type: "integer", nullable: false),
                    order_index = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_maintenance_stage_details", x => x.maintenance_stage_detail_id);
                });

            migrationBuilder.CreateTable(
                name: "maintenance_stages",
                columns: table => new
                {
                    maintenance_stage_id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenance_plan_id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenance_stage_code = table.Column<string>(type: "text", nullable: false),
                    maintenance_stage_name = table.Column<string>(type: "text", nullable: true),
                    order_index = table.Column<int>(type: "integer", nullable: false),
                    maintenance_interval = table.Column<string>(type: "text", nullable: false),
                    time_maintenance = table.Column<int>(type: "integer", nullable: false),
                    unit = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_maintenance_stages", x => x.maintenance_stage_id);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    module_id = table.Column<Guid>(type: "uuid", nullable: false),
                    module_name = table.Column<string>(type: "text", nullable: false),
                    module_code = table.Column<string>(type: "text", nullable: false),
                    order_index = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_modules", x => x.module_id);
                });

            migrationBuilder.CreateTable(
                name: "pages",
                columns: table => new
                {
                    page_id = table.Column<Guid>(type: "uuid", nullable: false),
                    module_id = table.Column<Guid>(type: "uuid", nullable: false),
                    page_code = table.Column<string>(type: "text", nullable: false),
                    page_url = table.Column<string>(type: "text", nullable: false),
                    icon = table.Column<string>(type: "text", nullable: true),
                    is_menu = table.Column<bool>(type: "boolean", nullable: false),
                    order_index = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pages", x => x.page_id);
                });

            migrationBuilder.CreateTable(
                name: "part_items",
                columns: table => new
                {
                    part_item_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_id = table.Column<Guid>(type: "uuid", nullable: false),
                    serial_number = table.Column<string>(type: "text", nullable: true),
                    part_item_status = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    invetory_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_part_items", x => x.part_item_id);
                });

            migrationBuilder.CreateTable(
                name: "part_models",
                columns: table => new
                {
                    part_model_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vehicle_model_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_warranty = table.Column<bool>(type: "boolean", nullable: false),
                    unit_warrnty = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_part_models", x => x.part_model_id);
                });

            migrationBuilder.CreateTable(
                name: "part_types",
                columns: table => new
                {
                    part_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_type_name = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    part_type_code = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_part_types", x => x.part_type_id);
                });

            migrationBuilder.CreateTable(
                name: "parts",
                columns: table => new
                {
                    part_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    part_name = table.Column<string>(type: "text", nullable: true),
                    part_code = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: true),
                    cost_price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    is_warranty = table.Column<bool>(type: "boolean", nullable: false),
                    warranty_period = table.Column<int>(type: "integer", nullable: false),
                    unit_warrnty = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    image_url = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parts", x => x.part_id);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    payemnt_id = table.Column<Guid>(type: "uuid", nullable: false),
                    appointment_id = table.Column<Guid>(type: "uuid", nullable: false),
                    payment_code = table.Column<string>(type: "text", nullable: false),
                    total_amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    payment_method = table.Column<int>(type: "integer", nullable: false),
                    payment_status = table.Column<int>(type: "integer", nullable: false),
                    transaction_reference = table.Column<string>(type: "text", nullable: true),
                    payment_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    currency = table.Column<string>(type: "text", nullable: true),
                    note = table.Column<string>(type: "text", nullable: true),
                    attachment_url = table.Column<string>(type: "text", nullable: true),
                    paid_amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: true),
                    total_paid_amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: true),
                    remaining_amount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_payments", x => x.payemnt_id);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    permission_id = table.Column<Guid>(type: "uuid", nullable: false),
                    page_id = table.Column<Guid>(type: "uuid", nullable: false),
                    action_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permissions", x => x.permission_id);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    profile_code = table.Column<string>(type: "text", nullable: false),
                    first_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    profile_type = table.Column<int>(type: "integer", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    address_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_profiles", x => x.profile_id);
                });

            migrationBuilder.CreateTable(
                name: "rm_as",
                columns: table => new
                {
                    rma_id = table.Column<Guid>(type: "uuid", nullable: false),
                    rma_code = table.Column<string>(type: "text", nullable: false),
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vehicle_id = table.Column<Guid>(type: "uuid", nullable: false),
                    create_by = table.Column<Guid>(type: "uuid", nullable: false),
                    approved_by = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rm_as", x => x.rma_id);
                });

            migrationBuilder.CreateTable(
                name: "rma_details",
                columns: table => new
                {
                    rma_detail_id = table.Column<Guid>(type: "uuid", nullable: false),
                    rma_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vehicle_part_item_id = table.Column<Guid>(type: "uuid", nullable: false),
                    reference_source = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    issue_description = table.Column<string>(type: "text", nullable: true),
                    inspection_result = table.Column<string>(type: "text", nullable: true),
                    decision = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rma_details", x => x.rma_detail_id);
                });

            migrationBuilder.CreateTable(
                name: "role_permissions",
                columns: table => new
                {
                    role_permission_id = table.Column<Guid>(type: "uuid", nullable: false),
                    permission_id = table.Column<Guid>(type: "uuid", nullable: false),
                    create_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_edit_by = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role_permissions", x => x.role_permission_id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    role_id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_name = table.Column<string>(type: "text", nullable: false),
                    role_code = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_edit_by = table.Column<Guid>(type: "uuid", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "service_centers",
                columns: table => new
                {
                    service_center_id = table.Column<Guid>(type: "uuid", nullable: false),
                    service_center_code = table.Column<string>(type: "text", nullable: false),
                    service_center_name = table.Column<string>(type: "text", nullable: true),
                    address_id = table.Column<Guid>(type: "uuid", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_service_centers", x => x.service_center_id);
                });

            migrationBuilder.CreateTable(
                name: "slot_times",
                columns: table => new
                {
                    slot_time_id = table.Column<Guid>(type: "uuid", nullable: false),
                    service_center_id = table.Column<Guid>(type: "uuid", nullable: false),
                    start_time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    end_time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_by = table.Column<Guid>(type: "uuid", nullable: false),
                    last_edit_by = table.Column<Guid>(type: "uuid", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_slot_times", x => x.slot_time_id);
                });

            migrationBuilder.CreateTable(
                name: "staff_profiles",
                columns: table => new
                {
                    staff_profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    staff_code = table.Column<string>(type: "text", nullable: false),
                    service_center_id = table.Column<Guid>(type: "uuid", nullable: false),
                    position = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_staff_profiles", x => x.staff_profile_id);
                });

            migrationBuilder.CreateTable(
                name: "stage_vehicles",
                columns: table => new
                {
                    stage_vehicle_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vehicle_id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenace_stage_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vehicle_stage_status = table.Column<int>(type: "integer", nullable: false),
                    expected_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    expected_end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    actual_execution_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_stage_vehicles", x => x.stage_vehicle_id);
                });

            migrationBuilder.CreateTable(
                name: "vehicle_models",
                columns: table => new
                {
                    vehicle_model_id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenance_plan_id = table.Column<Guid>(type: "uuid", nullable: false),
                    model_code = table.Column<string>(type: "text", nullable: false),
                    model_name = table.Column<string>(type: "text", nullable: true),
                    colors = table.Column<List<string>>(type: "text[]", nullable: false),
                    battery_type = table.Column<int>(type: "integer", nullable: true),
                    standard_charging_time = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    motor_type = table.Column<int>(type: "integer", nullable: false),
                    maximum_power = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    shock_absorbers = table.Column<string>(type: "text", nullable: false),
                    battery_capacity = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    maximum_speed = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    range_per_charge = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    weight = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    length = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    width = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    height = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    front_brakes = table.Column<string>(type: "text", nullable: false),
                    rear_brakes = table.Column<string>(type: "text", nullable: false),
                    warranty_period = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vehicle_models", x => x.vehicle_model_id);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    vehicle_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vehicle_model_id = table.Column<Guid>(type: "uuid", nullable: false),
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    color = table.Column<string>(type: "text", nullable: true),
                    classis_number = table.Column<string>(type: "text", nullable: false),
                    engine_number = table.Column<string>(type: "text", nullable: false),
                    license_plate_n_umber = table.Column<string>(type: "text", nullable: false),
                    purchase_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    warranty_start_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    warranty_end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vehicles", x => x.vehicle_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account_roles");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "actions");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "ev_check_details");

            migrationBuilder.DropTable(
                name: "ev_checks");

            migrationBuilder.DropTable(
                name: "export_note_details");

            migrationBuilder.DropTable(
                name: "export_notes");

            migrationBuilder.DropTable(
                name: "import_note_details");

            migrationBuilder.DropTable(
                name: "import_notes");

            migrationBuilder.DropTable(
                name: "inventories");

            migrationBuilder.DropTable(
                name: "maintenance_plans");

            migrationBuilder.DropTable(
                name: "maintenance_stage_details");

            migrationBuilder.DropTable(
                name: "maintenance_stages");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "pages");

            migrationBuilder.DropTable(
                name: "part_items");

            migrationBuilder.DropTable(
                name: "part_models");

            migrationBuilder.DropTable(
                name: "part_types");

            migrationBuilder.DropTable(
                name: "parts");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "rm_as");

            migrationBuilder.DropTable(
                name: "rma_details");

            migrationBuilder.DropTable(
                name: "role_permissions");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "service_centers");

            migrationBuilder.DropTable(
                name: "slot_times");

            migrationBuilder.DropTable(
                name: "staff_profiles");

            migrationBuilder.DropTable(
                name: "stage_vehicles");

            migrationBuilder.DropTable(
                name: "vehicle_models");

            migrationBuilder.DropTable(
                name: "vehicles");
        }
    }
}
