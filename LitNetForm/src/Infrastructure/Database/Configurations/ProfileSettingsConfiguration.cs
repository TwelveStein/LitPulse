/*using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations;

public class ProfileSettingsConfiguration : IEntityTypeConfiguration<ProfileSettings>
{
    public void Configure(EntityTypeBuilder<ProfileSettings> builder)
    {
        builder.ToTable("profile_settings");
        
        // Композитный уникальный ключ: AccountSettingsId + ProfileType
        builder.HasIndex(ps => new { ps.AccountSettingsId, ps.ProfileType })
            .IsUnique();

        // Связь с AccountSettings
        builder.HasOne(ps => ps.AccountSettings)
            .WithMany(a => a.ProfileSettings)
            .HasForeignKey(ps => ps.AccountSettingsId)
            .OnDelete(DeleteBehavior.Cascade);

        // Значения по умолчанию для разных профилей
        builder.HasData(
            // Значения по умолчанию будут добавляться при создании
            // через метод InitializeProfileSettings
        );
    }
}*/