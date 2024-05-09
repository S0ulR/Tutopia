namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        AgendaId = c.Int(nullable: false, identity: true),
                        Mes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AgendaId);
            
            CreateTable(
                "dbo.Dias",
                c => new
                    {
                        DiaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Turno_TurnoId = c.Int(),
                        Agenda_AgendaId = c.Int(),
                    })
                .PrimaryKey(t => t.DiaId)
                .ForeignKey("dbo.Turnoes", t => t.Turno_TurnoId)
                .ForeignKey("dbo.Agenda", t => t.Agenda_AgendaId)
                .Index(t => t.Turno_TurnoId)
                .Index(t => t.Agenda_AgendaId);
            
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        HorarioId = c.Int(nullable: false, identity: true),
                        Hora = c.Time(nullable: false, precision: 7),
                        Cupo = c.Int(nullable: false),
                        Dia = c.String(),
                        Dia_DiaId = c.Int(),
                    })
                .PrimaryKey(t => t.HorarioId)
                .ForeignKey("dbo.Dias", t => t.Dia_DiaId)
                .Index(t => t.Dia_DiaId);
            
            CreateTable(
                "dbo.HorarioClientes",
                c => new
                    {
                        HorarioId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HorarioId, t.ClienteId })
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Horarios", t => t.HorarioId, cascadeDelete: true)
                .Index(t => t.HorarioId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Imagen = c.Binary(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        DNI = c.String(),
                        Domicilio = c.String(),
                        Fecha_Nac = c.DateTime(nullable: false),
                        Fecha_Ingreso = c.DateTime(nullable: false),
                        ultimoPago = c.DateTime(),
                        Correo = c.String(),
                        Edad = c.Int(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Telefono = c.Long(nullable: false),
                        Deudor = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Fichas",
                c => new
                    {
                        FichaId = c.Int(nullable: false, identity: true),
                        Fecha_Creacion = c.DateTime(nullable: false),
                        Nota = c.String(),
                        ClienteId = c.Int(nullable: false),
                        Afeccion = c.String(),
                        Cirugia = c.Boolean(),
                        CirugiaNombre = c.String(),
                        Alergia = c.Boolean(),
                        AlergiaTipo = c.String(),
                        Altura = c.Double(),
                        Peso = c.Double(),
                        Sangre = c.String(),
                        Tipo = c.String(),
                        Presion = c.Boolean(),
                    })
                .PrimaryKey(t => t.FichaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.FichaId);
            
            CreateTable(
                "dbo.Multimedias",
                c => new
                    {
                        MultimediaId = c.Int(nullable: false, identity: true),
                        NombreArchivo = c.String(),
                        Estudio = c.Binary(),
                        FichaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MultimediaId)
                .ForeignKey("dbo.Fichas", t => t.FichaId, cascadeDelete: true)
                .Index(t => t.FichaId);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        TurnoId = c.Int(nullable: false, identity: true),
                        Reservado = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        HorarioId = c.Int(),
                        AgendaId = c.Int(),
                        DiaId = c.Int(),
                    })
                .PrimaryKey(t => t.TurnoId)
                .ForeignKey("dbo.Agenda", t => t.AgendaId)
                .ForeignKey("dbo.Horarios", t => t.HorarioId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.HorarioId)
                .Index(t => t.AgendaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dias", "Agenda_AgendaId", "dbo.Agenda");
            DropForeignKey("dbo.Horarios", "Dia_DiaId", "dbo.Dias");
            DropForeignKey("dbo.HorarioClientes", "HorarioId", "dbo.Horarios");
            DropForeignKey("dbo.Turnoes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Turnoes", "HorarioId", "dbo.Horarios");
            DropForeignKey("dbo.Dias", "Turno_TurnoId", "dbo.Turnoes");
            DropForeignKey("dbo.Turnoes", "AgendaId", "dbo.Agenda");
            DropForeignKey("dbo.HorarioClientes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Fichas", "FichaId", "dbo.Clientes");
            DropForeignKey("dbo.Multimedias", "FichaId", "dbo.Fichas");
            DropIndex("dbo.Turnoes", new[] { "AgendaId" });
            DropIndex("dbo.Turnoes", new[] { "HorarioId" });
            DropIndex("dbo.Turnoes", new[] { "ClienteId" });
            DropIndex("dbo.Multimedias", new[] { "FichaId" });
            DropIndex("dbo.Fichas", new[] { "FichaId" });
            DropIndex("dbo.HorarioClientes", new[] { "ClienteId" });
            DropIndex("dbo.HorarioClientes", new[] { "HorarioId" });
            DropIndex("dbo.Horarios", new[] { "Dia_DiaId" });
            DropIndex("dbo.Dias", new[] { "Agenda_AgendaId" });
            DropIndex("dbo.Dias", new[] { "Turno_TurnoId" });
            DropTable("dbo.Turnoes");
            DropTable("dbo.Multimedias");
            DropTable("dbo.Fichas");
            DropTable("dbo.Clientes");
            DropTable("dbo.HorarioClientes");
            DropTable("dbo.Horarios");
            DropTable("dbo.Dias");
            DropTable("dbo.Agenda");
        }
    }
}
