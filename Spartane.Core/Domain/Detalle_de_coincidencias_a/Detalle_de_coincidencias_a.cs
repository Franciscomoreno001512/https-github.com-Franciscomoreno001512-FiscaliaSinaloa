using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_coincidencias_a
{
    /// <summary>
    /// Detalle_de_coincidencias_a table
    /// </summary>
    public class Detalle_de_coincidencias_a: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string NUAT { get; set; }
        public string Fuente_de_Origen { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }

    }
	
	public class Detalle_de_coincidencias_a_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string NUAT { get; set; }
        public string Fuente_de_Origen { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }

    }


}

