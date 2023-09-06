using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class replyadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReplyMessages",
                columns: table => new
                {
                    ReplyId = table.Column<int>(type: "INTEGER", nullable: false),
                    MessageId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 16, 44, 45, 760, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastOnline",
                value: new DateTime(2023, 4, 7, 19, 44, 45, 760, DateTimeKind.Local).AddTicks(6901));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReplyMessages");

            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 7, 15, 44, 5, 187, DateTimeKind.Utc).AddTicks(1142));

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
    }
}
