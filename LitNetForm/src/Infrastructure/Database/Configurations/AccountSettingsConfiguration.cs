using System.Text.Json;
using Contracts.Enums;
using Core.Entities;
using Core.Entities.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Database.Configurations;

public class AccountSettingsConfiguration : IEntityTypeConfiguration<AccountSettings>
{
    public void Configure(EntityTypeBuilder<AccountSettings> builder)
    {
        builder.ToTable("account_settings");
        
        // Уникальный индекс для связи с аккаунтом
        builder.HasIndex(a => a.AccountId).IsUnique();

        builder.HasKey(a => a.AccountId);

        builder.Property(a => a.AccountId)
            .HasColumnName("account_id");

        builder.Property(a => a.CreatedAt)
            .HasColumnName("created_at")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(a => a.UpdatedAt)
            .HasColumnName("updated_at")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .ValueGeneratedOnAddOrUpdate();

        builder.Property(a => a.ReadBook)
            .HasColumnName("read_book")
            .HasConversion(SetValueConverter())
            .HasColumnType("TEXT");
        
        builder.Property(a => a.AddToLibrary)
            .HasColumnName("add_to_library")
            .HasConversion(SetValueConverter())
            .HasColumnType("TEXT");
        
        builder.Property(a => a.LikeTheBook)
            .HasColumnName("like_the_book")
            .HasConversion(SetValueConverter())
            .HasColumnType("TEXT");
        
        builder.Property(a => a.SubscribeToTheAuthor)
            .HasColumnName("subscribe_to_the_author")
            .HasConversion(SetValueConverter())
            .HasColumnType("TEXT");
        
        builder.Property(a => a.PostComment)
            .HasColumnName("post_comment")
            .HasConversion(SetValueConverter())
            .HasColumnType("TEXT");
        
        builder.Property(a => a.MakeADonationToTheAuthor)
            .HasColumnName("make_donation_to_the_author")
            .HasConversion(SetValueConverter())
            .HasColumnType("TEXT");
        
        builder.Property(a => a.BuyABook)
            .HasColumnName("buy_a_book")
            .HasConversion(SetValueConverter())
            .HasColumnType("TEXT");

        // Установка значений по умолчанию полей
        builder.Property(a => a.ConstantDelay)
            .HasColumnName("constant_delay")
            .HasDefaultValue(1000);
        
        builder.Property(a => a.FloatingIncrementalDelay)
            .HasColumnName("floating_incremental_delay")
            .HasDefaultValue(500);
        
        builder.Property(a => a.ReadProfile)
            .HasColumnName("read_profile")
            .HasDefaultValue(ReadProfile.DeepReader);
    }

    private static ValueConverter<SettingState, string> SetValueConverter()
    {
        ValueConverter<SettingState, string> converter = new ValueConverter<SettingState, string>(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<SettingState>(v, (JsonSerializerOptions)null)
        );

        return converter;
    }
}