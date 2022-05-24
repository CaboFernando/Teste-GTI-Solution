namespace ProjetoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Cpf = c.String(nullable: false, maxLength: 14),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Rg = c.String(maxLength: 14),
                        DataExpedicao = c.DateTime(nullable: false),
                        OrgaoExpedicao = c.String(),
                        UfExpedicao = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.String(nullable: false),
                        EstadoCivial = c.String(nullable: false),
                        EnderecoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Enderecos", t => t.EnderecoId, cascadeDelete: true)
                .Index(t => t.EnderecoId);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false, maxLength: 150),
                        Numero = c.String(nullable: false, maxLength: 100),
                        Complemento = c.String(maxLength: 100),
                        Bairro = c.String(nullable: false, maxLength: 100),
                        Cidade = c.String(nullable: false, maxLength: 100),
                        Uf = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.EnderecoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "EnderecoId", "dbo.Enderecos");
            DropIndex("dbo.Clientes", new[] { "EnderecoId" });
            DropTable("dbo.Enderecos");
            DropTable("dbo.Clientes");
        }
    }
}
