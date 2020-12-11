using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion
{
    /// <summary>
    /// Marca_de_Equipo_de_Comunicacion table
    /// </summary>
    public class Marca_de_Equipo_de_Comunicacion: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_de_Equipo { get; set; }

        [ForeignKey("Tipo_de_Equipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion Tipo_de_Equipo_Tipo_de_Equipo_de_Comunicacion { get; set; }

    }
	
	public class Marca_de_Equipo_de_Comunicacion_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_de_Equipo { get; set; }

		        [ForeignKey("Tipo_de_Equipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion Tipo_de_Equipo_Tipo_de_Equipo_de_Comunicacion { get; set; }

    }


}

