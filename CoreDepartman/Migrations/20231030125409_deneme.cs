using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartman.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departmanlars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmanAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmanlars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    perId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.perId);
                    table.ForeignKey(
                        name: "FK_personels_departmanlars_departid",
                        column: x => x.departid,
                        principalTable: "departmanlars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personels_departid",
                table: "personels",
                column: "departid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "departmanlars");
        }
    }
}
