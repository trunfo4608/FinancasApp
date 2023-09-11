﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinancasApp.Data.Migrations
{
    public partial class AddContasAndCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DATA = table.Column<DateTime>(type: "date", nullable: false),
                    VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OBSERVACOES = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    USUARIOID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CATEGORIAID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TIPO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CONTA_CATEGORIA_CATEGORIAID",
                        column: x => x.CATEGORIAID,
                        principalTable: "CATEGORIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CONTA_USUARIO_USUARIOID",
                        column: x => x.USUARIOID,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIA_NOME",
                table: "CATEGORIA",
                column: "NOME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CONTA_CATEGORIAID",
                table: "CONTA",
                column: "CATEGORIAID");

            migrationBuilder.CreateIndex(
                name: "IX_CONTA_USUARIOID",
                table: "CONTA",
                column: "USUARIOID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONTA");

            migrationBuilder.DropTable(
                name: "CATEGORIA");
        }
    }
}
