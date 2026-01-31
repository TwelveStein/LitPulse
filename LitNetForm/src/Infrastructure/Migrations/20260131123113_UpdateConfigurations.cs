using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_settings_account_AccountId",
                table: "account_settings");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "account_settings",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "SubscribeToTheAuthor",
                table: "account_settings",
                newName: "subscribe_to_the_author");

            migrationBuilder.RenameColumn(
                name: "ReadProfile",
                table: "account_settings",
                newName: "read_profile");

            migrationBuilder.RenameColumn(
                name: "ReadBook",
                table: "account_settings",
                newName: "read_book");

            migrationBuilder.RenameColumn(
                name: "PostComment",
                table: "account_settings",
                newName: "post_comment");

            migrationBuilder.RenameColumn(
                name: "MakeADonationToTheAuthor",
                table: "account_settings",
                newName: "make_donation_to_the_author");

            migrationBuilder.RenameColumn(
                name: "LikeTheBook",
                table: "account_settings",
                newName: "like_the_book");

            migrationBuilder.RenameColumn(
                name: "FloatingIncrementalDelay",
                table: "account_settings",
                newName: "floating_incremental_delay");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "account_settings",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ConstantDelay",
                table: "account_settings",
                newName: "constant_delay");

            migrationBuilder.RenameColumn(
                name: "BuyABook",
                table: "account_settings",
                newName: "buy_a_book");

            migrationBuilder.RenameColumn(
                name: "AddToLibrary",
                table: "account_settings",
                newName: "add_to_library");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "account_settings",
                newName: "account_id");

            migrationBuilder.RenameIndex(
                name: "IX_account_settings_AccountId",
                table: "account_settings",
                newName: "IX_account_settings_account_id");

            migrationBuilder.RenameColumn(
                name: "Target",
                table: "account_action_history",
                newName: "target");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "account_action_history",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ActionType",
                table: "account_action_history",
                newName: "action_type");

            migrationBuilder.RenameColumn(
                name: "ActionResult",
                table: "account_action_history",
                newName: "action_result");

            migrationBuilder.RenameColumn(
                name: "ActionDate",
                table: "account_action_history",
                newName: "action_date");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "account",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "account",
                newName: "login");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "account",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LitNet",
                table: "account",
                newName: "lit_net");

            migrationBuilder.RenameColumn(
                name: "LitMarket",
                table: "account",
                newName: "lit_market");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "account",
                newName: "is_active");

            migrationBuilder.RenameIndex(
                name: "IX_account_Login",
                table: "account",
                newName: "IX_account_login");

            migrationBuilder.AddForeignKey(
                name: "FK_account_settings_account_account_id",
                table: "account_settings",
                column: "account_id",
                principalTable: "account",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_settings_account_account_id",
                table: "account_settings");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "account_settings",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "subscribe_to_the_author",
                table: "account_settings",
                newName: "SubscribeToTheAuthor");

            migrationBuilder.RenameColumn(
                name: "read_profile",
                table: "account_settings",
                newName: "ReadProfile");

            migrationBuilder.RenameColumn(
                name: "read_book",
                table: "account_settings",
                newName: "ReadBook");

            migrationBuilder.RenameColumn(
                name: "post_comment",
                table: "account_settings",
                newName: "PostComment");

            migrationBuilder.RenameColumn(
                name: "make_donation_to_the_author",
                table: "account_settings",
                newName: "MakeADonationToTheAuthor");

            migrationBuilder.RenameColumn(
                name: "like_the_book",
                table: "account_settings",
                newName: "LikeTheBook");

            migrationBuilder.RenameColumn(
                name: "floating_incremental_delay",
                table: "account_settings",
                newName: "FloatingIncrementalDelay");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "account_settings",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "constant_delay",
                table: "account_settings",
                newName: "ConstantDelay");

            migrationBuilder.RenameColumn(
                name: "buy_a_book",
                table: "account_settings",
                newName: "BuyABook");

            migrationBuilder.RenameColumn(
                name: "add_to_library",
                table: "account_settings",
                newName: "AddToLibrary");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "account_settings",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_account_settings_account_id",
                table: "account_settings",
                newName: "IX_account_settings_AccountId");

            migrationBuilder.RenameColumn(
                name: "target",
                table: "account_action_history",
                newName: "Target");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "account_action_history",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "action_type",
                table: "account_action_history",
                newName: "ActionType");

            migrationBuilder.RenameColumn(
                name: "action_result",
                table: "account_action_history",
                newName: "ActionResult");

            migrationBuilder.RenameColumn(
                name: "action_date",
                table: "account_action_history",
                newName: "ActionDate");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "account",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "login",
                table: "account",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "account",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "lit_net",
                table: "account",
                newName: "LitNet");

            migrationBuilder.RenameColumn(
                name: "lit_market",
                table: "account",
                newName: "LitMarket");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "account",
                newName: "IsActive");

            migrationBuilder.RenameIndex(
                name: "IX_account_login",
                table: "account",
                newName: "IX_account_Login");

            migrationBuilder.AddForeignKey(
                name: "FK_account_settings_account_AccountId",
                table: "account_settings",
                column: "AccountId",
                principalTable: "account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
