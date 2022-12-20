using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digiruokalista.com.Migrations
{
    /// <inheritdoc />
    public partial class ruokatykkays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RuokaTykkaykset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RuokaIdID = table.Column<int>(type: "int", nullable: true),
                    IP = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuokaTykkaykset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RuokaTykkaykset_Ruoka_RuokaIdID",
                        column: x => x.RuokaIdID,
                        principalTable: "Ruoka",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RuokaTykkaykset_RuokaIdID",
                table: "RuokaTykkaykset",
                column: "RuokaIdID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RuokaTykkaykset");
        }
    }
}
