namespace CONTEXTO
{
    using MODELO;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public class TUTOPIA : DbContext
    {
        //AGREGO EL PATRON SINGLETON PARA TRABAJAR CON UNA UNICA INSTANCIA DEL CONTEXTO
        private static TUTOPIA instancia;

        public static TUTOPIA obtener_instancia()
        {
            if (instancia == null)
                instancia = new TUTOPIA();

            return instancia;
        }
        public TUTOPIA() : base("CONTEXTO.TUTOPIA")
        {
        }

        public DbSet<Cliente> oCliente { get; set; }
        public DbSet<Turno> oTurno { get; set; }
        public DbSet<Ficha> oFicha { get; set; }
        public DbSet<Multimedia> oMultimedia { get; set; }
        public DbSet<Agenda> oAgenda { get; set; }
        public DbSet<Horario> oHorario { get; set; }
        public DbSet<Dia> oDia { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuración de la relación uno a muchos entre Cliente y Turno
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Turnos)
                .WithRequired(t => t.Cliente)
                .HasForeignKey(t => t.ClienteId);

            // Configuración de la relación uno a uno entre Cliente y Ficha
            modelBuilder.Entity<Cliente>()
                .HasOptional(c => c.Ficha) 
                .WithRequired(f => f.Cliente);

            // Configuración de la relación uno a muchos entre Ficha y Multimedia
            modelBuilder.Entity<Ficha>()
                .HasMany(f => f.Estudios)
                .WithRequired(m => m.Ficha)
                .HasForeignKey(m => m.FichaId);


            // Configuración de la relación muchos a muchos entre Cliente y Horario
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.HorarioClientes)
                .WithRequired(hc => hc.Cliente)
                .HasForeignKey(hc => hc.ClienteId);

            modelBuilder.Entity<Horario>()
                .HasMany(h => h.HorarioClientes)
                .WithRequired(hc => hc.Horario)
                .HasForeignKey(hc => hc.HorarioId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
