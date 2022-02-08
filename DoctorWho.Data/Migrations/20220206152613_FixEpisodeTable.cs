using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Data.Migrations
{
    public partial class FixEpisodeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

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
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

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

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_AuthorId",
                table: "Episodes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_DoctorId",
                table: "Episodes",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_Episodes_AuthorId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_Episodes_DoctorId",
                table: "Episodes");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Ahmad" },
                    { 2, "Osama" },
                    { 3, "Jamil" },
                    { 4, "Tareq" },
                    { 5, "Rami" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Thor", null },
                    { 2, "Dr. Strange", null },
                    { 3, "Captain", null },
                    { 4, "Ironman", null },
                    { 5, "Back Widow", null }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 5, "25/09/1977", "Fatima", 599856299L, "15/12/2013", "11/03/2015" },
                    { 4, "26/06/2000", "Lujain", 597050633L, "15/04/2017", "12/12/2020" },
                    { 3, "22/10/1998", "Rayyan", 597965571L, "09/02/2013", "06/06/2018" },
                    { 2, "29/07/1990", "Malak", 598264767L, "01/01/2015", "16/03/2017" },
                    { 1, "14/02/1999", "Hazem", 599154866L, "05/12/2010", "06/02/2015" }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 1, "Mind Control", "Thanos" },
                    { 2, "Shapeshifting", "Hela" },
                    { 3, "Invisibility", "Loki" },
                    { 4, "Immortality", "Glactus" },
                    { 5, "Time travel", "DoomsDay" }
                });

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
    }
}
