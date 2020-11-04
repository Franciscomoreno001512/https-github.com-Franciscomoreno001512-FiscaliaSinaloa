using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Compareciente;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo
{
    /// <summary>
    /// Solicitud_de_Servicios_de_Apoyo table
    /// </summary>
    public class Solicitud_de_Servicios_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_del_Caso { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Clave_MR { get; set; }
        public int? Compareciente { get; set; }

        [ForeignKey("Folio_del_Caso")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Folio_del_Caso_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }

    }
	
	public class Solicitud_de_Servicios_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_del_Caso { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Clave_MR { get; set; }
        public int? Compareciente { get; set; }

		        [ForeignKey("Folio_del_Caso")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Folio_del_Caso_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }

    }


}

