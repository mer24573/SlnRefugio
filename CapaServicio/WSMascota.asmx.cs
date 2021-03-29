using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using CapaEntidad;
using System.Data;


namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WSMascota
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSMascota : System.Web.Services.WebService
    {
        [WebMethod(Description = "Agregar un mascota")]
        public string[] Agregar(int Id ,string Nombre, string Descripcion, string etapa_vida,
                               string sexo, string especie, DateTime fecha_nac, string raza,int disponible, DateTime fecha_registro)
        {
            // Codigo a implementar
            MascotaE mascotaE = new MascotaE();
            mascotaE.id = Id;
            mascotaE.nombre = Nombre;
            mascotaE.descripcion= Descripcion;
            mascotaE.etapa_vida = etapa_vida;
            mascotaE.sexo = sexo;
            mascotaE.especie = especie;
            mascotaE.fecha_nac = fecha_nac;
            mascotaE.raza = raza;
            mascotaE.disponible = disponible;
            mascotaE.fecha_registro = fecha_registro;
            Mascota mascota = new Mascota();
            bool codError = mascota.Agregar(mascotaE);
            string mensaje = mascota.Mensaje;
            string[] respuesta = { codError.ToString(), mensaje };
            return respuesta;
        }

        [WebMethod(Description = "Listar  mascotas")]
        public DataSet Listar()
        {
            Mascota mascota = new Mascota();
            return mascota.Listar();
        }

        [WebMethod(Description = "Actualizar un mascota")]
        public string[] Actualizar(int Id, string Nombre, string Descripcion, string etapa_vida,
                               string sexo, string especie, DateTime fecha_nac, string raza, int disponible, DateTime fecha_registro)
        {
            // Codigo a implementar
            MascotaE mascotaE = new MascotaE();
            mascotaE.id = Id;
            mascotaE.nombre = Nombre;
            mascotaE.descripcion = Descripcion;
            mascotaE.etapa_vida = etapa_vida;
            mascotaE.sexo = sexo;
            mascotaE.especie = especie;
            mascotaE.fecha_nac = fecha_nac;
            mascotaE.raza = raza;
            mascotaE.disponible = disponible;
            mascotaE.fecha_registro = fecha_registro;
            Mascota mascota = new Mascota();
            bool codError = mascota.Actualizar(mascotaE);
            string mensaje = mascota.Mensaje;
            string[] respuesta = { codError.ToString(), mensaje };
            return respuesta;
        }



    }
}


