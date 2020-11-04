using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Rol_de_Diligencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Servicios_Periciales
{
    /// <summary>
    /// Servicios_Periciales table
    /// </summary>
    public class Servicios_Periciales: BaseEntity
    {
        public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }

        [ForeignKey("Rol_de_Donde_Proviene")]
        public virtual Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia Rol_de_Donde_Proviene_Rol_de_Diligencia { get; set; }

    }
	
	public class Servicios_Periciales_Datos_Generales
    {
                public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }

		        [ForeignKey("Rol_de_Donde_Proviene")]
        public virtual Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia Rol_de_Donde_Proviene_Rol_de_Diligencia { get; set; }

    }


}

