using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana
{
    /// <summary>
    /// Generador_Solicitud_Denuncia_Ciudadana table
    /// </summary>
    public class Generador_Solicitud_Denuncia_Ciudadana: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Denuncia_Ultimo_Generado { get; set; }


    }
	
	public class Generador_Solicitud_Denuncia_Ciudadana_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Denuncia_Ultimo_Generado { get; set; }

		
    }


}

