using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticateService.Migrations
{
    public partial class AuthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    paymentStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingId);
                });

            migrationBuilder.CreateTable(
                name: "Paymentdtl",
                columns: table => new
                {
                    PaymentId = table.Column<string>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    MentorId = table.Column<string>(nullable: true),
                    TrainingId = table.Column<string>(nullable: true),
                    AmountToMentor = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paymentdtl", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Paymentdtl_Mentordtl_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentordtl",
                        principalColumn: "MentorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paymentdtl_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "TrainingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paymentdtl_Userdtl_UserId",
                        column: x => x.UserId,
                        principalTable: "Userdtl",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_MentorId",
                table: "Paymentdtl",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_TrainingId",
                table: "Paymentdtl",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_UserId",
                table: "Paymentdtl",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paymentdtl");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Training");
        }
    }
}
