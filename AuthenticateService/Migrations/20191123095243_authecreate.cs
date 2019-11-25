using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticateService.Migrations
{
    public partial class authecreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MentorName",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "SkillName",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Training");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Training",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkillId",
                table: "Training",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "Training",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorId",
                table: "Training",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_SkillId",
                table: "Training",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UserId",
                table: "Training",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Mentordtl_MentorId",
                table: "Training",
                column: "MentorId",
                principalTable: "Mentordtl",
                principalColumn: "MentorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Skill_SkillId",
                table: "Training",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Userdtl_UserId",
                table: "Training",
                column: "UserId",
                principalTable: "Userdtl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_Mentordtl_MentorId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Skill_SkillId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Userdtl_UserId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_MentorId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_SkillId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_UserId",
                table: "Training");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkillId",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MentorName",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillName",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
