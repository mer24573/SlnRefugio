using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract]
     public class MascotaE
    {

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string descripcion { get; set; }

        [DataMember]
        public string etapa_vida { get; set; }

        [DataMember]
        public string sexo { get; set; }

        [DataMember]
        public string especie { get; set; }

        [DataMember]
        public DateTime fecha_nac { get; set; }
        [DataMember]
        public string raza { get; set; }

        [DataMember]
        public int disponible { get; set; }

        [DataMember]
        public  DateTime fecha_registro { get; set; }

    }
}
