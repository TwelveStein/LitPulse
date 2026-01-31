using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LitNet = table.Column<bool>(type: "INTEGER", nullable: false),
                    LitMarket = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountSettings",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReadBook = table.Column<string>(type: "TEXT", nullable: false),
                    AddToLibrary = table.Column<string>(type: "TEXT", nullable: false),
                    LikeTheBook = table.Column<string>(type: "TEXT", nullable: false),
                    SubscribeToTheAuthor = table.Column<string>(type: "TEXT", nullable: false),
                    PostComment = table.Column<string>(type: "TEXT", nullable: false),
                    MakeADonationToTheAuthor = table.Column<string>(type: "TEXT", nullable: false),
                    BuyABook = table.Column<string>(type: "TEXT", nullable: false),
                    ConstantDelay = table.Column<int>(type: "INTEGER", nullable: false),
                    FloatingIncrementalDelay = table.Column<int>(type: "INTEGER", nullable: false),
                    ReadProfile = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSettings", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_AccountSettings_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountSettingsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfileType = table.Column<int>(type: "INTEGER", nullable: false),
                    ChanceOfRegression = table.Column<uint>(type: "INTEGER", nullable: false),
                    MinMaxScrollStep = table.Column<uint>(type: "INTEGER", nullable: false),
                    MinMaxScrollDuration = table.Column<uint>(type: "INTEGER", nullable: false),
                    MinMaxPauseAfterScrolling = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileSettings_AccountSettings_AccountSettingsId",
                        column: x => x.AccountSettingsId,
                        principalTable: "AccountSettings",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Login",
                table: "Accounts",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountSettings_AccountId",
                table: "AccountSettings",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSettings_AccountSettingsId_ProfileType",
                table: "ProfileSettings",
                columns: new[] { "AccountSettingsId", "ProfileType" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileSettings");

            migrationBuilder.DropTable(
                name: "AccountSettings");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
