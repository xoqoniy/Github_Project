using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repositories_Organizations_OrganizationId",
                table: "Repositories");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AlterColumn<long>(
                name: "OrganizationId",
                table: "Repositories",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "Repositories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "OrganizationId", "RepositoryType", "StarsCount", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nimadir", "Github_Project", null, 10, 0, null, 1L });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Description", "Email", "FirstName", "FollowersCount", "FollowingPeople", "LastName", "Link", "Password", "UpdatedAt" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "asad@gmail.com", "Asadbek", 0, 0, "Zaylobiddinov", "", "87654321", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Repositories_Organizations_OrganizationId",
                table: "Repositories",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repositories_Organizations_OrganizationId",
                table: "Repositories");

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.AlterColumn<long>(
                name: "OrganizationId",
                table: "Repositories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Description", "Email", "FirstName", "FollowersCount", "FollowingPeople", "LastName", "Link", "Password", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "sm.ashurov5@gmail.com", "Safarmurod", 0, 0, "Ashurov", "", "12345678", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Repositories_Organizations_OrganizationId",
                table: "Repositories",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
