using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentService.Migrations
{
    public partial class PayCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MentorDtlMentorId",
                table: "Paymentdtl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserdtlUserId",
                table: "Paymentdtl",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mentordtl",
                columns: table => new
                {
                    MentorId = table.Column<string>(nullable: false),
                    MentorName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    ContactNo = table.Column<string>(maxLength: 10, nullable: true),
                    Password = table.Column<string>(maxLength: 5, nullable: false),
                    TimeSlot = table.Column<string>(nullable: true),
                    YearsOfExperience = table.Column<int>(nullable: true),
                    Facilities = table.Column<string>(nullable: true),
                    Technologies = table.Column<string>(nullable: true),
                    linkedInUrl = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentordtl", x => x.MentorId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<string>(nullable: false),
                    SkillName = table.Column<string>(nullable: true),
                    toc = table.Column<string>(nullable: true),
                    prerequisites = table.Column<string>(nullable: true),
                    fees = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "Userdtl",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 5, nullable: false),
                    ContactNo = table.Column<string>(maxLength: 10, nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userdtl", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainingId = table.Column<string>(nullable: false),
                    TrainingName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    MentorId = table.Column<string>(nullable: true),
                    SkillId = table.Column<string>(nullable: true),
                    timeslot = table.Column<string>(nullable: true),
                    duration = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    progress = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    MentorName = table.Column<string>(nullable: true),
                    SkillName = table.Column<string>(nullable: true),
                    startDate = table.Column<DateTime>(nullable: true),
                    endDate = table.Column<DateTime>(nullable: true),
                    requested = table.Column<bool>(nullable: true),
                    rejectNotify = table.Column<bool>(nullable: true),
                    paymentStatus = table.Column<bool>(nullable: true),
                    MentorDtlMentorId = table.Column<string>(nullable: true),
                    UserdtlUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingId);
                    table.ForeignKey(
                        name: "FK_Training_Mentordtl_MentorDtlMentorId",
                        column: x => x.MentorDtlMentorId,
                        principalTable: "Mentordtl",
                        principalColumn: "MentorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Training_Userdtl_UserdtlUserId",
                        column: x => x.UserdtlUserId,
                        principalTable: "Userdtl",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_MentorDtlMentorId",
                table: "Paymentdtl",
                column: "MentorDtlMentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_UserdtlUserId",
                table: "Paymentdtl",
                column: "UserdtlUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorDtlMentorId",
                table: "Training",
                column: "MentorDtlMentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UserdtlUserId",
                table: "Training",
                column: "UserdtlUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paymentdtl_Mentordtl_MentorDtlMentorId",
                table: "Paymentdtl",
                column: "MentorDtlMentorId",
                principalTable: "Mentordtl",
                principalColumn: "MentorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paymentdtl_Userdtl_UserdtlUserId",
                table: "Paymentdtl",
                column: "UserdtlUserId",
                principalTable: "Userdtl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paymentdtl_Mentordtl_MentorDtlMentorId",
                table: "Paymentdtl");

            migrationBuilder.DropForeignKey(
                name: "FK_Paymentdtl_Userdtl_UserdtlUserId",
                table: "Paymentdtl");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentordtl");

            migrationBuilder.DropTable(
                name: "Userdtl");

            migrationBuilder.DropIndex(
                name: "IX_Paymentdtl_MentorDtlMentorId",
                table: "Paymentdtl");

            migrationBuilder.DropIndex(
                name: "IX_Paymentdtl_UserdtlUserId",
                table: "Paymentdtl");

            migrationBuilder.DropColumn(
                name: "MentorDtlMentorId",
                table: "Paymentdtl");

            migrationBuilder.DropColumn(
                name: "UserdtlUserId",
                table: "Paymentdtl");
        }
    }
}
