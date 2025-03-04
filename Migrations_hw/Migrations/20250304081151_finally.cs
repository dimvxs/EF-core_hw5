using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations_hw.Migrations
{
    /// <inheritdoc />
    public partial class @finally : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupsCurators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    CuratorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsCurators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupsCurators_Curators_CuratorId",
                        column: x => x.CuratorId,
                        principalTable: "Curators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupsCurators_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_TeacherId",
                table: "Lectures",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsLectures_GroupId",
                table: "GroupsLectures",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsLectures_LectureId",
                table: "GroupsLectures",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsCurators_CuratorId",
                table: "GroupsCurators",
                column: "CuratorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsCurators_GroupId",
                table: "GroupsCurators",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupsLectures_Groups_GroupId",
                table: "GroupsLectures",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupsLectures_Lectures_LectureId",
                table: "GroupsLectures",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Subjects_SubjectId",
                table: "Lectures",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Teachers_TeacherId",
                table: "Lectures",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupsLectures_Groups_GroupId",
                table: "GroupsLectures");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupsLectures_Lectures_LectureId",
                table: "GroupsLectures");

            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Subjects_SubjectId",
                table: "Lectures");

            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Teachers_TeacherId",
                table: "Lectures");

            migrationBuilder.DropTable(
                name: "GroupsCurators");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_TeacherId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_GroupsLectures_GroupId",
                table: "GroupsLectures");

            migrationBuilder.DropIndex(
                name: "IX_GroupsLectures_LectureId",
                table: "GroupsLectures");

            migrationBuilder.DropIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments");
        }
    }
}
