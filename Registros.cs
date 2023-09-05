namespace WebAppII
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registros
    {
        public int ID { get; set; }

        public int Fecha { get; set; }

        public string Accion { get; set; }

        public string Contenido { get; set; }

        public string NumeroSerie { get; set; }
    }

    public partial class RegistrosDTO
    {

        public int ID { get; set; }

        public int Fecha { get; set; }

        public string Accion { get; set; }

        public string Contenido { get; set; }

        public string NumeroSerie { get; set; }
    }
}
