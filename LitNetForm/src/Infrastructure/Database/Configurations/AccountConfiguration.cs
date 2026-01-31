using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("account");
        
        builder.HasKey(a => a.Id);
        
        builder.Property(a => a.Id).HasColumnName("id");
        
        builder.Property(a => a.Login)
            .HasColumnName("login")
            .IsRequired();
        
        builder.Property(a => a.Password)
            .HasColumnName("password")
            .IsRequired();
        
        builder.Property(a => a.LitNet)
            .HasColumnName("lit_net")
            .IsRequired();
        
        builder.Property(a => a.LitMarket)
            .HasColumnName("lit_market")
            .IsRequired();
        
        builder.Property(a => a.IsActive)
            .HasColumnName("is_active")
            .IsRequired();
        
        // Уникальный индекс для логина
        builder.HasIndex(a => a.Login)
            .IsUnique();
                
        // Связь один-к-одному с AccountSettings
        builder.HasOne(a => a.AccountSettings)
            .WithOne()
            .HasForeignKey<AccountSettings>(a => a.AccountId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}