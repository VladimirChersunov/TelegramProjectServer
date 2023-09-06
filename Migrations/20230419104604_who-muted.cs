using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class whomuted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MuteStatus",
                table: "Chats");

            migrationBuilder.CreateTable(
                name: "ChatMutes",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMutes", x => new { x.UserId, x.ChatId });
                    table.ForeignKey(
                        name: "FK_ChatMutes_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatMutes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 19, 10, 46, 4, 171, DateTimeKind.Utc).AddTicks(7120));

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

            migrationBuilder.CreateIndex(
                name: "IX_ChatMutes_ChatId",
                table: "ChatMutes",
                column: "ChatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMutes");

            migrationBuilder.AddColumn<bool>(
                name: "MuteStatus",
                table: "Chats",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 4,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 5,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 6,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 7,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 8,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 9,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 10,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 11,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 12,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 13,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 14,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 15,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 16,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 17,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 18,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 19,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 20,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 31,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 32,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 33,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 34,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 35,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 36,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 37,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 38,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 39,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 40,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 41,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 42,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 43,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 44,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 45,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 46,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 47,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 48,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 49,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 50,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 51,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 52,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 53,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 54,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 55,
                column: "MuteStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 57, 5, 860, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 4, 730, DateTimeKind.Local).AddTicks(5022), "$2b$10$Lyk1HUMWOqyiGT5qZNPcsOKAvyI3.yK0Rq1sTgS1kogmXJqwgwKu6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 4, 792, DateTimeKind.Local).AddTicks(6365), "$2b$10$7aEZ5Wuy1rqOFNDTGZCwl.uLJzBb/pJjoM1r4xxP9hvJUPWE/Mchi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 4, 851, DateTimeKind.Local).AddTicks(6829), "$2b$10$B.wPyBxpQHHAqSvNJ.7eneimnfSksjD7SANg7AGtJ4mQO0pxbV3Au" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 4, 910, DateTimeKind.Local).AddTicks(8800), "$2b$10$Bna1RhxSg91ylDMywLbEF.ihyLXz.OjeCZdcue1f8CLB8tAwOukc2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 4, 971, DateTimeKind.Local).AddTicks(5461), "$2b$10$3kTRwlgZT7yKbFo30gbhWe1EBCfb0BXsBkwzhzxExVE.xQjxF2ZEu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 33, DateTimeKind.Local).AddTicks(109), "$2b$10$LiHQstY0MCg3zWnwdhQQ8eD7MXfWuR5tyOcD7HnNre4DPVf.G0vFS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 93, DateTimeKind.Local).AddTicks(7066), "$2b$10$LMm4ogBdNyt3D49iOG9gr.Y8Qz34lplXu2qbQc5HjAcft6ty.4QVG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 153, DateTimeKind.Local).AddTicks(2470), "$2b$10$x4k.rbCJdkh2MjwywPMNkeXCnQKKoh77DJj0LutEeZE8niwEtHso6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 212, DateTimeKind.Local).AddTicks(5157), "$2b$10$pU0SUlaDEbgo1ph7D7fDWeqcvXh/cAkN4edcFwX/dmcDuSOrwCfsm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 273, DateTimeKind.Local).AddTicks(7501), "$2b$10$aA2ABOuGplPqPngFdG8ZH.IgrBcDZcZkuA9LA2xstRIH.hnmf2RBa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 333, DateTimeKind.Local).AddTicks(1906), "$2b$10$jpbiOzExMmFVNBMk79ZIVuPVQcf7D7ad0Q32gpDCLxK2BQzkgOQUu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 391, DateTimeKind.Local).AddTicks(8804), "$2b$10$MxoyLdA28zRNa/DhkaLTiOYZeY0LefMWb7Gt24lcPwtIpNpfUMT1q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 449, DateTimeKind.Local).AddTicks(9973), "$2b$10$vnSKpv99x2R645Oi0ovqPOxgJmFlnSogYvM6ekD0GiC1jmbL8De9S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 507, DateTimeKind.Local).AddTicks(9646), "$2b$10$LMswRKCVCK81qqIeQYlND.ZvxqHA8j7uRsveVJJLXcWqZx/xAoFQu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 566, DateTimeKind.Local).AddTicks(1035), "$2b$10$MrjqroWKZWtMs3U48ZD74.LN18oY24PC1tV5pxND0kR.kJlvpV8z6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 624, DateTimeKind.Local).AddTicks(4760), "$2b$10$cgfN2SZ/Hj05aeqYUGj9zuERsyxI/kb/5OzTtsIC7rSoNTGaoczSK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 682, DateTimeKind.Local).AddTicks(6144), "$2b$10$Sgx/sD0NMWI8RO6ShZZs/uXqxjt7nE5/fIVPH.OSL55.PhwwIAesC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 740, DateTimeKind.Local).AddTicks(8638), "$2b$10$GelXDGcyp1sxyGrpIgDYoeeYOfWkG4gLuQYHu3ORyHuKagNv.B.NW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 802, DateTimeKind.Local).AddTicks(595), "$2b$10$CLSswH7n58Ra6eu3UfuYOOIzxhPa7AsmDx0gNsXXUrQw1tnwdgwxS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 5, 860, DateTimeKind.Local).AddTicks(1068), "$2b$10$1iA/5yUVbixNrqaC6R4etOLDeFpirWfabt6tE3HfndM8zUpudxeVW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 10, 2, 57, 4, 666, DateTimeKind.Local).AddTicks(173), "$2b$10$mtZzu7k9FiFPJ1UC.WoIqOec0MnbsOewrp9l5kecp834ZVyZo2DBu" });
        }
    }
}
