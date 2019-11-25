using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticateService.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentordtl");

            migrationBuilder.DropTable(
                name: "Userdtl");
        }
    }
}
