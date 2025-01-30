using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStractur.Migrations
{
    /// <inheritdoc />
    public partial class emailunique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCourse_courses_CourseId",
                table: "UserCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourse_users_UserId",
                table: "UserCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCourse",
                table: "UserCourse");

            migrationBuilder.RenameTable(
                name: "UserCourse",
                newName: "usersCourses");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourse_UserId",
                table: "usersCourses",
                newName: "IX_usersCourses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourse_CourseId",
                table: "usersCourses",
                newName: "IX_usersCourses_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usersCourses",
                table: "usersCourses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_usersCourses_courses_CourseId",
                table: "usersCourses",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usersCourses_users_UserId",
                table: "usersCourses",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usersCourses_courses_CourseId",
                table: "usersCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_usersCourses_users_UserId",
                table: "usersCourses");

            migrationBuilder.DropIndex(
                name: "IX_users_Email",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usersCourses",
                table: "usersCourses");

            migrationBuilder.RenameTable(
                name: "usersCourses",
                newName: "UserCourse");

            migrationBuilder.RenameIndex(
                name: "IX_usersCourses_UserId",
                table: "UserCourse",
                newName: "IX_UserCourse_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_usersCourses_CourseId",
                table: "UserCourse",
                newName: "IX_UserCourse_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCourse",
                table: "UserCourse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourse_courses_CourseId",
                table: "UserCourse",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourse_users_UserId",
                table: "UserCourse",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
