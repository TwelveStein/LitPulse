using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations;

public class AccountActionHistoryConfiguration : IEntityTypeConfiguration<AccountActionHistory>
{
    public void Configure(EntityTypeBuilder<AccountActionHistory> builder)
    {
        builder.ToTable("account_action_history");
        
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .HasColumnName("id");
        
        builder.Property(a => a.AccountId)
            .HasColumnName("account_id");
        
        builder.Property(a => a.SessionId)
            .HasColumnName("session_id")
            .HasConversion(
                id => id.ToByteArray(),
                id => new Guid(id))
            .IsRequired();
        
        builder.Property(a => a.ActionType)
            .HasColumnName("action_type")
            .IsRequired();
        
        builder.Property(a => a.Target)
            .HasColumnName("target")
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(a => a.ActionResult)
            .HasColumnName("action_result")
            .HasMaxLength(100);
        
        builder.Property(a => a.ActionDate)
            .HasColumnName("action_date")
            .IsRequired();
        
        // индекс
        builder.HasIndex(a => a.AccountId);
        
        // Связь один-ко-многим с Account
        builder.HasOne(a => a.Account)
            .WithMany()
            .HasForeignKey(a => a.AccountId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}