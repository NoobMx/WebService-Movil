using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAppII
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<BitacoraEmpleado> BitacoraEmpleado { get; set; }
        public virtual DbSet<BitacoraUsuarios> BitacoraUsuarios { get; set; }
        public virtual DbSet<Dispositivo> Dispositivo { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<EmpleadoMedidor> EmpleadoMedidor { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Medidor> Medidor { get; set; }
        public virtual DbSet<Registros> Registros { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleado { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.EmpleadoMedidor)
                .WithOptional(e => e.Empleado)
                .HasForeignKey(e => e.Empleado_ID1);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);
        }
    }
}
