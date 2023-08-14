using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnviroBank.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    AccountHolder = table.Column<long>(type: "bigint", nullable: false),
                    AccountType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvailableBalance = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Holders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DOB = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResidentialAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MobileNumber = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountHolder", "AccountName", "AccountNumber", "AccountStatus", "AccountType", "AvailableBalance" },
                values: new object[,]
                {
                    { 1, 1L, "Personal Savings", 1234567895L, "Active", "Savings", 1000.00m },
                    { 2, 2L, "Checking Account", 9876543214L, "Active", "Cheque", 1500.00m },
                    { 3, 3L, "Emergency Savings", 5678901237L, "Active", "Savings", 5000.00m },
                    { 4, 4L, "Investment Portfolio", 2345678904L, "Active", "Fixed", 20000.00m },
                    { 5, 5L, "Vacation Fund", 8901234566L, "Active", "Savings", 3000.00m },
                    { 6, 6L, "Business Checking", 4567890122L, "Active", "Cheque", 2500.00m },
                    { 7, 7L, "Retirement Savings", 123456786L, "Active", "Savings", 10000.00m },
                    { 8, 8L, "Stock Portfolio", 7890123458L, "Active", "Fixed", 50000.00m },
                    { 9, 9L, "Education Fund", 3456789015L, "Active", "Savings", 0.00m },
                    { 10, 10L, "Secondary Checking", 9012345672L, "Inactive", "Cheque", 1800.00m },
                    { 11, 1L, "Main Checking", 4567890128L, "Active", "Cheque", 3500.00m },
                    { 12, 2L, "Savings for Goals", 7890123459L, "Active", "Savings", 8000.00m },
                    { 13, 3L, "Diversified Portfolio", 1234567898L, "Active", "Fixed", 25000.00m },
                    { 14, 4L, "Personal Checking", 5678901237L, "Active", "Cheque", 1200.00m },
                    { 15, 5L, "Dream Vacation Fund", 2345678903L, "Active", "Savings", 6000.00m },
                    { 16, 6L, "Long-Term Investments", 8901234565L, "Active", "Fixed", 40000.00m },
                    { 17, 7L, "Emergency Fund", 123456786L, "Active", "Savings", 3000.00m },
                    { 18, 8L, "Business Operating", 7890123458L, "Active", "Cheque", 0.00m },
                    { 19, 9L, "Future Planning", 3456789011L, "Active", "Savings", 12000.00m },
                    { 20, 10L, "Investment Portfolio", 9012345677L, "Inactive", "Fixed", 70000.00m }
                });

            migrationBuilder.InsertData(
                table: "Holders",
                columns: new[] { "Id", "DOB", "EmailAddress", "FirstName", "IdNumber", "LastName", "MobileNumber", "Password", "ResidentialAddress" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@gmail.com", "John", "971234567890", "Doe", 791234569, "password1", "123 Main Street" },
                    { 2, new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane@gmail.com", "Jane", "979876543210", "Smith", 791234569, "password2", "456 Elm Street" },
                    { 3, new DateTime(1978, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael@gmail.com", "Michael", "974567890123", "Johnson", 791234569, "password3", "789 Oak Street" },
                    { 4, new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah@gmail.com", "Sarah", "975678901234", "Williams", 791234569, "password4", "567 Pine Street" },
                    { 5, new DateTime(1983, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "david@gmail.com", "David", "972345678901", "Miller", 791234569, "password5", "890 Birch Street" },
                    { 6, new DateTime(1995, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer@gmail.com", "Jennifer", "976789012345", "Brown", 791234569, "password6", "789 Cedar Street" },
                    { 7, new DateTime(1987, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "chris@gmail.com", "Christopher", "973456789012", "Lee", 791234569, "password7", "123 Maple Road" },
                    { 8, new DateTime(1974, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "linda@gmail.com", "Linda", "978901234567", "Clark", 791234569, "password8", "456 Oak Road" },
                    { 9, new DateTime(1998, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel@gmail.com", "Daniel", "974567890123", "Hall", 791234569, "password9", "789 Elm Road" },
                    { 10, new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily@gmail.com", "Emily", "977890123456", "Brown", 791234569, "password10", "567 Maple Street" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Holders");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
