using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Reporte_Principal
{
    /// <summary>
    /// Reporte_Principal table
    /// </summary>
    public class Reporte_Principal: BaseEntity
    {
        public int Clave { get; set; }
        public string Expediente { get; set; }
        public int? Total_de_Expedientes { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public int? Numero_de_Caso { get; set; }
        public int? Creciente { get; set; }
        public int? Folio { get; set; }


    }
	
	public class Reporte_Principal_Datos_Generales
    {
                public int Clave { get; set; }
        public string Expediente { get; set; }
        public int? Total_de_Expedientes { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public int? Numero_de_Caso { get; set; }
        public int? Creciente { get; set; }
        public int? Folio { get; set; }

		
    }


}

