using DomainAction = eMotoCare.Core.Entites.Action;
using DomainProfile = eMotoCare.Core.Entites.Profile;
using eMotoCare.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eMotoCare.Infrastructure.Persistence.Configurations;

public class AccountRoleConfiguration : IEntityTypeConfiguration<AccountRole>
{
    public void Configure(EntityTypeBuilder<AccountRole> builder)
    {
        builder.HasKey(accountRole => new { accountRole.AccountId, accountRole.RoleId });
    }
}

public class ExportNoteDetailConfiguration : IEntityTypeConfiguration<ExportNoteDetail>
{
    public void Configure(EntityTypeBuilder<ExportNoteDetail> builder)
    {
        builder.HasKey(exportNoteDetail => exportNoteDetail.ExpotNoteDetailId);
    }
}

public class EVCheckDetailConfiguration : IEntityTypeConfiguration<EVCheckDetail>
{
    public void Configure(EntityTypeBuilder<EVCheckDetail> builder)
    {
        builder.HasKey(evCheckDetail => evCheckDetail.EVCheckDetaikId);
    }
}

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(payment => payment.PayemntId);
    }
}

public class DomainActionConfiguration : IEntityTypeConfiguration<DomainAction>
{
    public void Configure(EntityTypeBuilder<DomainAction> builder)
    {
        builder.ToTable("Actions");
        builder.HasKey(action => action.ActionId);
    }
}

public class DomainProfileConfiguration : IEntityTypeConfiguration<DomainProfile>
{
    public void Configure(EntityTypeBuilder<DomainProfile> builder)
    {
        builder.ToTable("Profiles");
        builder.HasKey(profile => profile.ProfileId);
    }
}
