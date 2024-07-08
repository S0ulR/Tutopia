namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class final : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendas",
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
                    TurnoId = c.Int(),
                    AgendaId = c.Int(),
                })
                .PrimaryKey(t => t.DiaId)
                .ForeignKey("dbo.Turnos", t => t.TurnoId)
                .ForeignKey("dbo.Agendas", t => t.AgendaId)
                .Index(t => t.TurnoId)
                .Index(t => t.AgendaId);

            CreateTable(
                "dbo.Horarios",
                c => new
                {
                    HorarioId = c.Int(nullable: false, identity: true),
                    Hora = c.Time(nullable: false, precision: 7),
                    Cupo = c.Int(nullable: false),
                    Dia = c.String(),
                    DiaId = c.Int(),
                })
                .PrimaryKey(t => t.HorarioId)
                .ForeignKey("dbo.Dias", t => t.DiaId)
                .Index(t => t.DiaId);

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
                    UltimoPago = c.DateTime(),
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
                .Index(t => t.ClienteId);

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
                "dbo.Turnos",
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
                .ForeignKey("dbo.Agendas", t => t.AgendaId)
                .ForeignKey("dbo.Horarios", t => t.HorarioId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.HorarioId)
                .Index(t => t.AgendaId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Dias", "AgendaId", "dbo.Agendas");
            DropForeignKey("dbo.Horarios", "DiaId", "dbo.Dias");
            DropForeignKey("dbo.HorarioClientes", "HorarioId", "dbo.Horarios");
            DropForeignKey("dbo.Turnos", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Turnos", "HorarioId", "dbo.Horarios");
            DropForeignKey("dbo.Dias", "TurnoId", "dbo.Turnos");
            DropForeignKey("dbo.Turnos", "AgendaId", "dbo.Agendas");
            DropForeignKey("dbo.HorarioClientes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Fichas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Multimedias", "FichaId", "dbo.Fichas");
            DropIndex("dbo.Turnos", new[] { "AgendaId" });
            DropIndex("dbo.Turnos", new[] { "HorarioId" });
            DropIndex("dbo.Turnos", new[] { "ClienteId" });
            DropIndex("dbo.Multimedias", new[] { "FichaId" });
            DropIndex("dbo.Fichas", new[] { "ClienteId" });
            DropIndex("dbo.HorarioClientes", new[] { "ClienteId" });
            DropIndex("dbo.HorarioClientes", new[] { "HorarioId" });
            DropIndex("dbo.Horarios", new[] { "DiaId" });
            DropIndex("dbo.Dias", new[] { "AgendaId" });
            DropIndex("dbo.Dias", new[] { "TurnoId" });
            DropTable("dbo.Turnos");
            DropTable("dbo.Multimedias");
            DropTable("dbo.Fichas");
            DropTable("dbo.Clientes");
            DropTable("dbo.HorarioClientes");
            DropTable("dbo.Horarios");
            DropTable("dbo.Dias");
            DropTable("dbo.Agendas");
        }
    }
}
