using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2.Migrations
{
    public partial class EquipmentUniqe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Equipments_PersonId",
                table: "Equipments");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_PersonId_InspectionPlanId",
                table: "Equipments",
                columns: new[] { "PersonId", "InspectionPlanId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Equipments_PersonId_InspectionPlanId",
                table: "Equipments");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_PersonId",
                table: "Equipments",
                column: "PersonId");
        }
    }
}
