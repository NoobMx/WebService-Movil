using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppII.Controllers
{
    public class EmpleadoController : ApiController
    {
        ModelDB db = new ModelDB();

        [ActionName("addEmpleados")]
        [HttpPost]
        public Empleado addEmpleados(Empleado empleado)
        {
            db.Empleado.Add(empleado);
            db.SaveChanges();
            return empleado;
        }

        [ActionName("validarEmpleado")]
        [HttpPost]
        public EmpleadoDTO validarEmpleado(Empleado empleadoV)
        {
            try
            {
                EmpleadoDTO empleado = (from e in db.Empleado
                                        where e.Correo == empleadoV.Correo && e.Contraseña == empleadoV.Contraseña
                                        select new EmpleadoDTO
                                        {
                                            ID = e.ID,
                                            Nombre = e.Nombre,
                                            Correo = e.Correo,
                                            Contraseña = e.Contraseña,
                                            Estatus = e.Estatus,
                                            TipoEmpleadoID = e.TipoEmpleadoID,
                                            TipoEmpleado = e.TipoEmpleado.Rol
                                        }).FirstOrDefault();
                return empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [ActionName("editarEstatus")]
        [HttpPost]
        public bool editarEstatus(Empleado empleadoE)
        {
            try
            {
                Empleado empleado = db.Empleado.Find(empleadoE.ID);
                empleado.Estatus = empleadoE.Estatus;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
