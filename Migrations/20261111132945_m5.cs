using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TAKI.adi.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_subject_SubjectId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_teacher_teacherId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subject",
                table: "subject");

            migrationBuilder.RenameTable(
                name: "subject",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "teacher",
                table: "Subject",
                newName: "Teacher");

            migrationBuilder.RenameColumn(
                name: "points",
                table: "Subject",
                newName: "Points");

            migrationBuilder.RenameColumn(
                name: "bagrut",
                table: "Subject",
                newName: "Bagrut");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Subject",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "teacherId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Subject_SubjectId",
                table: "Students",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_teacher_teacherId",
                table: "Students",
                column: "teacherId",
                principalTable: "teacher",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Subject_SubjectId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_teacher_teacherId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Subject");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "Teacher",
                table: "subject",
                newName: "teacher");

            migrationBuilder.RenameColumn(
                name: "Points",
                table: "subject",
                newName: "points");

            migrationBuilder.RenameColumn(
                name: "Bagrut",
                table: "subject",
                newName: "bagrut");

            migrationBuilder.AlterColumn<int>(
                name: "teacherId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_subject",
                table: "subject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_subject_SubjectId",
                table: "Students",
                column: "SubjectId",
                principalTable: "subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_teacher_teacherId",
                table: "Students",
                column: "teacherId",
                principalTable: "teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
