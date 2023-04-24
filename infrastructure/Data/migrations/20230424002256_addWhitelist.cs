using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class addWhitelist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WhiteListFormPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tier = table.Column<int>(type: "int", nullable: false),
                    PayerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhiteListFormPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhiteListForms",
                columns: table => new
                {
                    Discord = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Tier = table.Column<int>(type: "int", nullable: false),
                    region = table.Column<int>(type: "int", nullable: false),
                    SteamId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SteamLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SteamAvatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SteamUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RejectReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhiteListForms", x => x.Discord);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhiteListFormPayments");

            migrationBuilder.DropTable(
                name: "WhiteListForms");
        }
    }
}
