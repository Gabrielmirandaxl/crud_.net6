using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testcrud.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "tb_users");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "tb_users",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "tb_users",
                newName: "registrationDate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tb_users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "tb_users",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_users",
                newName: "id");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "telefone",
                keyValue: null,
                column: "telefone",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "tb_users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "name",
                keyValue: null,
                column: "name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tb_users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "email",
                keyValue: null,
                column: "email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "tb_users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "cpf",
                keyValue: null,
                column: "cpf",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "tb_users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_users",
                table: "tb_users",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_users",
                table: "tb_users");

            migrationBuilder.RenameTable(
                name: "tb_users",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Usuarios",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "registrationDate",
                table: "Usuarios",
                newName: "RegistrationDate");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Usuarios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Usuarios",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }
    }
}
