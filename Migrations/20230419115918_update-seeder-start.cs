using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class updateseederstart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortMessage",
                value: "Vertegro:He is sleeping, dumbass");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortMessage",
                value: "liokSinner:This is start of this channel, welcome everyone!");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2017, 10, 4, 10, 49, 9, 297, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublishTime", "ShortMessage" },
                values: new object[] { new DateTime(2017, 10, 4, 10, 44, 9, 298, DateTimeKind.Local).AddTicks(5765), "olgerd17: DONT IGNORE ME!!!!!" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublishTime", "ShortMessage" },
                values: new object[] { new DateTime(2017, 10, 4, 10, 41, 56, 327, DateTimeKind.Local).AddTicks(5617), "jackKcaj:yo, bro, wassup" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 44, 9, 297, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 44, 9, 298, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 42, 3, 335, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 41, 56, 327, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 49, 9, 297, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 48, 8, 287, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 11, 59, 18, 337, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 221, DateTimeKind.Local).AddTicks(7201), "$2b$10$JGhF2fO9rwTgjbYHsv0gKOAahSl8WDcSiCaUh2ggGQyIj2SdCPVk." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 282, DateTimeKind.Local).AddTicks(2255), "$2b$10$Bq8rRZBtNvPLpYBSYziQZOrZ7rT7TTYMIo7icLcd7PekUTNaUVSX2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 340, DateTimeKind.Local).AddTicks(7745), "$2b$10$kL/Obu9UCXscev1yZ2OFdOZSOJ4f9pUqU2MKQO6loQRNz2cRZUgGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 401, DateTimeKind.Local).AddTicks(531), "$2b$10$aQO8OMa/JM500cJgNV4qj.a4GR8Xdf/RuX4HGorDG8JapTUwYUi3K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 463, DateTimeKind.Local).AddTicks(372), "$2b$10$IKPsWT7JADHHhn5L5t0e8OPH3Pv71mxw0Up8ARVWtgCafbc21tkEK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 522, DateTimeKind.Local).AddTicks(7601), "$2b$10$faRzpw.3pAMJCNmCWebXaOAOKEXcRK5QW/w/etLWqZLdcS9AxpI.6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 584, DateTimeKind.Local).AddTicks(8), "$2b$10$8ia6MhJqcvusl5kHheD9XOPWb/RZizBr8.dFinL2GRFkBX5wntIZO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 644, DateTimeKind.Local).AddTicks(2625), "$2b$10$jeq4vhP4jHLMYWeo1gPqpeiLLfsOQwdOae1TT/.1w48.ZmT/HOfB2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 703, DateTimeKind.Local).AddTicks(2866), "$2b$10$PCifzXOFIQUXOdWZl7ovBuQyobKlw3hm6ZU.C4b55MnV3x/IgvVfy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 762, DateTimeKind.Local).AddTicks(3076), "$2b$10$HXdmUymdC3YF.2i0SwdRbOVhmd6tZV/uQGyjFyumTADYKfKero/NO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 820, DateTimeKind.Local).AddTicks(4023), "$2b$10$28dFmim4RF05/DWx6NFUrO3BrKSZMc10ao3xgOHrv9kGGRcunzLga" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 878, DateTimeKind.Local).AddTicks(2837), "$2b$10$XQ2TIPZmKbBttOjKf9zyY.5nI2yLQBffKreevvdJHb3/581AVNZ/C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 934, DateTimeKind.Local).AddTicks(5115), "$2b$10$kr1R69c6JwCyAfsbeLZP4uOZU.iykdJAhSMj8cuN1103XJExCfYne" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 990, DateTimeKind.Local).AddTicks(6326), "$2b$10$Sq.hqjAsP0oGrh1juG54B.K63yp22xHTNTOeB8cginr5RlcIgar2q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 18, 48, DateTimeKind.Local).AddTicks(6705), "$2b$10$zoOt9jxxPiZWuJm2b4n9I.T/l5kpQ7Ot1Lm3tvs46cU5QLG9o3wse" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 18, 106, DateTimeKind.Local).AddTicks(6841), "$2b$10$9lSAN52wTzUqXA/V2V1/D.NPq/st3TZWF7NRSz15nvVDQ9jOSyrTW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 18, 164, DateTimeKind.Local).AddTicks(6645), "$2b$10$CBrWtnmHMHDdUPEIJ5g9NOsZsmCb/51DnXpoBlRrf76umXMq96Ine" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 18, 222, DateTimeKind.Local).AddTicks(1850), "$2b$10$dhDxJqmevB4QvGamuli24OSOl907.CFiiQbXyEQJky50cdnG/QWxm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 18, 279, DateTimeKind.Local).AddTicks(9665), "$2b$10$LxWy1V6mY4VKJ2tqbYzIYOfUUB2G5Qjqj0p4/DomF8W86zd3tOLk." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 18, 337, DateTimeKind.Local).AddTicks(4768), "$2b$10$VW1stBBj4XiCnY3C7kGN.ekk/5uR8oR5P3hYivhLtGYPwcupkhaT6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 14, 59, 17, 162, DateTimeKind.Local).AddTicks(9222), "$2b$10$muHj1hcwb7A7atPvAwNO7OY2Yn.iKQ33OL3mWwWy2oXFPChorpc5u" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortMessage",
                value: "short message....");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortMessage",
                value: "short message....");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublishTime", "ShortMessage" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "short message...." });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublishTime", "ShortMessage" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "short message...." });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 67, DateTimeKind.Local).AddTicks(7074), "$2b$10$16Ze1S7zuX5DB2yuFZld0Oha0REDL0g70Jdso4EAAFoM.kXgdfkI." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 126, DateTimeKind.Local).AddTicks(3037), "$2b$10$ORB1cxX9snwtfAAKhrAZte9JH3jsugAJiZFVYtj9cRIbDTipET926" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 186, DateTimeKind.Local).AddTicks(2419), "$2b$10$CvRMGcwwzXq4velttyOsFulm7HrMOkJ778efQ4IXIZA4RkqIcmPU6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 244, DateTimeKind.Local).AddTicks(8321), "$2b$10$hEorTqbzVAeTzKHWUmUVZ.Eht/uRWWBKanSZ8ZQ7Lfdo6XHEPjJ.e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 303, DateTimeKind.Local).AddTicks(230), "$2b$10$I3RFhwvm6LkCzhNrRWXKYeXH3OK5dWWrClUE2dasrt/Vlvh5LqH9K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 361, DateTimeKind.Local).AddTicks(5430), "$2b$10$T8n9Xv2t3x2A.avtKSYd1OFhkEkp12SkZ0LLwBBjTcku.vLc8hXs." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 419, DateTimeKind.Local).AddTicks(4017), "$2b$10$l0hZTzVgt4SyEhhHPKrr1eHt8yVGR6CE/qIwEPD8aCqZ9S11Fw2q6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 477, DateTimeKind.Local).AddTicks(6455), "$2b$10$sF69Ce15wjQEbSBA9b2jx.KN4YTZ6x5UeRp0TALQKJLuZkYA7TXcO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 535, DateTimeKind.Local).AddTicks(9030), "$2b$10$RO0OdvE8Dyh3jYD9pw840.Ue6XRMvhUkdkQ53G8kr16ukP0VY9mXy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 593, DateTimeKind.Local).AddTicks(9509), "$2b$10$eZVhK85UnZcv/r9aKheOPu3qYmbIfrBUea7GJzlh8ys26hfcljG5S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 651, DateTimeKind.Local).AddTicks(9562), "$2b$10$EyKuNgABzAQdAbZNZCtYyeYaWj/S0W5yeJhQUhlFUsYSIYP1B54kW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 710, DateTimeKind.Local).AddTicks(2048), "$2b$10$GDEHATHv71bI9OfNFU68/.LnZhh/mz6xrKN/DqHWv3OtU2IMhSnZK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 767, DateTimeKind.Local).AddTicks(8357), "$2b$10$kcGSxQDabfE7oI.8JX.zD.LK77Jja8kJHr3Q7zETnzGB9viG7Z9wO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 825, DateTimeKind.Local).AddTicks(2989), "$2b$10$z6WISxv2/hycCM/1jkTUbejZJWVCpcI6OBr3qIMLOWGIxYWIZqPJy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 882, DateTimeKind.Local).AddTicks(7357), "$2b$10$GlKcmp5UxwN9Mx3Q6xDj/eWLr7PFHsRyFM205feTLCijMbjdBdu92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 940, DateTimeKind.Local).AddTicks(452), "$2b$10$gk0FHXUxwZeOgd7fPFd2xO4.Yk.7T0ctnwfJwT.Io6/9tY6c./jjy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 997, DateTimeKind.Local).AddTicks(8208), "$2b$10$PorUvy1q8Te6ajmir0aQAeCbxI9TsPApVUjCyKiL2l70DpcD.G762" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 4, 55, DateTimeKind.Local).AddTicks(4610), "$2b$10$rLhUywgh/dgTBdG/UcP7.OT7zABY3bKdFxQAfK5I3F8PMplFlfPHK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 4, 113, DateTimeKind.Local).AddTicks(7495), "$2b$10$BymuRCK1kTgzZOziswZtxeQ5gkVfutRE2lJB7SdlUUhpJlag.CQtu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 4, 171, DateTimeKind.Local).AddTicks(5249), "$2b$10$K7blKsZJG1lwJnfS7N63iOly2zrFrBzabZK09Ll3Xe.t9K3/hJtPG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 13, 46, 3, 10, DateTimeKind.Local).AddTicks(318), "$2b$10$.VoeGRqoNwWKt145buaF9uWK4qBymahktyAZupfVp.1BBB0MfrwFa" });
        }
    }
}
