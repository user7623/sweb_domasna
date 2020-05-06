using Microsoft.EntityFrameworkCore.Migrations;

namespace SWEB_app.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentID",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_StudentID",
                table: "Enrollment");

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Enrollment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Enrollment",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentID1",
                table: "Enrollment",
                column: "StudentID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentID1",
                table: "Enrollment",
                column: "StudentID1",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentID1",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_StudentID1",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "StudentID1",
                table: "Enrollment");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Enrollment",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentID",
                table: "Enrollment",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentID",
                table: "Enrollment",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
