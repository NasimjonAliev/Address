using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Address.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnsInCountryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistrictName",
                table: "Cities");

            migrationBuilder.AddColumn<string>(
                name: "DistrictName",
                table: "Regions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Countries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mainland",
                table: "Countries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Population",
                table: "Countries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Countries",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistrictName",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Mainland",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "DistrictName",
                table: "Cities",
                type: "text",
                nullable: true);
        }
    }
}
