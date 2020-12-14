using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Resumen_Denuncia
{
    /// <summary>
    /// Detalle_Resumen_Denuncia table
    /// </summary>
    public class Detalle_Resumen_Denuncia: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Ofendido { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public bool? Generado { get; set; }
        public DateTime? Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }

    }
	
	public class Detalle_Resumen_Denuncia_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Ofendido { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public bool? Generado { get; set; }
        public DateTime? Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }

    }


}

