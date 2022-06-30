namespace TravelTripProje3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_iletisim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.iletisims", "Telefon", c => c.String());
            AddColumn("dbo.iletisims", "Sehir", c => c.String());
            DropColumn("dbo.iletisims", "Konu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.iletisims", "Konu", c => c.String());
            DropColumn("dbo.iletisims", "Sehir");
            DropColumn("dbo.iletisims", "Telefon");
        }
    }
}
