using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapApi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yil = table.Column<int>(type: "int", nullable: false),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "Id", "Ad", "Yazar", "Yil" },
                values: new object[,]
                {
                    { 1, "Çalıkuşu", "Reşat Nuri Güntekin", 1922 },
                    { 2, "Çulsuzlar", "Dan Kavanagh", 2002 },
                    { 3, "Kendi Everest'inize Tırmanın", "Nasuh Mahruki", 2019 },
                    { 4, "Körlük", "Jose Saramago", 1995 },
                    { 5, "Aptallığın övgüsü", "Erasmus", 1511 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaplar");
        }
    }
}
