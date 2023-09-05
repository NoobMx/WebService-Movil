namespace WebAppII
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpleadoMedidor")]
    public partial class EmpleadoMedidor
    {
        public int ID { get; set; }

        public bool Estatus { get; set; }

        public int MedidorID { get; set; }

        public int? Empleado_ID { get; set; }

        public int? Empleado_ID1 { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Medidor Medidor { get; set; }
    }
}
