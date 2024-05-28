using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_jurnals_TekneId",
                table: "jurnals",
                column: "TekneId");

            migrationBuilder.AddForeignKey(
                name: "FK_jurnals_teknes_TekneId",
                table: "jurnals",
                column: "TekneId",
                principalTable: "teknes",
                principalColumn: "TekneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jurnals_teknes_TekneId",
                table: "jurnals");

            migrationBuilder.DropIndex(
                name: "IX_jurnals_TekneId",
                table: "jurnals");
        }
    }
}
