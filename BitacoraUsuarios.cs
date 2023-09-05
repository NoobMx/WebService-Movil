namespace WebAppII
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BitacoraUsuarios
    {
        public int ID { get; set; }

        public string Observaciones { get; set; }

        public string Accion { get; set; }

        public int Fecha { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
