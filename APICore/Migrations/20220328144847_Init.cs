using Microsoft.EntityFrameworkCore.Migrations;

namespace APICore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empregados",
                columns: table => new
                {
                    EmpregadoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirsNameEmpl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastNameEmpl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorportionEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaderEmpl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaderID = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregados", x => x.EmpregadoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empregados");
        }
    }
}
