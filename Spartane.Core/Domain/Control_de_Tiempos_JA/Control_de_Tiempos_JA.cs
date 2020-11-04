using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Control_de_Tiempos_JA
{
    /// <summary>
    /// Control_de_Tiempos_JA table
    /// </summary>
    public class Control_de_Tiempos_JA: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Numero_de_Expediente { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }


    }
	
	public class Control_de_Tiempos_JA_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Numero_de_Expediente { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }

		
    }


}

