using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarCastGrupoDois.Infra.Repository.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "doacao",
                schema: "dbo",
                columns: table => new
                {
                    cd_doacao = table.Column<Guid>(nullable: false),
                    cd_tipoDoacao = table.Column<int>(nullable: false),
                    dc_doacao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doacao", x => x.cd_doacao);
                });

            migrationBuilder.CreateTable(
                name: "doador",
                schema: "dbo",
                columns: table => new
                {
                    cd_doador = table.Column<Guid>(nullable: false),
                    email_doador = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    nm_doador = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nm_telefone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    endereco_cidade = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doador", x => x.cd_doador);
                });

            migrationBuilder.CreateTable(
                name: "parceiro",
                schema: "dbo",
                columns: table => new
                {
                    cd_parceiro = table.Column<Guid>(nullable: false),
                    nm_cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    nm_parceiro = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    dc_Desconto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parceiro", x => x.cd_parceiro);
                });

            migrationBuilder.CreateTable(
                name: "alerta",
                schema: "dbo",
                columns: table => new
                {
                    cd_alerta = table.Column<Guid>(nullable: false),
                    cd_tipo_alerta = table.Column<int>(nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    dt_conclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodigoDoacao = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alerta", x => x.cd_alerta);
                    table.ForeignKey(
                        name: "FK_alerta_doacao_CodigoDoacao",
                        column: x => x.CodigoDoacao,
                        principalSchema: "dbo",
                        principalTable: "doacao",
                        principalColumn: "cd_doacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "alertaDoador",
                schema: "dbo",
                columns: table => new
                {
                    cd_alerta = table.Column<Guid>(nullable: false),
                    cd_doador = table.Column<Guid>(nullable: false),
                    AlertaCodigo1 = table.Column<Guid>(nullable: true),
                    DoadorCodigo1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alertaDoador", x => new { x.cd_alerta, x.cd_doador });
                    table.ForeignKey(
                        name: "FK_alertaDoador_alerta_AlertaCodigo1",
                        column: x => x.AlertaCodigo1,
                        principalSchema: "dbo",
                        principalTable: "alerta",
                        principalColumn: "cd_alerta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_alertaDoador_alerta_cd_alerta",
                        column: x => x.cd_alerta,
                        principalSchema: "dbo",
                        principalTable: "alerta",
                        principalColumn: "cd_alerta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_alertaDoador_doador_cd_doador",
                        column: x => x.cd_doador,
                        principalSchema: "dbo",
                        principalTable: "doador",
                        principalColumn: "cd_doador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_alertaDoador_doador_DoadorCodigo1",
                        column: x => x.DoadorCodigo1,
                        principalSchema: "dbo",
                        principalTable: "doador",
                        principalColumn: "cd_doador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alerta_CodigoDoacao",
                schema: "dbo",
                table: "alerta",
                column: "CodigoDoacao");

            migrationBuilder.CreateIndex(
                name: "IX_alertaDoador_AlertaCodigo1",
                schema: "dbo",
                table: "alertaDoador",
                column: "AlertaCodigo1");

            migrationBuilder.CreateIndex(
                name: "IX_alertaDoador_cd_doador",
                schema: "dbo",
                table: "alertaDoador",
                column: "cd_doador");

            migrationBuilder.CreateIndex(
                name: "IX_alertaDoador_DoadorCodigo1",
                schema: "dbo",
                table: "alertaDoador",
                column: "DoadorCodigo1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alertaDoador",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "parceiro",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "alerta",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "doador",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "doacao",
                schema: "dbo");
        }
    }
}
