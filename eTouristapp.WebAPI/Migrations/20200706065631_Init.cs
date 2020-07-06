using Microsoft.EntityFrameworkCore.Migrations;

namespace eTouristapp.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karta_Putnik",
                table: "Karta");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjena_Korisnik_KorisnikId",
                table: "Ocjena");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjena_Putnik",
                table: "Ocjena");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjena_Termin",
                table: "Ocjena");

            migrationBuilder.DropIndex(
                name: "IX_Ocjena_PutnikID",
                table: "Ocjena");

            migrationBuilder.DropIndex(
                name: "IX_Ocjena_TerminID",
                table: "Ocjena");

            migrationBuilder.DropIndex(
                name: "IX_Karta_PutnikID",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "PutnikID",
                table: "Ocjena");

            migrationBuilder.DropColumn(
                name: "TerminID",
                table: "Ocjena");

            migrationBuilder.DropColumn(
                name: "PutnikID",
                table: "Karta");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Ocjena",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Ocjena_KorisnikId",
                table: "Ocjena",
                newName: "IX_Ocjena_KorisnikID");

            migrationBuilder.AddColumn<int>(
                name: "DestinacijaID",
                table: "Ocjena",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ponistena",
                table: "Karta",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Karta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_DestinacijaID",
                table: "Ocjena",
                column: "DestinacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_KorisnikID",
                table: "Karta",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "fk_Korisnik_Karta",
                table: "Karta",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_Destinacija",
                table: "Ocjena",
                column: "DestinacijaID",
                principalTable: "Destinacija",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_Korisnik",
                table: "Ocjena",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_Korisnik_Karta",
                table: "Karta");

            migrationBuilder.DropForeignKey(
                name: "fk_Destinacija",
                table: "Ocjena");

            migrationBuilder.DropForeignKey(
                name: "fk_Korisnik",
                table: "Ocjena");

            migrationBuilder.DropIndex(
                name: "IX_Ocjena_DestinacijaID",
                table: "Ocjena");

            migrationBuilder.DropIndex(
                name: "IX_Karta_KorisnikID",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "DestinacijaID",
                table: "Ocjena");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Karta");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Ocjena",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Ocjena_KorisnikID",
                table: "Ocjena",
                newName: "IX_Ocjena_KorisnikId");

            migrationBuilder.AddColumn<int>(
                name: "PutnikID",
                table: "Ocjena",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TerminID",
                table: "Ocjena",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ponistena",
                table: "Karta",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "PutnikID",
                table: "Karta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_PutnikID",
                table: "Ocjena",
                column: "PutnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_TerminID",
                table: "Ocjena",
                column: "TerminID");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_PutnikID",
                table: "Karta",
                column: "PutnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Karta_Putnik",
                table: "Karta",
                column: "PutnikID",
                principalTable: "Putnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjena_Korisnik_KorisnikId",
                table: "Ocjena",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjena_Putnik",
                table: "Ocjena",
                column: "PutnikID",
                principalTable: "Putnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjena_Termin",
                table: "Ocjena",
                column: "TerminID",
                principalTable: "Termin",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
