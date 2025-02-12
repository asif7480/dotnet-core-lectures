using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session11.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstAddFeeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fee",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "Students");
        }
    }
}
