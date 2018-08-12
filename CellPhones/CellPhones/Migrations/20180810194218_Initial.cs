using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CellPhones.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cellphone",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    OS = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<string>(nullable: true),
                    Memory = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Prepaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellphone", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cellphone");
        }
    }
}
