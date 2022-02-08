using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Data.Migrations
{
    public partial class FixJointTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EpisodeEnemyId",
                table: "EpisodeEnemy");

            migrationBuilder.DropColumn(
                name: "EpisodeCompanionId",
                table: "EpisodeCompanion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EpisodeEnemyId",
                table: "EpisodeEnemy",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpisodeCompanionId",
                table: "EpisodeCompanion",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
