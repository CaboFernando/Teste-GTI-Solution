namespace ProjetoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualização : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enderecos", "Cep", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enderecos", "Cep");
        }
    }
}
