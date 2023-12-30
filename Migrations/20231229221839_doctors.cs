using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevuSistemi.Migrations
{
    public partial class doctors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sifre",
                table: "Doktor");

            migrationBuilder.AddColumn<int>(
                name: "DoktorID",
                table: "Randevular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Hasta",
                columns: table => new
                {
                    HastaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hasta", x => x.HastaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_DoktorID",
                table: "Randevular",
                column: "DoktorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_Doktor_DoktorID",
                table: "Randevular",
                column: "DoktorID",
                principalTable: "Doktor",
                principalColumn: "DoktorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_Doktor_DoktorID",
                table: "Randevular");

            migrationBuilder.DropTable(
                name: "Hasta");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_DoktorID",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "DoktorID",
                table: "Randevular");

            migrationBuilder.AddColumn<string>(
                name: "Sifre",
                table: "Doktor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
