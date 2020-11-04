using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Bitacora_de_Usuarios
{
    /// <summary>
    /// Bitacora_de_Usuarios table
    /// </summary>
    public class Bitacora_de_Usuarios: BaseEntity
    {
        public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        public int? Usuario { get; set; }
        public short? ID_de_Huella { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }


    }
	
	public class Bitacora_de_Usuarios_Datos_Generales
    {
                public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        public int? Usuario { get; set; }
        public short? ID_de_Huella { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }

		
    }


}

