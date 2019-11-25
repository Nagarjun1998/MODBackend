using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentService.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paymentdtl",
                columns: table => new
                {
                    PaymentId = table.Column<string>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    MentorId = table.Column<string>(nullable: true),
                    MentorName = table.Column<string>(nullable: true),
                    TrainingId = table.Column<string>(nullable: true),
                    AmountToMentor = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paymentdtl", x => x.PaymentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paymentdtl");
        }
    }
}
