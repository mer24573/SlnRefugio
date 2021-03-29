using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interfaces
{
    interface IMascota
    {
        DataSet Listar();
        bool Agregar(MascotaE mascota);
        bool Actualizar(MascotaE mascota);
    }
}
