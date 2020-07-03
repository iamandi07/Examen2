using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2.Migrations
{
    public partial class InspectionPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InspectionPlans",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Temperature = table.Column<int>(nullable: false),
                    Humidity = table.Column<int>(nullable: false),
                    Pressure = table.Column<int>(nullable: false),
                    PersonId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionPlans_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InspectionPlans_PersonId",
                table: "InspectionPlans",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InspectionPlans");
        }
    }
}
