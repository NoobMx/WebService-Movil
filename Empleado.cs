namespace WebAppII
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            BitacoraEmpleado = new HashSet<BitacoraEmpleado>();
            EmpleadoMedidor = new HashSet<EmpleadoMedidor>();
        }

        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public string Contraseña { get; set; }

        public bool Estatus { get; set; }

        public int TipoEmpleadoID { get; set; }

        public int EmpresaID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BitacoraEmpleado> BitacoraEmpleado { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual TipoEmpleado TipoEmpleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoMedidor> EmpleadoMedidor { get; set; }
    }

    public partial class EmpleadoDTO
    {

        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public string Contraseña { get; set; }

        public bool Estatus { get; set; }

        public int TipoEmpleadoID { get; set; }
        public string TipoEmpleado { get; set; }

        public List<BitacoraEmpleado> BitacoraEmpleado { get; set; }

        public List<EmpleadoMedidor> EmpleadoMedidor { get; set; }
    }
}
