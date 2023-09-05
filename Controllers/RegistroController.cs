using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppII.Controllers
{
    public class RegistroController : ApiController
    {
        ModelDB db = new ModelDB();

        [ActionName("addRegistros")]
        [HttpPost]
        public Registros addRegistros(Registros registro)
        {
            db.Registros.Add(registro);
            db.SaveChanges();
            return registro;
        }

        [ActionName("getRegistros")]
        [HttpGet]
        public List<RegistrosDTO> getRegistros()
        {
            try
            {
                List<RegistrosDTO> registros = (from r in db.Registros
                                                select new RegistrosDTO
                                                {
                                                    ID = r.ID,
                                                    Fecha = r.Fecha,
                                                    Accion = r.Accion,
                                                    Contenido = r.Contenido,
                                                    NumeroSerie = r.NumeroSerie
                                                }).ToList();
                return registros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
