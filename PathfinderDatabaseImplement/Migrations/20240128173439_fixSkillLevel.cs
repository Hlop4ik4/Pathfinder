using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathfinderDatabaseImplement.Migrations
{
    /// <inheritdoc />
    public partial class fixSkillLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SkillLevels_SkillId",
                table: "SkillLevels",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillLevels_Skills_SkillId",
                table: "SkillLevels",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillLevels_Skills_SkillId",
                table: "SkillLevels");

            migrationBuilder.DropIndex(
                name: "IX_SkillLevels_SkillId",
                table: "SkillLevels");
        }
    }
}
