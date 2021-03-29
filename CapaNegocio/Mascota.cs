using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Mascota : Interfaces.IMascota
    {
        private Datos datos = new DatosSQL();

        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Actualizar(MascotaE mascota)
        {
            try
            {
                DataRow fila = datos.TraerDataRow("spActualizarMascota	", mascota.id, mascota.nombre, mascota.descripcion, mascota.etapa_vida,
                               mascota.sexo, mascota.especie, mascota.fecha_nac, mascota.raza, mascota.disponible, mascota.fecha_registro);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return true;
                else return false;
            }
            catch (Exception ex)
            {

                mensaje = "Error: " + ex.Message;
                return false;
            }
        }

        public bool Agregar(MascotaE mascota)
        {
            try
            {
                DataRow fila = datos.TraerDataRow("spAgregarMascota", mascota.id, mascota.nombre, mascota.descripcion, mascota.etapa_vida,
                               mascota.sexo, mascota.especie, mascota.fecha_nac, mascota.raza, mascota.disponible, mascota.fecha_registro);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return true;
                else return false;
            }
            catch (Exception ex)
            {

                mensaje = "Error: " + ex.Message;
                return false;
            }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarMascotas");
        }
    }
}
