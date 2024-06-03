using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Console.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioID",
                table: "tb_venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Horario",
                table: "tb_venda",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "tb_venda",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CompraID",
                table: "tb_veiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Condicao_",
                table: "tb_veiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstabelecimentoID",
                table: "tb_veiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioID",
                table: "tb_usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "tb_usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "tb_usuario",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Combustivel",
                table: "tb_modelo",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "tb_modelo",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "tb_modelo",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "tb_modelo",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "NumeroPortas",
                table: "tb_modelo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Transmissao",
                table: "tb_modelo",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "tb_funcionario",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "tb_funcionario",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "tb_fornecedor",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "tb_fornecedor",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Horario",
                table: "tb_compra",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "tb_compra",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "tb_cliente",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "tb_cliente",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tb_venda_FuncionarioID",
                table: "tb_venda",
                column: "FuncionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_veiculo_CompraID",
                table: "tb_veiculo",
                column: "CompraID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_veiculo_EstabelecimentoID",
                table: "tb_veiculo",
                column: "EstabelecimentoID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_usuario_FuncionarioID",
                table: "tb_usuario",
                column: "FuncionarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_usuario_tb_funcionario_FuncionarioID",
                table: "tb_usuario",
                column: "FuncionarioID",
                principalTable: "tb_funcionario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_veiculo_tb_compra_CompraID",
                table: "tb_veiculo",
                column: "CompraID",
                principalTable: "tb_compra",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_veiculo_tb_estabelecimento_EstabelecimentoID",
                table: "tb_veiculo",
                column: "EstabelecimentoID",
                principalTable: "tb_estabelecimento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_venda_tb_funcionario_FuncionarioID",
                table: "tb_venda",
                column: "FuncionarioID",
                principalTable: "tb_funcionario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_venda_tb_veiculo_ID",
                table: "tb_venda",
                column: "ID",
                principalTable: "tb_veiculo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_usuario_tb_funcionario_FuncionarioID",
                table: "tb_usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_veiculo_tb_compra_CompraID",
                table: "tb_veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_veiculo_tb_estabelecimento_EstabelecimentoID",
                table: "tb_veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_venda_tb_funcionario_FuncionarioID",
                table: "tb_venda");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_venda_tb_veiculo_ID",
                table: "tb_venda");

            migrationBuilder.DropIndex(
                name: "IX_tb_venda_FuncionarioID",
                table: "tb_venda");

            migrationBuilder.DropIndex(
                name: "IX_tb_veiculo_CompraID",
                table: "tb_veiculo");

            migrationBuilder.DropIndex(
                name: "IX_tb_veiculo_EstabelecimentoID",
                table: "tb_veiculo");

            migrationBuilder.DropIndex(
                name: "IX_tb_usuario_FuncionarioID",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "FuncionarioID",
                table: "tb_venda");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "tb_venda");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "tb_venda");

            migrationBuilder.DropColumn(
                name: "CompraID",
                table: "tb_veiculo");

            migrationBuilder.DropColumn(
                name: "Condicao_",
                table: "tb_veiculo");

            migrationBuilder.DropColumn(
                name: "EstabelecimentoID",
                table: "tb_veiculo");

            migrationBuilder.DropColumn(
                name: "FuncionarioID",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "tb_usuario");

            migrationBuilder.DropColumn(
                name: "Combustivel",
                table: "tb_modelo");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "tb_modelo");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "tb_modelo");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "tb_modelo");

            migrationBuilder.DropColumn(
                name: "NumeroPortas",
                table: "tb_modelo");

            migrationBuilder.DropColumn(
                name: "Transmissao",
                table: "tb_modelo");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "tb_funcionario");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "tb_funcionario");

            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "tb_fornecedor");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "tb_fornecedor");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "tb_compra");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "tb_compra");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "tb_cliente");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "tb_cliente");
        }
    }
}
