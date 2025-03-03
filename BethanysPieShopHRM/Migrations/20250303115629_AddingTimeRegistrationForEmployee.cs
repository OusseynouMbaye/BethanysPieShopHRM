using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BethanysPieShopHRM.Migrations
{
    /// <inheritdoc />
    public partial class AddingTimeRegistrationForEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeRegistrations",
                columns: table => new
                {
                    TimeRegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerformedTaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeRegistrations", x => x.TimeRegistrationId);
                    table.ForeignKey(
                        name: "FK_TimeRegistrations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TimeRegistrations",
                columns: new[] { "TimeRegistrationId", "EmployeeId", "EndTime", "PerformedTaskDescription", "StartTime" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2024, 1, 24, 22, 16, 53, 0, DateTimeKind.Unspecified), "Task 2", new DateTime(2024, 3, 27, 6, 44, 47, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2024, 6, 3, 14, 12, 59, 0, DateTimeKind.Unspecified), "Task 3", new DateTime(2024, 2, 1, 7, 42, 49, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2024, 4, 4, 3, 39, 1, 0, DateTimeKind.Unspecified), "Task 4", new DateTime(2024, 7, 14, 14, 54, 13, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2024, 11, 24, 23, 1, 26, 0, DateTimeKind.Unspecified), "Task 5", new DateTime(2024, 9, 2, 8, 26, 48, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2024, 5, 16, 8, 1, 3, 0, DateTimeKind.Unspecified), "Task 6", new DateTime(2024, 3, 11, 2, 40, 23, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2024, 6, 5, 22, 10, 40, 0, DateTimeKind.Unspecified), "Task 7", new DateTime(2024, 7, 14, 0, 1, 13, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2024, 9, 20, 10, 28, 36, 0, DateTimeKind.Unspecified), "Task 8", new DateTime(2024, 3, 18, 6, 5, 7, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2024, 11, 25, 20, 36, 8, 0, DateTimeKind.Unspecified), "Task 9", new DateTime(2024, 7, 21, 10, 12, 19, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2024, 8, 2, 17, 32, 8, 0, DateTimeKind.Unspecified), "Task 10", new DateTime(2024, 3, 18, 10, 51, 44, 0, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2024, 5, 1, 6, 37, 48, 0, DateTimeKind.Unspecified), "Task 11", new DateTime(2024, 10, 10, 22, 6, 7, 0, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2024, 6, 9, 3, 0, 45, 0, DateTimeKind.Unspecified), "Task 12", new DateTime(2024, 9, 24, 8, 39, 46, 0, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2024, 9, 10, 23, 58, 2, 0, DateTimeKind.Unspecified), "Task 13", new DateTime(2024, 9, 30, 1, 4, 5, 0, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2024, 1, 25, 9, 8, 31, 0, DateTimeKind.Unspecified), "Task 14", new DateTime(2024, 12, 2, 22, 34, 48, 0, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2024, 5, 12, 16, 19, 12, 0, DateTimeKind.Unspecified), "Task 15", new DateTime(2024, 1, 23, 10, 36, 26, 0, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2024, 12, 10, 1, 4, 9, 0, DateTimeKind.Unspecified), "Task 16", new DateTime(2024, 10, 28, 16, 55, 37, 0, DateTimeKind.Unspecified) },
                    { 17, 1, new DateTime(2024, 10, 24, 15, 33, 15, 0, DateTimeKind.Unspecified), "Task 17", new DateTime(2024, 10, 8, 20, 24, 56, 0, DateTimeKind.Unspecified) },
                    { 18, 1, new DateTime(2024, 1, 21, 10, 17, 32, 0, DateTimeKind.Unspecified), "Task 18", new DateTime(2024, 11, 2, 2, 39, 29, 0, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2024, 2, 25, 18, 7, 49, 0, DateTimeKind.Unspecified), "Task 19", new DateTime(2024, 9, 10, 21, 22, 50, 0, DateTimeKind.Unspecified) },
                    { 20, 1, new DateTime(2024, 8, 9, 9, 3, 36, 0, DateTimeKind.Unspecified), "Task 20", new DateTime(2024, 6, 11, 7, 12, 31, 0, DateTimeKind.Unspecified) },
                    { 21, 1, new DateTime(2024, 8, 13, 2, 41, 57, 0, DateTimeKind.Unspecified), "Task 21", new DateTime(2024, 11, 21, 14, 58, 21, 0, DateTimeKind.Unspecified) },
                    { 22, 1, new DateTime(2024, 10, 20, 0, 35, 48, 0, DateTimeKind.Unspecified), "Task 22", new DateTime(2024, 1, 31, 14, 20, 52, 0, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2024, 11, 20, 20, 45, 41, 0, DateTimeKind.Unspecified), "Task 23", new DateTime(2024, 12, 27, 5, 20, 24, 0, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2024, 10, 8, 13, 9, 58, 0, DateTimeKind.Unspecified), "Task 24", new DateTime(2024, 8, 1, 15, 23, 42, 0, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2024, 6, 9, 6, 29, 47, 0, DateTimeKind.Unspecified), "Task 25", new DateTime(2024, 5, 9, 15, 50, 49, 0, DateTimeKind.Unspecified) },
                    { 26, 1, new DateTime(2024, 4, 2, 5, 42, 46, 0, DateTimeKind.Unspecified), "Task 26", new DateTime(2024, 2, 24, 21, 41, 37, 0, DateTimeKind.Unspecified) },
                    { 27, 1, new DateTime(2024, 10, 3, 4, 6, 48, 0, DateTimeKind.Unspecified), "Task 27", new DateTime(2024, 8, 4, 20, 47, 39, 0, DateTimeKind.Unspecified) },
                    { 28, 1, new DateTime(2024, 8, 20, 0, 45, 36, 0, DateTimeKind.Unspecified), "Task 28", new DateTime(2024, 1, 10, 0, 39, 8, 0, DateTimeKind.Unspecified) },
                    { 29, 1, new DateTime(2024, 3, 29, 4, 20, 9, 0, DateTimeKind.Unspecified), "Task 29", new DateTime(2024, 10, 29, 10, 18, 20, 0, DateTimeKind.Unspecified) },
                    { 30, 1, new DateTime(2024, 6, 20, 7, 23, 55, 0, DateTimeKind.Unspecified), "Task 30", new DateTime(2024, 10, 28, 19, 55, 13, 0, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2024, 9, 26, 14, 16, 14, 0, DateTimeKind.Unspecified), "Task 31", new DateTime(2024, 5, 13, 8, 17, 53, 0, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2024, 7, 8, 20, 5, 11, 0, DateTimeKind.Unspecified), "Task 32", new DateTime(2024, 5, 11, 16, 20, 19, 0, DateTimeKind.Unspecified) },
                    { 33, 1, new DateTime(2024, 5, 5, 2, 56, 59, 0, DateTimeKind.Unspecified), "Task 33", new DateTime(2024, 11, 21, 13, 19, 5, 0, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2024, 11, 6, 14, 23, 13, 0, DateTimeKind.Unspecified), "Task 34", new DateTime(2024, 2, 21, 8, 54, 9, 0, DateTimeKind.Unspecified) },
                    { 35, 1, new DateTime(2024, 7, 23, 9, 13, 11, 0, DateTimeKind.Unspecified), "Task 35", new DateTime(2024, 2, 26, 5, 31, 43, 0, DateTimeKind.Unspecified) },
                    { 36, 1, new DateTime(2024, 6, 8, 10, 47, 6, 0, DateTimeKind.Unspecified), "Task 36", new DateTime(2024, 9, 10, 9, 55, 22, 0, DateTimeKind.Unspecified) },
                    { 37, 1, new DateTime(2024, 3, 30, 14, 28, 14, 0, DateTimeKind.Unspecified), "Task 37", new DateTime(2024, 3, 11, 1, 31, 34, 0, DateTimeKind.Unspecified) },
                    { 38, 1, new DateTime(2024, 7, 7, 12, 32, 0, 0, DateTimeKind.Unspecified), "Task 38", new DateTime(2024, 11, 30, 14, 5, 44, 0, DateTimeKind.Unspecified) },
                    { 39, 1, new DateTime(2024, 6, 28, 4, 50, 45, 0, DateTimeKind.Unspecified), "Task 39", new DateTime(2024, 3, 24, 8, 39, 45, 0, DateTimeKind.Unspecified) },
                    { 40, 1, new DateTime(2024, 12, 16, 15, 33, 14, 0, DateTimeKind.Unspecified), "Task 40", new DateTime(2024, 3, 26, 13, 43, 49, 0, DateTimeKind.Unspecified) },
                    { 41, 1, new DateTime(2024, 8, 30, 17, 39, 46, 0, DateTimeKind.Unspecified), "Task 41", new DateTime(2024, 9, 18, 17, 52, 51, 0, DateTimeKind.Unspecified) },
                    { 42, 1, new DateTime(2024, 10, 30, 7, 48, 59, 0, DateTimeKind.Unspecified), "Task 42", new DateTime(2024, 12, 29, 3, 53, 5, 0, DateTimeKind.Unspecified) },
                    { 43, 1, new DateTime(2024, 11, 22, 7, 21, 2, 0, DateTimeKind.Unspecified), "Task 43", new DateTime(2024, 4, 9, 12, 35, 7, 0, DateTimeKind.Unspecified) },
                    { 44, 1, new DateTime(2024, 1, 28, 16, 58, 43, 0, DateTimeKind.Unspecified), "Task 44", new DateTime(2024, 5, 21, 7, 1, 33, 0, DateTimeKind.Unspecified) },
                    { 45, 1, new DateTime(2024, 1, 26, 19, 32, 1, 0, DateTimeKind.Unspecified), "Task 45", new DateTime(2024, 8, 30, 17, 22, 6, 0, DateTimeKind.Unspecified) },
                    { 46, 1, new DateTime(2024, 5, 19, 16, 41, 21, 0, DateTimeKind.Unspecified), "Task 46", new DateTime(2024, 10, 18, 16, 56, 50, 0, DateTimeKind.Unspecified) },
                    { 47, 1, new DateTime(2024, 7, 5, 2, 44, 10, 0, DateTimeKind.Unspecified), "Task 47", new DateTime(2024, 3, 13, 23, 22, 38, 0, DateTimeKind.Unspecified) },
                    { 48, 1, new DateTime(2024, 4, 4, 19, 58, 12, 0, DateTimeKind.Unspecified), "Task 48", new DateTime(2024, 4, 22, 5, 31, 7, 0, DateTimeKind.Unspecified) },
                    { 49, 1, new DateTime(2024, 3, 8, 16, 3, 40, 0, DateTimeKind.Unspecified), "Task 49", new DateTime(2024, 1, 16, 11, 8, 25, 0, DateTimeKind.Unspecified) },
                    { 50, 1, new DateTime(2024, 7, 19, 21, 57, 39, 0, DateTimeKind.Unspecified), "Task 50", new DateTime(2024, 10, 3, 2, 4, 6, 0, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2024, 11, 7, 2, 51, 22, 0, DateTimeKind.Unspecified), "Task 51", new DateTime(2024, 4, 7, 5, 52, 31, 0, DateTimeKind.Unspecified) },
                    { 52, 1, new DateTime(2024, 2, 8, 0, 58, 54, 0, DateTimeKind.Unspecified), "Task 52", new DateTime(2024, 9, 16, 6, 3, 28, 0, DateTimeKind.Unspecified) },
                    { 53, 1, new DateTime(2024, 1, 16, 22, 16, 46, 0, DateTimeKind.Unspecified), "Task 53", new DateTime(2024, 8, 7, 21, 28, 49, 0, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2024, 10, 9, 9, 10, 16, 0, DateTimeKind.Unspecified), "Task 54", new DateTime(2024, 9, 29, 19, 39, 33, 0, DateTimeKind.Unspecified) },
                    { 55, 1, new DateTime(2024, 6, 18, 22, 26, 29, 0, DateTimeKind.Unspecified), "Task 55", new DateTime(2024, 12, 12, 7, 12, 22, 0, DateTimeKind.Unspecified) },
                    { 56, 1, new DateTime(2024, 8, 24, 10, 26, 38, 0, DateTimeKind.Unspecified), "Task 56", new DateTime(2024, 11, 8, 13, 3, 11, 0, DateTimeKind.Unspecified) },
                    { 57, 1, new DateTime(2024, 1, 23, 8, 24, 36, 0, DateTimeKind.Unspecified), "Task 57", new DateTime(2024, 2, 15, 13, 24, 13, 0, DateTimeKind.Unspecified) },
                    { 58, 1, new DateTime(2024, 3, 24, 22, 34, 21, 0, DateTimeKind.Unspecified), "Task 58", new DateTime(2024, 12, 9, 16, 41, 3, 0, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2024, 2, 14, 22, 25, 19, 0, DateTimeKind.Unspecified), "Task 59", new DateTime(2024, 9, 21, 7, 7, 29, 0, DateTimeKind.Unspecified) },
                    { 60, 1, new DateTime(2024, 4, 15, 23, 13, 23, 0, DateTimeKind.Unspecified), "Task 60", new DateTime(2024, 10, 27, 13, 40, 21, 0, DateTimeKind.Unspecified) },
                    { 61, 1, new DateTime(2024, 9, 13, 10, 25, 49, 0, DateTimeKind.Unspecified), "Task 61", new DateTime(2024, 11, 4, 15, 51, 57, 0, DateTimeKind.Unspecified) },
                    { 62, 1, new DateTime(2024, 4, 10, 0, 7, 47, 0, DateTimeKind.Unspecified), "Task 62", new DateTime(2024, 10, 8, 6, 42, 40, 0, DateTimeKind.Unspecified) },
                    { 63, 1, new DateTime(2024, 1, 28, 10, 2, 24, 0, DateTimeKind.Unspecified), "Task 63", new DateTime(2024, 12, 24, 13, 10, 52, 0, DateTimeKind.Unspecified) },
                    { 64, 1, new DateTime(2024, 8, 12, 0, 58, 0, 0, DateTimeKind.Unspecified), "Task 64", new DateTime(2024, 10, 5, 7, 30, 29, 0, DateTimeKind.Unspecified) },
                    { 65, 1, new DateTime(2024, 12, 24, 17, 29, 26, 0, DateTimeKind.Unspecified), "Task 65", new DateTime(2024, 4, 2, 4, 52, 56, 0, DateTimeKind.Unspecified) },
                    { 66, 1, new DateTime(2024, 10, 9, 13, 7, 49, 0, DateTimeKind.Unspecified), "Task 66", new DateTime(2024, 1, 22, 4, 47, 37, 0, DateTimeKind.Unspecified) },
                    { 67, 1, new DateTime(2024, 1, 1, 8, 42, 27, 0, DateTimeKind.Unspecified), "Task 67", new DateTime(2024, 10, 23, 20, 12, 3, 0, DateTimeKind.Unspecified) },
                    { 68, 1, new DateTime(2024, 6, 27, 20, 42, 34, 0, DateTimeKind.Unspecified), "Task 68", new DateTime(2024, 11, 18, 23, 8, 41, 0, DateTimeKind.Unspecified) },
                    { 69, 1, new DateTime(2024, 6, 24, 11, 14, 34, 0, DateTimeKind.Unspecified), "Task 69", new DateTime(2024, 10, 6, 0, 6, 30, 0, DateTimeKind.Unspecified) },
                    { 70, 1, new DateTime(2024, 11, 25, 8, 33, 55, 0, DateTimeKind.Unspecified), "Task 70", new DateTime(2024, 5, 5, 6, 18, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, new DateTime(2024, 10, 12, 4, 43, 19, 0, DateTimeKind.Unspecified), "Task 71", new DateTime(2024, 7, 23, 22, 45, 3, 0, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2024, 5, 1, 6, 54, 43, 0, DateTimeKind.Unspecified), "Task 72", new DateTime(2024, 4, 21, 5, 8, 14, 0, DateTimeKind.Unspecified) },
                    { 73, 1, new DateTime(2024, 4, 24, 2, 55, 22, 0, DateTimeKind.Unspecified), "Task 73", new DateTime(2024, 3, 29, 2, 1, 55, 0, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2024, 3, 20, 12, 27, 42, 0, DateTimeKind.Unspecified), "Task 74", new DateTime(2024, 1, 26, 0, 45, 41, 0, DateTimeKind.Unspecified) },
                    { 75, 1, new DateTime(2024, 4, 19, 14, 33, 54, 0, DateTimeKind.Unspecified), "Task 75", new DateTime(2024, 11, 3, 4, 39, 18, 0, DateTimeKind.Unspecified) },
                    { 76, 1, new DateTime(2024, 4, 5, 18, 47, 19, 0, DateTimeKind.Unspecified), "Task 76", new DateTime(2024, 10, 17, 17, 7, 1, 0, DateTimeKind.Unspecified) },
                    { 77, 1, new DateTime(2024, 7, 28, 9, 51, 49, 0, DateTimeKind.Unspecified), "Task 77", new DateTime(2024, 3, 30, 7, 18, 1, 0, DateTimeKind.Unspecified) },
                    { 78, 1, new DateTime(2024, 8, 21, 0, 55, 50, 0, DateTimeKind.Unspecified), "Task 78", new DateTime(2024, 4, 11, 3, 23, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 1, new DateTime(2024, 10, 22, 13, 11, 54, 0, DateTimeKind.Unspecified), "Task 79", new DateTime(2024, 1, 3, 15, 30, 21, 0, DateTimeKind.Unspecified) },
                    { 80, 1, new DateTime(2024, 3, 25, 18, 46, 55, 0, DateTimeKind.Unspecified), "Task 80", new DateTime(2024, 6, 18, 10, 28, 21, 0, DateTimeKind.Unspecified) },
                    { 81, 1, new DateTime(2024, 8, 8, 2, 37, 13, 0, DateTimeKind.Unspecified), "Task 81", new DateTime(2024, 12, 29, 0, 11, 25, 0, DateTimeKind.Unspecified) },
                    { 82, 1, new DateTime(2024, 3, 7, 19, 17, 13, 0, DateTimeKind.Unspecified), "Task 82", new DateTime(2024, 7, 2, 12, 18, 30, 0, DateTimeKind.Unspecified) },
                    { 83, 1, new DateTime(2024, 5, 25, 10, 24, 14, 0, DateTimeKind.Unspecified), "Task 83", new DateTime(2024, 10, 17, 5, 5, 33, 0, DateTimeKind.Unspecified) },
                    { 84, 1, new DateTime(2024, 7, 7, 15, 23, 27, 0, DateTimeKind.Unspecified), "Task 84", new DateTime(2024, 3, 26, 6, 27, 27, 0, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2024, 4, 3, 5, 20, 47, 0, DateTimeKind.Unspecified), "Task 85", new DateTime(2024, 9, 26, 20, 59, 40, 0, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2024, 6, 23, 22, 42, 52, 0, DateTimeKind.Unspecified), "Task 86", new DateTime(2024, 3, 1, 19, 43, 53, 0, DateTimeKind.Unspecified) },
                    { 87, 1, new DateTime(2024, 7, 21, 22, 51, 59, 0, DateTimeKind.Unspecified), "Task 87", new DateTime(2024, 2, 21, 0, 36, 27, 0, DateTimeKind.Unspecified) },
                    { 88, 1, new DateTime(2024, 11, 24, 12, 27, 3, 0, DateTimeKind.Unspecified), "Task 88", new DateTime(2024, 11, 2, 5, 52, 38, 0, DateTimeKind.Unspecified) },
                    { 89, 1, new DateTime(2024, 4, 28, 2, 34, 25, 0, DateTimeKind.Unspecified), "Task 89", new DateTime(2024, 8, 30, 7, 6, 34, 0, DateTimeKind.Unspecified) },
                    { 90, 1, new DateTime(2024, 6, 5, 15, 10, 58, 0, DateTimeKind.Unspecified), "Task 90", new DateTime(2024, 6, 16, 7, 39, 28, 0, DateTimeKind.Unspecified) },
                    { 91, 1, new DateTime(2024, 10, 8, 10, 58, 31, 0, DateTimeKind.Unspecified), "Task 91", new DateTime(2024, 12, 15, 7, 1, 23, 0, DateTimeKind.Unspecified) },
                    { 92, 1, new DateTime(2024, 10, 19, 19, 29, 42, 0, DateTimeKind.Unspecified), "Task 92", new DateTime(2024, 9, 6, 4, 0, 17, 0, DateTimeKind.Unspecified) },
                    { 93, 1, new DateTime(2024, 4, 14, 10, 53, 31, 0, DateTimeKind.Unspecified), "Task 93", new DateTime(2024, 2, 22, 18, 54, 46, 0, DateTimeKind.Unspecified) },
                    { 94, 1, new DateTime(2024, 6, 23, 23, 33, 13, 0, DateTimeKind.Unspecified), "Task 94", new DateTime(2024, 1, 13, 15, 26, 26, 0, DateTimeKind.Unspecified) },
                    { 95, 1, new DateTime(2024, 8, 22, 22, 23, 29, 0, DateTimeKind.Unspecified), "Task 95", new DateTime(2024, 2, 25, 20, 23, 22, 0, DateTimeKind.Unspecified) },
                    { 96, 1, new DateTime(2024, 11, 8, 20, 4, 26, 0, DateTimeKind.Unspecified), "Task 96", new DateTime(2024, 10, 10, 3, 37, 17, 0, DateTimeKind.Unspecified) },
                    { 97, 1, new DateTime(2024, 6, 30, 8, 0, 1, 0, DateTimeKind.Unspecified), "Task 97", new DateTime(2024, 4, 27, 16, 20, 35, 0, DateTimeKind.Unspecified) },
                    { 98, 1, new DateTime(2024, 8, 5, 14, 35, 19, 0, DateTimeKind.Unspecified), "Task 98", new DateTime(2024, 6, 1, 6, 31, 28, 0, DateTimeKind.Unspecified) },
                    { 99, 1, new DateTime(2024, 12, 29, 23, 7, 48, 0, DateTimeKind.Unspecified), "Task 99", new DateTime(2024, 1, 30, 13, 2, 25, 0, DateTimeKind.Unspecified) },
                    { 100, 1, new DateTime(2024, 3, 13, 0, 14, 47, 0, DateTimeKind.Unspecified), "Task 100", new DateTime(2024, 4, 27, 15, 54, 48, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeRegistrations_EmployeeId",
                table: "TimeRegistrations",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeRegistrations");
        }
    }
}
