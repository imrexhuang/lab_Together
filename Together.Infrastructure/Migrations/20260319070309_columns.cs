using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Together.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fee",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Lat",
                table: "Events",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Lng",
                table: "Events",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Events");
        }
    }
}
