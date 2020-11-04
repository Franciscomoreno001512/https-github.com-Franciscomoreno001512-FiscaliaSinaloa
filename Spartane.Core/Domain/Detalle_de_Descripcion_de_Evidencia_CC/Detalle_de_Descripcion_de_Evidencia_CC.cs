using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Descripcion_de_Evidencia_CC
{
    /// <summary>
    /// Detalle_de_Descripcion_de_Evidencia_CC table
    /// </summary>
    public class Detalle_de_Descripcion_de_Evidencia_CC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadena_y_Custodia { get; set; }
        public int? Numero_de_Evidencia { get; set; }
        public string Descripcion_de_la_Evidencia { get; set; }
        public string Origen { get; set; }
        public string Descripcion { get; set; }
        public int? Examen_Solicitado { get; set; }
        public string Codigo_de_Barras { get; set; }
        public string Archivo_de_Foto { get; set; }

        [ForeignKey("Cadena_y_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_y_Custodia_Cadena_de_Custodia { get; set; }

    }
	
	public class Detalle_de_Descripcion_de_Evidencia_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadena_y_Custodia { get; set; }
        public int? Numero_de_Evidencia { get; set; }
        public string Descripcion_de_la_Evidencia { get; set; }
        public string Origen { get; set; }
        public string Descripcion { get; set; }
        public int? Examen_Solicitado { get; set; }
        public string Codigo_de_Barras { get; set; }
        public string Archivo_de_Foto { get; set; }

		        [ForeignKey("Cadena_y_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_y_Custodia_Cadena_de_Custodia { get; set; }

    }


}

