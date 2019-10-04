using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskiesBlazor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoBlock",
                columns: table => new
                {
                    idTaskBlock = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dtModified = table.Column<DateTime>(nullable: false),
                    deTaskBlock = table.Column<string>(nullable: true),
                    isCompleted = table.Column<bool>(nullable: false),
                    coColor = table.Column<string>(nullable: true),
                    order = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoBlock", x => x.idTaskBlock);
                });

            migrationBuilder.CreateTable(
                name: "ToDo",
                columns: table => new
                {
                    idTask = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deTask = table.Column<string>(nullable: true),
                    isCompleted = table.Column<bool>(nullable: false),
                    dtModified = table.Column<DateTime>(nullable: false),
                    idTaskBlock = table.Column<int>(nullable: false),
                    idParent = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDo", x => x.idTask);
                    table.ForeignKey(
                        name: "FK_ToDo_ToDo_idParent",
                        column: x => x.idParent,
                        principalTable: "ToDo",
                        principalColumn: "idTask",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ToDo_ToDoBlock_idTaskBlock",
                        column: x => x.idTaskBlock,
                        principalTable: "ToDoBlock",
                        principalColumn: "idTaskBlock",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_idParent",
                table: "ToDo",
                column: "idParent");

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_idTaskBlock",
                table: "ToDo",
                column: "idTaskBlock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDo");

            migrationBuilder.DropTable(
                name: "ToDoBlock");
        }
    }
}
