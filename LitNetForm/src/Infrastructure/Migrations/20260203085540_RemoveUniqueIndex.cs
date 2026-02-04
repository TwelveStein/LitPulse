using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_account_action_history_account_id",
                table: "account_action_history");

            migrationBuilder.CreateIndex(
                name: "IX_account_action_history_account_id",
                table: "account_action_history",
                column: "account_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_account_action_history_account_id",
                table: "account_action_history");

            migrationBuilder.CreateIndex(
                name: "IX_account_action_history_account_id",
                table: "account_action_history",
                column: "account_id",
                unique: true);
        }
    }
}
