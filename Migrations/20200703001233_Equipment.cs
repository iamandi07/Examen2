using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2.Migrations
{
    public partial class Equipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    EquipementType = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: false),
                    InspectionPlanId = table.Column<long>(nullable: false),
                    CalibrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_InspectionPlans_InspectionPlanId",
                        column: x => x.InspectionPlanId,
                        principalTable: "InspectionPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_InspectionPlanId",
                table: "Equipments",
                column: "InspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_PersonId",
                table: "Equipments",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipments");
        }
    }
}
