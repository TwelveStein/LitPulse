using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccountIdName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_action_history_account_AccountId",
                table: "account_action_history");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "account_action_history",
                newName: "account_id");

            migrationBuilder.RenameIndex(
                name: "IX_account_action_history_AccountId",
                table: "account_action_history",
                newName: "IX_account_action_history_account_id");

            migrationBuilder.AddForeignKey(
                name: "FK_account_action_history_account_account_id",
                table: "account_action_history",
                column: "account_id",
                principalTable: "account",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_action_history_account_account_id",
                table: "account_action_history");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "account_action_history",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_account_action_history_account_id",
                table: "account_action_history",
                newName: "IX_account_action_history_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_account_action_history_account_AccountId",
                table: "account_action_history",
                column: "AccountId",
                principalTable: "account",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
