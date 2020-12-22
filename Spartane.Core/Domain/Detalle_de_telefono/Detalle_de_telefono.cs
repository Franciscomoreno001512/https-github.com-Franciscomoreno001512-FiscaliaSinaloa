using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Tipo_de_Telefono;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_telefono
{
    /// <summary>
    /// Detalle_de_telefono table
    /// </summary>
    public class Detalle_de_telefono: BaseEntity
    {
        public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Tipo_de_Telefono { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }

        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Tipo_de_Telefono")]
        public virtual Spartane.Core.Domain.Tipo_de_Telefono.Tipo_de_Telefono Tipo_de_Telefono_Tipo_de_Telefono { get; set; }

    }
	
	public class Detalle_de_telefono_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public int? Tipo_de_Telefono { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }

		        [ForeignKey("Registro_de_Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Registro_de_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Tipo_de_Telefono")]
        public virtual Spartane.Core.Domain.Tipo_de_Telefono.Tipo_de_Telefono Tipo_de_Telefono_Tipo_de_Telefono { get; set; }

    }


}

