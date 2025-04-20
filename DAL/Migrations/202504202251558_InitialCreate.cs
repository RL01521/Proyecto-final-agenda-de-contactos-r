namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(nullable: false, maxLength: 20),
                        Correo = c.String(maxLength: 100),
                        CargoEmpleado = c.Int(),
                        FechaContratacion = c.DateTime(),
                        FechaNacimiento = c.DateTime(),
                        HistorialClinico = c.String(),
                        TipoContacto = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contactoes");
        }
    }
}
