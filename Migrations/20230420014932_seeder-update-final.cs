using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class seederupdatefinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 20, 1, 49, 32, 114, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(2023, 4, 5, 0, 39, 23, 74, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortMessage",
                value: "empty...");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublishTime", "ShortMessage" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 39, 23, 74, DateTimeKind.Local).AddTicks(1875), "liokSinner:This is start of this channel, welcome everyone!" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2017, 10, 5, 0, 34, 23, 75, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishTime",
                value: new DateTime(2017, 10, 5, 0, 32, 10, 104, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishTime",
                value: new DateTime(2023, 4, 7, 0, 44, 23, 74, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishTime",
                value: new DateTime(2023, 4, 9, 23, 44, 22, 64, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishTime",
                value: new DateTime(2023, 3, 31, 21, 22, 22, 64, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishTime",
                value: new DateTime(2023, 4, 14, 16, 20, 22, 64, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishTime",
                value: new DateTime(2023, 4, 5, 2, 45, 22, 64, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishTime",
                value: new DateTime(2023, 4, 17, 0, 48, 22, 64, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 31,
                column: "PublishTime",
                value: new DateTime(2023, 4, 4, 17, 17, 22, 64, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 32,
                column: "PublishTime",
                value: new DateTime(2023, 4, 15, 22, 22, 22, 64, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 33,
                column: "PublishTime",
                value: new DateTime(2023, 4, 10, 19, 30, 22, 64, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 34,
                column: "PublishTime",
                value: new DateTime(2023, 4, 17, 17, 35, 22, 64, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 35,
                column: "PublishTime",
                value: new DateTime(2023, 4, 13, 21, 38, 22, 64, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 36,
                column: "PublishTime",
                value: new DateTime(2023, 4, 2, 0, 38, 22, 64, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 37,
                column: "PublishTime",
                value: new DateTime(2023, 4, 9, 21, 24, 22, 64, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 38,
                column: "PublishTime",
                value: new DateTime(2023, 4, 15, 13, 28, 22, 64, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 39,
                column: "PublishTime",
                value: new DateTime(2023, 4, 6, 2, 35, 22, 64, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 40,
                column: "PublishTime",
                value: new DateTime(2023, 4, 5, 23, 28, 22, 64, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 41,
                column: "PublishTime",
                value: new DateTime(2023, 3, 29, 23, 51, 22, 64, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 42,
                column: "PublishTime",
                value: new DateTime(2023, 4, 8, 22, 47, 22, 64, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 43,
                column: "PublishTime",
                value: new DateTime(2023, 4, 14, 17, 38, 22, 64, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 44,
                column: "PublishTime",
                value: new DateTime(2023, 4, 17, 17, 28, 22, 64, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 45,
                column: "PublishTime",
                value: new DateTime(2023, 3, 28, 3, 7, 22, 64, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 46,
                column: "PublishTime",
                value: new DateTime(2023, 4, 5, 21, 48, 22, 64, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 47,
                column: "PublishTime",
                value: new DateTime(2023, 4, 11, 13, 38, 22, 64, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 48,
                column: "PublishTime",
                value: new DateTime(2023, 4, 5, 23, 38, 22, 64, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 49,
                column: "PublishTime",
                value: new DateTime(2023, 4, 11, 15, 38, 22, 64, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 50,
                column: "PublishTime",
                value: new DateTime(2023, 4, 17, 13, 30, 22, 64, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 51,
                column: "PublishTime",
                value: new DateTime(2023, 4, 3, 21, 44, 22, 64, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 52,
                column: "PublishTime",
                value: new DateTime(2023, 4, 7, 17, 54, 22, 64, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 53,
                column: "PublishTime",
                value: new DateTime(2023, 4, 4, 2, 10, 22, 64, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 54,
                column: "PublishTime",
                value: new DateTime(2023, 4, 8, 19, 36, 22, 64, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 55,
                column: "PublishTime",
                value: new DateTime(2023, 4, 3, 2, 37, 22, 64, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2023, 3, 27, 0, 34, 23, 74, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2023, 3, 27, 0, 35, 23, 75, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 0, 32, 17, 112, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 0, 36, 10, 104, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SendTime",
                value: new DateTime(2023, 4, 10, 0, 39, 23, 74, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 0, 39, 23, 74, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 0, 39, 23, 74, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 0, 44, 23, 74, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 0, 38, 22, 64, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 0, 38, 22, 64, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SendTime",
                value: new DateTime(2023, 3, 31, 22, 34, 22, 64, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 21, 24, 22, 64, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 36, 22, 64, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SendTime",
                value: new DateTime(2023, 4, 15, 13, 28, 22, 64, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 20, 38, 22, 64, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SendTime",
                value: new DateTime(2023, 4, 6, 2, 35, 22, 64, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 17, 46, 22, 64, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 23, 28, 22, 64, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 34, 22, 64, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 37, 22, 64, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 38, 22, 64, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 23, 44, 22, 64, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 17, 46, 22, 64, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 17, 48, 22, 64, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 17, 54, 22, 64, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 17, 55, 22, 64, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 18, 6, 22, 64, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 18, 12, 22, 64, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SendTime",
                value: new DateTime(2023, 3, 25, 18, 23, 22, 64, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SendTime",
                value: new DateTime(2023, 3, 31, 21, 14, 22, 64, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SendTime",
                value: new DateTime(2023, 3, 31, 21, 19, 22, 64, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SendTime",
                value: new DateTime(2023, 3, 31, 21, 22, 22, 64, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 11, 22, 64, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 22, 22, 64, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 24, 22, 64, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 26, 22, 64, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 34, 22, 64, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 16, 5, 22, 64, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 16, 11, 22, 64, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 16, 20, 22, 64, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 21, 38, 22, 64, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 21, 39, 22, 64, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 21, 42, 22, 64, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 21, 48, 22, 64, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 2, 24, 22, 64, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 2, 26, 22, 64, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 2, 30, 22, 64, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 2, 45, 22, 64, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SendTime",
                value: new DateTime(2023, 4, 16, 17, 45, 22, 64, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SendTime",
                value: new DateTime(2023, 4, 16, 17, 47, 22, 64, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SendTime",
                value: new DateTime(2023, 4, 16, 17, 52, 22, 64, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SendTime",
                value: new DateTime(2023, 4, 16, 17, 58, 22, 64, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 0, 35, 22, 64, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 0, 38, 22, 64, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 0, 42, 22, 64, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 0, 46, 22, 64, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 0, 48, 22, 64, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 19, 20, 22, 64, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 19, 35, 22, 64, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 19, 38, 22, 64, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 19, 44, 22, 64, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 17, 12, 22, 64, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 17, 15, 22, 64, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 17, 17, 22, 64, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 1, 7, 22, 64, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 1, 14, 22, 64, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 1, 18, 22, 64, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SendTime",
                value: new DateTime(2023, 4, 9, 1, 22, 22, 64, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SendTime",
                value: new DateTime(2023, 4, 15, 22, 22, 22, 64, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SendTime",
                value: new DateTime(2023, 4, 15, 22, 22, 22, 64, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SendTime",
                value: new DateTime(2023, 4, 15, 22, 22, 22, 64, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SendTime",
                value: new DateTime(2023, 4, 15, 22, 22, 22, 64, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 0, 17, 22, 64, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 0, 25, 22, 64, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 0, 38, 22, 64, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 2, 17, 22, 64, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SendTime",
                value: new DateTime(2023, 4, 10, 18, 52, 22, 64, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SendTime",
                value: new DateTime(2023, 4, 10, 18, 58, 22, 64, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SendTime",
                value: new DateTime(2023, 4, 10, 19, 25, 22, 64, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SendTime",
                value: new DateTime(2023, 4, 10, 19, 30, 22, 64, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 0, 42, 22, 64, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 0, 46, 22, 64, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 0, 46, 47, 64, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SendTime",
                value: new DateTime(2023, 4, 2, 0, 47, 22, 64, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 17, 30, 22, 64, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 17, 34, 22, 64, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 17, 35, 22, 64, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SendTime",
                value: new DateTime(2023, 4, 13, 21, 14, 22, 64, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SendTime",
                value: new DateTime(2023, 4, 13, 21, 18, 22, 64, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SendTime",
                value: new DateTime(2023, 4, 13, 21, 27, 22, 64, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SendTime",
                value: new DateTime(2023, 4, 13, 21, 38, 22, 64, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 23, 38, 22, 64, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 23, 39, 22, 64, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 23, 43, 22, 64, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 23, 44, 22, 64, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 23, 8, 22, 64, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 23, 47, 22, 64, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SendTime",
                value: new DateTime(2023, 3, 29, 23, 51, 22, 64, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 28, 22, 64, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 34, 22, 64, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 34, 49, 64, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 35, 28, 64, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 38, 22, 64, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 41, 22, 64, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 44, 22, 64, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 22, 47, 22, 64, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 22, 22, 64, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 25, 22, 64, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 27, 22, 64, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 28, 22, 64, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 34, 22, 64, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 38, 22, 64, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 44, 22, 64, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 46, 22, 64, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 21, 22, 64, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 24, 22, 64, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 26, 22, 64, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 28, 22, 64, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 29, 22, 64, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 34, 22, 64, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 36, 22, 64, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 37, 22, 64, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 14, 44, 22, 64, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 1, 28, 22, 64, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 34, 22, 64, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 38, 22, 64, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 39, 22, 64, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 44, 22, 64, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 45, 22, 64, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 51, 22, 64, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 54, 22, 64, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 2, 57, 22, 64, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 3, 2, 22, 64, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SendTime",
                value: new DateTime(2023, 3, 28, 3, 7, 22, 64, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 21, 22, 64, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 28, 22, 64, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 30, 22, 64, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 34, 22, 64, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 38, 22, 64, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 41, 22, 64, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 42, 22, 64, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 43, 22, 64, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 44, 22, 64, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 46, 22, 64, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 21, 48, 22, 64, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 12, 56, 22, 64, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 4, 22, 64, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 6, 22, 64, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 7, 22, 64, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 12, 22, 64, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 21, 22, 64, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 24, 22, 64, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 27, 22, 64, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 13, 38, 22, 64, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 17, 14, 22, 64, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 17, 16, 22, 64, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 17, 18, 22, 64, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 17, 21, 22, 64, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SendTime",
                value: new DateTime(2023, 4, 14, 17, 38, 22, 64, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 23, 24, 22, 64, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 23, 25, 22, 64, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 23, 28, 22, 64, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SendTime",
                value: new DateTime(2023, 4, 5, 23, 38, 22, 64, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 15, 25, 22, 64, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 15, 28, 22, 64, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 15, 34, 22, 64, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SendTime",
                value: new DateTime(2023, 4, 11, 15, 38, 22, 64, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 13, 22, 22, 64, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 13, 25, 22, 64, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 13, 27, 22, 64, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 13, 30, 22, 64, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 17, 17, 22, 64, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 17, 21, 22, 64, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 17, 25, 22, 64, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SendTime",
                value: new DateTime(2023, 4, 17, 17, 28, 22, 64, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 21, 34, 22, 64, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 21, 36, 22, 64, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 21, 38, 22, 64, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 21, 40, 22, 64, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 21, 44, 22, 64, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 17, 40, 22, 64, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 17, 44, 22, 64, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 17, 47, 22, 64, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 17, 51, 22, 64, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SendTime",
                value: new DateTime(2023, 4, 7, 17, 54, 22, 64, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 54, 22, 64, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 1, 58, 22, 64, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 2, 2, 22, 64, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 2, 4, 22, 64, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 2, 10, 22, 64, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 19, 20, 22, 64, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 19, 25, 22, 64, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 19, 28, 22, 64, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 19, 33, 22, 64, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SendTime",
                value: new DateTime(2023, 4, 8, 19, 36, 22, 64, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 2, 25, 22, 64, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 2, 30, 22, 64, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 2, 32, 22, 64, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SendTime",
                value: new DateTime(2023, 4, 3, 2, 37, 22, 64, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 30, 985, DateTimeKind.Local).AddTicks(6669), "$2b$10$yTf3rS43H1vHJpXmkaNqveSdOlS7Fn758RJUMbLYmCbGxSpMycgYm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 46, DateTimeKind.Local).AddTicks(3886), "$2b$10$ukWR6o.z/OT5LS5rU2rePerSx0i7clxN8I9iTdMhN6q/mIAOeXpxm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 107, DateTimeKind.Local).AddTicks(99), "$2b$10$a5O55K2ZdGevrJsY1Oxo/uAE3PZfnaZoLqnLyhbpMqKn1NedavKIu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 165, DateTimeKind.Local).AddTicks(8729), "$2b$10$wNOnQoASi06m2pRpO5P01.gmBpG57s0xi9IW2iHbQpSHoXa3QFRWm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 226, DateTimeKind.Local).AddTicks(6529), "$2b$10$uRTO/Avd2wppAveuquuvXuUb9jrqeaZQNBmtE2XHX3/A4dveCS1Pa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 288, DateTimeKind.Local).AddTicks(8026), "$2b$10$ZDi1afbw7.6.BLR7XEk4W.xf0GCRe4PvehK7ne0OMDVhId97BRdrS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 351, DateTimeKind.Local).AddTicks(3253), "$2b$10$XyQFsOFcWUXyKT6gFTYPBu9KzBAl70eZ9pEY6gunnx4i.pxk4q/NC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 413, DateTimeKind.Local).AddTicks(3996), "$2b$10$vlFMFhoXeESnzh5FZYqqZO/z6Q7YzRwJkJGtfJO6CgPBrUruVwZ0e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 473, DateTimeKind.Local).AddTicks(5915), "$2b$10$lqacN1Xc.1DwWsn6AVM8x.KWYTQB4wPcn39hkYjnU2oek/Z9.lnuS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 532, DateTimeKind.Local).AddTicks(3640), "$2b$10$T1KibO2y32QFV4QdMFIvsOm86f2kdiExjdpaftndt96IQBITkOBlm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 590, DateTimeKind.Local).AddTicks(7870), "$2b$10$VpVyKwTsKntsO.Uka2lcguSqBeD18PMjYbmlyUUwKG9CHe83ITKy." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 649, DateTimeKind.Local).AddTicks(998), "$2b$10$TVDWAe0A8BN6I7e88ggW2eZwZwpvvr63/R2nrOHmjIFfoHrv/nD2C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 706, DateTimeKind.Local).AddTicks(9136), "$2b$10$hJBndyN3XyKZl1BfgO9RUe4QD9hyeniwuQSV2O5hCw4OtzKY2GZPO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 764, DateTimeKind.Local).AddTicks(9819), "$2b$10$U2cveHQ4Ts2nBLdYWqs7BeMjwQx93ECl2IshLSNmNpoDP.FItg56i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 823, DateTimeKind.Local).AddTicks(7412), "$2b$10$hwoO2XI0ukMND2II2LQoPuZlzbOcPqh/BoCqUFH54xlH25GIV1yFq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 881, DateTimeKind.Local).AddTicks(8714), "$2b$10$zyJg9Ooobby8RneG9eEkv.4g3H.AuTmBu6sqZKjBYgAO/x6gT8nVm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 939, DateTimeKind.Local).AddTicks(6199), "$2b$10$XqDquZLjiQ0pLRuto04KM.8o7FYcuk0DKLCJNpvWQJ6W/agdUB8jG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 31, 998, DateTimeKind.Local).AddTicks(493), "$2b$10$tmErFFJVrPgq7aJC5K.rvuZwYYx6mVsTfydr0K76f0pY4a1CWP7SS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 32, 56, DateTimeKind.Local).AddTicks(68), "$2b$10$MXS3cnLZVeOPdfPhgBw1fe2Q4An1ZSFJyH7VLov5FLnpMtqmO5C3q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 32, 114, DateTimeKind.Local).AddTicks(1087), "$2b$10$guoUamJ4Ro8/pNWOIS7e.OtGzMxA0urJ7C7E9DrUTHrhmRgAIb/xC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 4, 49, 30, 924, DateTimeKind.Local).AddTicks(9372), "$2b$10$wsQWSLOwrqlyALAEqfR8zuSO.NmU5Na.WtRj4JMwLQSxOJFqv7zIK" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BugReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "PublishTime", "ShortMessage" },
                values: new object[] { new DateTime(2017, 10, 4, 10, 54, 33, 510, DateTimeKind.Local).AddTicks(2829), "short message...." });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2017, 10, 4, 10, 49, 33, 511, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishTime",
                value: new DateTime(2017, 10, 4, 10, 47, 20, 540, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 31,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 32,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 33,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 34,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 35,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 36,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 37,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 38,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 39,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 40,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 41,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 42,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 43,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 44,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 45,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 46,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 47,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 48,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 49,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 50,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 51,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 52,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 53,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 54,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 55,
                column: "PublishTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2023, 3, 26, 10, 49, 33, 510, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2023, 3, 26, 10, 50, 33, 511, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2023, 3, 27, 10, 47, 27, 548, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SendTime",
                value: new DateTime(2023, 3, 27, 10, 51, 20, 540, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 54, 33, 510, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 10, 54, 33, 510, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SendTime",
                value: new DateTime(2023, 4, 4, 10, 54, 33, 510, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SendTime",
                value: new DateTime(2017, 10, 4, 10, 53, 32, 500, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SendTime",
                value: new DateTime(2023, 4, 19, 12, 4, 42, 550, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 428, DateTimeKind.Local).AddTicks(6671), "$2b$10$ES64zQEbGjZ9aiW6O1ZTEeOL4rMc9DTOJlsWCrC5HvpmKzRI6k5OC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 494, DateTimeKind.Local).AddTicks(1563), "$2b$10$OTkkc/Rdo3PXuwRHON0g3OdIK4alTfe5qNi.3roDqOoaVJsbLSyOu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 552, DateTimeKind.Local).AddTicks(6606), "$2b$10$5sVgEx5ttD4ZG/j0qkaJj.js4iiakOUDi58gQtrUA6aoJBYeHoRPq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 613, DateTimeKind.Local).AddTicks(1510), "$2b$10$EEJ/KVMl8vC0o5xDnwKsE.l8AW.XkErPk66KSPUNfO6fm8xhaQEhu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 674, DateTimeKind.Local).AddTicks(837), "$2b$10$CoXj/Zus4H9J8790.gxFb.Lpb9j9lOMjbVBdZhvdYnhP7qqGLtNV." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 734, DateTimeKind.Local).AddTicks(4369), "$2b$10$x8IJwBCkYUgCJiaeqY3nCeX5UPgQQ5cmoJ2PLELcv2c4r03yo.8bW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 793, DateTimeKind.Local).AddTicks(2481), "$2b$10$yhNFI9QxQ3ZvjobKFz4Nz.mQTNTKs6z9xOtDlsMeQIFM7pbJUr7F2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 855, DateTimeKind.Local).AddTicks(7034), "$2b$10$Y4a9upAeottei12Cb593ROx6B19rz/cS5VOQHZ6xzpA7TyHeq54SO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 915, DateTimeKind.Local).AddTicks(1192), "$2b$10$.8KTiB1L8UJ/bJvUA4d8CeHx1nAPn1EFCU.saKL7VM1HF2FsgkDMy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 973, DateTimeKind.Local).AddTicks(3933), "$2b$10$Y8dKjTvifqc1FR6QG.8WiuF1QoZMaJEhcjczwao9rBmcwKrHdRgU6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 32, DateTimeKind.Local).AddTicks(2965), "$2b$10$EWnxAsWg.swQ3D9xu84miemlj0Z5bKbdWjGLKhYZ/IB0U.K.3AHHC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 90, DateTimeKind.Local).AddTicks(5798), "$2b$10$MMKb0kPMXvscv5.nU/IBKeuapIAJYNMtu1Rxav4YeHkMoI9NbZPSy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 148, DateTimeKind.Local).AddTicks(7961), "$2b$10$ZGNEOnZ4vWRdJMIM3YTjl.QIIv2m/Ni/iO.Oo4LkLo4wWbTYO.1qm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 207, DateTimeKind.Local).AddTicks(3294), "$2b$10$/NXiqd0EVfGk8glMKeG6zOOs7.7YjkwsQCz/oV.55y.yTLrDQW9RS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 265, DateTimeKind.Local).AddTicks(853), "$2b$10$kTDf8EqizLChHsSrjiLTY.6weu9JvfASNPyN5ltERzWy.iBSaZiSy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 322, DateTimeKind.Local).AddTicks(167), "$2b$10$DBnA3hwB/7nBdNqwHgn9FulKvqzgHa1C3JaWK.8cYtFowfJYtYLsK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 379, DateTimeKind.Local).AddTicks(1732), "$2b$10$DNzp6CW7BdbQoOLl0lvZP.g82HP1CzBWXCvZ9Ymu.5CCRvbGCNGLK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 435, DateTimeKind.Local).AddTicks(9714), "$2b$10$3iGyjZ2x2lqIG1CLR5f6delTcV5OpjnNwYcT0mMjOo.HoeLPDyf8m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 492, DateTimeKind.Local).AddTicks(8301), "$2b$10$92Toz8kWZ6wkjhyGiC1BtOffvrwmjLi8PreE.Z8AFNTDgeiIfuKgu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 42, 550, DateTimeKind.Local).AddTicks(1978), "$2b$10$o30PPfcqUEYpG4SzfG3SY.sv/4MpDgHQ43/Kra/6Y4/e43knwuSAO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "LastOnline", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 15, 4, 41, 370, DateTimeKind.Local).AddTicks(2001), "$2b$10$9Agg5ywRhXGWNIRFsQEhbOaklKvhQeSBYmccF/M1ArCZg7QuHkz9y" });
        }
    }
}
