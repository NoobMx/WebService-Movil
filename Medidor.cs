namespace WebAppII
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medidor")]
    public partial class Medidor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medidor()
        {
            Dispositivo = new HashSet<Dispositivo>();
            EmpleadoMedidor = new HashSet<EmpleadoMedidor>();
        }

        public int ID { get; set; }

        [Required]
        public string NumeroSerie { get; set; }

        public int FechaResgistro { get; set; }

        public bool Estatus { get; set; }

        public double Longitud { get; set; }

        public double Latitud { get; set; }

        public int EmpresaID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dispositivo> Dispositivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoMedidor> EmpleadoMedidor { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
