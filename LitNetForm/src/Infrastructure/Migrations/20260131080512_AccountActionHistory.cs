using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AccountActionHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountSettings_Accounts_AccountId",
                table: "AccountSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileSettings_AccountSettings_AccountSettingsId",
                table: "ProfileSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfileSettings",
                table: "ProfileSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountSettings",
                table: "AccountSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "ProfileSettings",
                newName: "profile_settings");

            migrationBuilder.RenameTable(
                name: "AccountSettings",
                newName: "account_settings");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "account");

            migrationBuilder.RenameIndex(
                name: "IX_ProfileSettings_AccountSettingsId_ProfileType",
                table: "profile_settings",
                newName: "IX_profile_settings_AccountSettingsId_ProfileType");

            migrationBuilder.RenameIndex(
                name: "IX_AccountSettings_AccountId",
                table: "account_settings",
                newName: "IX_account_settings_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_Login",
                table: "account",
                newName: "IX_account_Login");

            migrationBuilder.AlterColumn<int>(
                name: "ReadProfile",
                table: "account_settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "FloatingIncrementalDelay",
                table: "account_settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 500,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ConstantDelay",
                table: "account_settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 1000,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_profile_settings",
                table: "profile_settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_account_settings",
                table: "account_settings",
                column: "AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_account",
                table: "account",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "account_action_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActionType = table.Column<int>(type: "INTEGER", nullable: false),
                    Target = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ActionResult = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    ActionDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_action_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_account_action_history_account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_account_action_history_AccountId",
                table: "account_action_history",
                column: "AccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_account_settings_account_AccountId",
                table: "account_settings",
                column: "AccountId",
                principalTable: "account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_profile_settings_account_settings_AccountSettingsId",
                table: "profile_settings",
                column: "AccountSettingsId",
                principalTable: "account_settings",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_settings_account_AccountId",
                table: "account_settings");

            migrationBuilder.DropForeignKey(
                name: "FK_profile_settings_account_settings_AccountSettingsId",
                table: "profile_settings");

            migrationBuilder.DropTable(
                name: "account_action_history");

            migrationBuilder.DropPrimaryKey(
                name: "PK_profile_settings",
                table: "profile_settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_account_settings",
                table: "account_settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_account",
                table: "account");

            migrationBuilder.RenameTable(
                name: "profile_settings",
                newName: "ProfileSettings");

            migrationBuilder.RenameTable(
                name: "account_settings",
                newName: "AccountSettings");

            migrationBuilder.RenameTable(
                name: "account",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_profile_settings_AccountSettingsId_ProfileType",
                table: "ProfileSettings",
                newName: "IX_ProfileSettings_AccountSettingsId_ProfileType");

            migrationBuilder.RenameIndex(
                name: "IX_account_settings_AccountId",
                table: "AccountSettings",
                newName: "IX_AccountSettings_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_account_Login",
                table: "Accounts",
                newName: "IX_Accounts_Login");

            migrationBuilder.AlterColumn<int>(
                name: "ReadProfile",
                table: "AccountSettings",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "FloatingIncrementalDelay",
                table: "AccountSettings",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldDefaultValue: 500);

            migrationBuilder.AlterColumn<int>(
                name: "ConstantDelay",
                table: "AccountSettings",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldDefaultValue: 1000);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfileSettings",
                table: "ProfileSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountSettings",
                table: "AccountSettings",
                column: "AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSettings_Accounts_AccountId",
                table: "AccountSettings",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileSettings_AccountSettings_AccountSettingsId",
                table: "ProfileSettings",
                column: "AccountSettingsId",
                principalTable: "AccountSettings",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
