using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Historial_de_Conversacion
{
    /// <summary>
    /// Historial_de_Conversacion table
    /// </summary>
    public class Historial_de_Conversacion: BaseEntity
    {
        public int Folio { get; set; }
        public int? Remitente { get; set; }
        public int? Destinatario { get; set; }
        public DateTime? Fecha { get; set; }


    }
	
	public class Historial_de_Conversacion_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Remitente { get; set; }
        public int? Destinatario { get; set; }
        public DateTime? Fecha { get; set; }

		
    }


}

