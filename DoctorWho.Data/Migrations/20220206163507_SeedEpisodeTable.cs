using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Data.Migrations
{
    public partial class SeedEpisodeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "06/02/2015", 1, "Horror", null, 5, "" },
                    { 2, 4, 3, "25/04/2021", 100, "Drama", null, 16, "Legally Blonde" },
                    { 3, 4, 2, "08/03/2019", 1, "Sci-Fi", null, 5, "Star Wars" },
                    { 4, 1, 5, "22/10/2018", 22, "Thriller", null, 6, "Fast and Furious" },
                    { 5, 3, 2, "16/12/2015", 2, "Comedy", null, 3, "Dumb and Dumber" }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanion",
                columns: new[] { "EpisodeId", "CompanionId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 5 },
                    { 4, 1 },
                    { 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemy",
                columns: new[] { "EpisodeId", "EnemyId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 5 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);
        }
    }
}
