namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevapropiedaddepruebaenAlbum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Prueba", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Prueba");
        }
    }
}
