using DomainAction = eMotoCare.Core.Entites.Action;
using DomainProfile = eMotoCare.Core.Entites.Profile;
using eMotoCare.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eMotoCare.Infrastructure.Persistence;

public class EMotoCareDbContext : DbContext
{
    public EMotoCareDbContext(DbContextOptions<EMotoCareDbContext> options)
        : base(options)
    {
    }

    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<AccountRole> AccountRoles => Set<AccountRole>();
    public DbSet<DomainAction> Actions => Set<DomainAction>();
    public DbSet<Address> Addresses => Set<Address>();
    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<EVCheck> EVChecks => Set<EVCheck>();
    public DbSet<EVCheckDetail> EVCheckDetails => Set<EVCheckDetail>();
    public DbSet<ExportNote> ExportNotes => Set<ExportNote>();
    public DbSet<ExportNoteDetail> ExportNoteDetails => Set<ExportNoteDetail>();
    public DbSet<ImportNote> ImportNotes => Set<ImportNote>();
    public DbSet<ImportNoteDetail> ImportNoteDetails => Set<ImportNoteDetail>();
    public DbSet<Inventory> Inventories => Set<Inventory>();
    public DbSet<MaintenancePlan> MaintenancePlans => Set<MaintenancePlan>();
    public DbSet<MaintenanceStage> MaintenanceStages => Set<MaintenanceStage>();
    public DbSet<MaintenanceStageDetail> MaintenanceStageDetails => Set<MaintenanceStageDetail>();
    public DbSet<Module> Modules => Set<Module>();
    public DbSet<Page> Pages => Set<Page>();
    public DbSet<Part> Parts => Set<Part>();
    public DbSet<PartItem> PartItems => Set<PartItem>();
    public DbSet<PartModel> PartModels => Set<PartModel>();
    public DbSet<PartType> PartTypes => Set<PartType>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Permission> Permissions => Set<Permission>();
    public DbSet<DomainProfile> Profiles => Set<DomainProfile>();
    public DbSet<RMA> RMAs => Set<RMA>();
    public DbSet<RMADetail> RMADetails => Set<RMADetail>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<RolePermission> RolePermissions => Set<RolePermission>();
    public DbSet<ServiceCenter> ServiceCenters => Set<ServiceCenter>();
    public DbSet<SlotTime> SlotTimes => Set<SlotTime>();
    public DbSet<StaffProfile> StaffProfiles => Set<StaffProfile>();
    public DbSet<StageVehicle> StageVehicles => Set<StageVehicle>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<VehicleModel> VehicleModels => Set<VehicleModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EMotoCareDbContext).Assembly);
        modelBuilder.ApplyPostgreSqlConventions();
        modelBuilder.UseSnakeCaseNames();
    }
}

internal static class PostgreSqlModelBuilderExtensions
{
    public static void ApplyPostgreSqlConventions(this ModelBuilder modelBuilder)
    {
        foreach (IMutableProperty property in modelBuilder.Model
                     .GetEntityTypes()
                     .SelectMany(entityType => entityType.GetProperties()))
        {
            Type clrType = Nullable.GetUnderlyingType(property.ClrType) ?? property.ClrType;

            if (clrType == typeof(decimal))
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }

            if (clrType == typeof(DateTime))
            {
                property.SetColumnType("timestamp without time zone");
            }
        }
    }
}

internal static class SnakeCaseModelBuilderExtensions
{
    public static void UseSnakeCaseNames(this ModelBuilder modelBuilder)
    {
        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            string? tableName = entityType.GetTableName();
            if (!string.IsNullOrWhiteSpace(tableName))
            {
                entityType.SetTableName(ToSnakeCase(tableName));
            }

            StoreObjectIdentifier tableIdentifier = StoreObjectIdentifier.Table(
                entityType.GetTableName()!,
                entityType.GetSchema());

            foreach (IMutableProperty property in entityType.GetProperties())
            {
                string? columnName = property.GetColumnName(tableIdentifier);
                if (!string.IsNullOrWhiteSpace(columnName))
                {
                    property.SetColumnName(ToSnakeCase(columnName));
                }
            }

            foreach (IMutableKey key in entityType.GetKeys())
            {
                key.SetName(ToSnakeCase(key.GetName()!));
            }

            foreach (IMutableForeignKey foreignKey in entityType.GetForeignKeys())
            {
                string? constraintName = foreignKey.GetConstraintName();
                if (!string.IsNullOrWhiteSpace(constraintName))
                {
                    foreignKey.SetConstraintName(ToSnakeCase(constraintName));
                }
            }

            foreach (IMutableIndex index in entityType.GetIndexes())
            {
                string? databaseName = index.GetDatabaseName();
                if (!string.IsNullOrWhiteSpace(databaseName))
                {
                    index.SetDatabaseName(ToSnakeCase(databaseName));
                }
            }
        }
    }

    private static string ToSnakeCase(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        List<char> result = [];
        for (int index = 0; index < value.Length; index++)
        {
            char current = value[index];
            char? previous = index > 0 ? value[index - 1] : null;
            char? next = index < value.Length - 1 ? value[index + 1] : null;

            if (current == '-' || current == ' ')
            {
                current = '_';
            }

            bool shouldPrependUnderscore =
                char.IsUpper(current)
                && result.Count > 0
                && result[^1] != '_'
                && (previous is not null && (char.IsLower(previous.Value) || char.IsDigit(previous.Value))
                    || next is not null && char.IsLower(next.Value));

            if (shouldPrependUnderscore)
            {
                result.Add('_');
            }

            result.Add(char.ToLowerInvariant(current));
        }

        return new string(result.ToArray());
    }
}
