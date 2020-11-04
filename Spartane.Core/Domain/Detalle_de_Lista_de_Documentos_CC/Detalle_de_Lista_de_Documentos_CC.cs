using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Lista_de_Documentos_CC
{
    /// <summary>
    /// Detalle_de_Lista_de_Documentos_CC table
    /// </summary>
    public class Detalle_de_Lista_de_Documentos_CC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadena_y_Custodia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Nombre_del_Archivo { get; set; }
        public short? Archivo { get; set; }

        [ForeignKey("Cadena_y_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_y_Custodia_Cadena_de_Custodia { get; set; }

    }
	
	public class Detalle_de_Lista_de_Documentos_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadena_y_Custodia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Nombre_del_Archivo { get; set; }
        public short? Archivo { get; set; }

		        [ForeignKey("Cadena_y_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_y_Custodia_Cadena_de_Custodia { get; set; }

    }


}

