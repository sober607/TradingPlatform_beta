using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingPlatformTest.Migrations
{
    public partial class RateAddLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RateLastSyncTime",
                table: "Currencies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RateLastSyncTime",
                table: "Currencies");
        }
    }
}
