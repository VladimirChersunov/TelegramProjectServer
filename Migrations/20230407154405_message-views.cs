using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class messageviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Viewed",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Chats",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "MessageViews",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageViews", x => new { x.UserId, x.MessageId });
                });

            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 41,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 42,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 43,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 44,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 45,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 46,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 47,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 48,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 49,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 50,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 51,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 52,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 53,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 54,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 55,
                column: "AuthorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 18, 44, 5, 186, DateTimeKind.Local).AddTicks(9987));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageViews");

            migrationBuilder.AddColumn<bool>(
                name: "Viewed",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Chats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 41,
                column: "AuthorId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 42,
                column: "AuthorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 43,
                column: "AuthorId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 44,
                column: "AuthorId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 45,
                column: "AuthorId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 46,
                column: "AuthorId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 47,
                column: "AuthorId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 48,
                column: "AuthorId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 49,
                column: "AuthorId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 50,
                column: "AuthorId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 51,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 52,
                column: "AuthorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 53,
                column: "AuthorId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 54,
                column: "AuthorId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 55,
                column: "AuthorId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4650), false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4652), false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4653), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4654), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4655), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4656), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4657), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4658), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4659), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4660), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4661), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4662), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4663), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4664), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4664), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4665), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4666), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4667), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4668), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4669), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4670), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4671), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4672), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4673), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4674), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4675), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4676), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4677), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4706), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4707), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4708), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4709), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4710), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4710), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4711), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4712), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4713), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4714), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4715), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4716), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4717), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4718), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4719), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4720), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4721), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4722), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4723), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4724), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4724), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4725), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4726), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4727), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4728), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4729), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4730), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4731), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4732), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4733), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4734), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4735), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4736), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4737), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4738), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4738), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4739), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4740), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4741), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4742), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4743), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4744), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4745), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4746), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4747), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4748), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4749), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4750), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4751), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4752), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4753), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4753), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4754), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4755), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4756), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4757), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4758), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4759), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4760), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4761), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4762), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4763), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4764), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4765), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4766), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4767), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4768), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4768), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4769), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4770), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4771), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4772), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4773), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4774), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4775), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4776), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4777), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4778), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4779), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4780), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4781), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4782), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4783), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4783), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4784), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4785), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4786), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4787), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4788), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4789), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4790), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4791), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4792), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4793), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4794), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4795), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4796), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4797), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4797), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4798), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4799), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4800), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4801), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4802), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4803), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4804), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4805), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4806), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4807), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4808), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4809), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4810), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4810), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4875), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4876), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4877), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4878), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4879), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4879), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4880), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4881), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4882), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4883), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4884), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4885), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4886), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4887), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4888), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4890), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4890), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4891), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4892), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4893), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4894), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4895), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4896), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4898), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4899), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4900), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4901), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4902), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4903), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4904), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4905), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4906), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4906), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4908), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4908), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4909), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4910), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4911), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4912), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4913), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4914), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4915), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4916), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4917), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4918), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4919), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4920), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4921), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4922), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4922), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4923), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4924), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4925), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4926), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4927), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4928), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4929), true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "SendTime", "Viewed" },
                values: new object[] { new DateTime(2023, 4, 5, 20, 15, 17, 441, DateTimeKind.Utc).AddTicks(4930), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastOnline",
                value: new DateTime(2023, 4, 5, 23, 15, 17, 441, DateTimeKind.Local).AddTicks(4269));
        }
    }
}
