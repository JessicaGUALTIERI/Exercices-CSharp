using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP_Entity_FirstTP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnimalEspece = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ClientNom = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ReservationAnimalAnimalId = table.Column<int>(type: "int", nullable: true),
                    ReservationClientClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Animals_ReservationAnimalAnimalId",
                        column: x => x.ReservationAnimalAnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId");
                    table.ForeignKey(
                        name: "FK_Reservations_Clients_ReservationClientClientId",
                        column: x => x.ReservationClientClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AnimalEspece" },
                values: new object[,]
                {
                    { 1, "Chat" },
                    { 2, "Chien" },
                    { 3, "Renard" },
                    { 4, "Loutre" },
                    { 5, "Poney" },
                    { 6, "Corbeau" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "ClientNom" },
                values: new object[,]
                {
                    { 1, "Jeanne" },
                    { 2, "Maurice" },
                    { 3, "Lison" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationAnimalAnimalId",
                table: "Reservations",
                column: "ReservationAnimalAnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationClientClientId",
                table: "Reservations",
                column: "ReservationClientClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
