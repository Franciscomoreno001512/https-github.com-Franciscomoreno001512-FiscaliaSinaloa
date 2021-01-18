using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Resolucion_MASC
{
    /// <summary>
    /// Resolucion_MASC table
    /// </summary>
    public class Resolucion_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public bool? Rechazo { get; set; }
        public bool? Resolucion_para_Solicitud { get; set; }
        public bool? Resolucion_para_Procedimiento { get; set; }
        public string ClaveFiscalia { get; set; }


    }
	
	public class Resolucion_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public bool? Rechazo { get; set; }
        public bool? Resolucion_para_Solicitud { get; set; }
        public bool? Resolucion_para_Procedimiento { get; set; }
        public string ClaveFiscalia { get; set; }

		
    }


}

