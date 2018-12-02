using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineEclub.Data.Migrations
{
    public partial class AddInitialModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "Group",
                newName: "GroupTitle");

            migrationBuilder.AlterColumn<int>(
                name: "ContentID",
                table: "Group",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Group",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    ContentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.ContentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_CategoryID",
                table: "Group",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ContentID",
                table: "Group",
                column: "ContentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Category_CategoryID",
                table: "Group",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Content_ContentID",
                table: "Group",
                column: "ContentID",
                principalTable: "Content",
                principalColumn: "ContentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_Category_CategoryID",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_Content_ContentID",
                table: "Group");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropIndex(
                name: "IX_Group_CategoryID",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_ContentID",
                table: "Group");

            migrationBuilder.RenameColumn(
                name: "GroupTitle",
                table: "Group",
                newName: "GroupName");

            migrationBuilder.AlterColumn<int>(
                name: "ContentID",
                table: "Group",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Group",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
