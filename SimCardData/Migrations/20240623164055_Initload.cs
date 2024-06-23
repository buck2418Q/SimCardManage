using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimCardData.Migrations
{
    /// <inheritdoc />
    public partial class Initload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adminModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "deviceModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deviceModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "providerModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_providerModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "simCardPlanModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_simCardPlanModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "simModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    deviceModelsId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    providerModelsId = table.Column<int>(type: "int", nullable: false),
                    IsActiveUser = table.Column<bool>(type: "bit", nullable: false),
                    userModelsId = table.Column<int>(type: "int", nullable: false),
                    simCardPlanModelsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_simModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_simModels_deviceModels_deviceModelsId",
                        column: x => x.deviceModelsId,
                        principalTable: "deviceModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_simModels_providerModels_providerModelsId",
                        column: x => x.providerModelsId,
                        principalTable: "providerModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_simModels_simCardPlanModels_simCardPlanModelsId",
                        column: x => x.simCardPlanModelsId,
                        principalTable: "simCardPlanModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_simModels_userModels_userModelsId",
                        column: x => x.userModelsId,
                        principalTable: "userModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_simModels_deviceModelsId",
                table: "simModels",
                column: "deviceModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_simModels_providerModelsId",
                table: "simModels",
                column: "providerModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_simModels_simCardPlanModelsId",
                table: "simModels",
                column: "simCardPlanModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_simModels_userModelsId",
                table: "simModels",
                column: "userModelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adminModels");

            migrationBuilder.DropTable(
                name: "simModels");

            migrationBuilder.DropTable(
                name: "deviceModels");

            migrationBuilder.DropTable(
                name: "providerModels");

            migrationBuilder.DropTable(
                name: "simCardPlanModels");

            migrationBuilder.DropTable(
                name: "userModels");
        }
    }
}
