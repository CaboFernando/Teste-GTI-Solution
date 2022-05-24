namespace ProjetoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "EstadoCivil", c => c.String(nullable: false));
            DropColumn("dbo.Clientes", "EstadoCivial");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "EstadoCivial", c => c.String(nullable: false));
            DropColumn("dbo.Clientes", "EstadoCivil");
        }
    }
}
