using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Historial_de_Emergencia_CC
{
    /// <summary>
    /// Detalle_de_Historial_de_Emergencia_CC table
    /// </summary>
    public class Detalle_de_Historial_de_Emergencia_CC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Estatus { get; set; }
        public string Comentarios { get; set; }
        public string Usuario_que_registra { get; set; }

        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }

    }
	
	public class Detalle_de_Historial_de_Emergencia_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Estatus { get; set; }
        public string Comentarios { get; set; }
        public string Usuario_que_registra { get; set; }

		        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }

    }


}

