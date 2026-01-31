using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProfileSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profile_settings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profile_settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountSettingsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ChanceOfRegression = table.Column<uint>(type: "INTEGER", nullable: false),
                    MinMaxPauseAfterScrolling = table.Column<uint>(type: "INTEGER", nullable: false),
                    MinMaxScrollDuration = table.Column<uint>(type: "INTEGER", nullable: false),
                    MinMaxScrollStep = table.Column<uint>(type: "INTEGER", nullable: false),
                    ProfileType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profile_settings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_profile_settings_account_settings_AccountSettingsId",
                        column: x => x.AccountSettingsId,
                        principalTable: "account_settings",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_profile_settings_AccountSettingsId_ProfileType",
                table: "profile_settings",
                columns: new[] { "AccountSettingsId", "ProfileType" },
                unique: true);
        }
    }
}
