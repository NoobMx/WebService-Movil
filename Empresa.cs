namespace WebAppII
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            Dispositivo = new HashSet<Dispositivo>();
            Empleado = new HashSet<Empleado>();
            Medidor = new HashSet<Medidor>();
        }

        public int ID { get; set; }

        public int FechaRegistro { get; set; }

        [Required]
        public string RFC { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string PersonaContacto { get; set; }

        public long TelefonoContacto { get; set; }

        [Required]
        public string Correo { get; set; }

        public bool Estatus { get; set; }

        public int UsuarioID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dispositivo> Dispositivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medidor> Medidor { get; set; }
    }
}
