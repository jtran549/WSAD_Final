using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Federations",
                columns: table => new
                {
                    FederationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeighIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tested = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Federations", x => x.FederationID);
                });

            migrationBuilder.InsertData(
                table: "Federations",
                columns: new[] { "FederationID", "Cost", "Name", "Tested", "WeighIn" },
                values: new object[] { 1, 45.0, "USAPL", "Drug tested", "24 Hours" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Federations");
        }
    }
}
