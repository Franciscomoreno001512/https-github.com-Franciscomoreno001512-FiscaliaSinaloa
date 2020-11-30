using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Tipo_de_Audiencia;
using Spartane.Core.Domain.Audiencia;
using Spartane.Core.Domain.Resultado_de_Audiencia;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Audiencias_MP
{
    /// <summary>
    /// Audiencias_MP table
    /// </summary>
    public class Audiencias_MP: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Tipo_de_Audiencia { get; set; }
        public int? Audiencia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Observaciones { get; set; }
        public int? Resultado_de_Audiencia { get; set; }
        public bool? Asignar_MP_Litigacion { get; set; }
        public int? MP_Litigacion { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Tipo_de_Audiencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Audiencia.Tipo_de_Audiencia Tipo_de_Audiencia_Tipo_de_Audiencia { get; set; }
        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencia.Audiencia Audiencia_Audiencia { get; set; }
        [ForeignKey("Resultado_de_Audiencia")]
        public virtual Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia Resultado_de_Audiencia_Resultado_de_Audiencia { get; set; }
        [ForeignKey("MP_Litigacion")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User MP_Litigacion_Spartan_User { get; set; }

    }
	
	public class Audiencias_MP_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Tipo_de_Audiencia { get; set; }
        public int? Audiencia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Observaciones { get; set; }
        public int? Resultado_de_Audiencia { get; set; }
        public bool? Asignar_MP_Litigacion { get; set; }
        public int? MP_Litigacion { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Tipo_de_Audiencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Audiencia.Tipo_de_Audiencia Tipo_de_Audiencia_Tipo_de_Audiencia { get; set; }
        [ForeignKey("Audiencia")]
        public virtual Spartane.Core.Domain.Audiencia.Audiencia Audiencia_Audiencia { get; set; }
        [ForeignKey("Resultado_de_Audiencia")]
        public virtual Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia Resultado_de_Audiencia_Resultado_de_Audiencia { get; set; }
        [ForeignKey("MP_Litigacion")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User MP_Litigacion_Spartan_User { get; set; }

    }


}

