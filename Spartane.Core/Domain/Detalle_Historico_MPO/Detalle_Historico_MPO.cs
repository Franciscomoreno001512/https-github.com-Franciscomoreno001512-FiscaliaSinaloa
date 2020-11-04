using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Historico_MPO
{
    /// <summary>
    /// Detalle_Historico_MPO table
    /// </summary>
    public class Detalle_Historico_MPO: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Estatus { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }

    }
	
	public class Detalle_Historico_MPO_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Estatus { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }

    }


}

