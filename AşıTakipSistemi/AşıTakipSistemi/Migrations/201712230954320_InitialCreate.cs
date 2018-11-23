namespace AşıTakipSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aşılar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        aşı_Adı = c.String(),
                        doz1 = c.Int(nullable: false),
                        doz2 = c.Int(nullable: false),
                        doz3 = c.Int(nullable: false),
                        doz4 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Çalışanlar",
                c => new
                    {
                        sicil_No = c.Int(nullable: false, identity: true),
                        ad = c.String(),
                        soyad = c.String(),
                        görev_Tipi = c.Int(nullable: false),
                        şifre = c.String(),
                    })
                .PrimaryKey(t => t.sicil_No);
            
            CreateTable(
                "dbo.Hastalars",
                c => new
                    {
                        TC_Kimlik_No = c.Double(nullable: false),
                        ad = c.String(),
                        soyad = c.String(),
                        doğum_Tarihi = c.DateTime(nullable: false),
                        olduğu_Aşılar = c.String(),
                    })
                .PrimaryKey(t => t.TC_Kimlik_No);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hastalars");
            DropTable("dbo.Çalışanlar");
            DropTable("dbo.Aşılar");
        }
    }
}
