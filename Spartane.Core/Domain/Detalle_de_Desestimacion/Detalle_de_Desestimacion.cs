using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Causas_de_Interrupcion;
using Spartane.Core.Domain.A_Tiempo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Desestimacion
{
    /// <summary>
    /// Detalle_de_Desestimacion table
    /// </summary>
    public class Detalle_de_Desestimacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Nombre_Completo { get; set; }
        public short? Causal_de_Interrupcion { get; set; }
        public int? Causa_de_Interrupcion { get; set; }
        public short? Datos_Insuficientes { get; set; }
        public string Actualizacion_de_Sobreseimiento { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Nombre_Completo")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Nombre_Completo_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Causal_de_Interrupcion")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Causal_de_Interrupcion_A_Tiempo { get; set; }
        [ForeignKey("Causa_de_Interrupcion")]
        public virtual Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion Causa_de_Interrupcion_Causas_de_Interrupcion { get; set; }
        [ForeignKey("Datos_Insuficientes")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Datos_Insuficientes_A_Tiempo { get; set; }

    }
	
	public class Detalle_de_Desestimacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Nombre_Completo { get; set; }
        public short? Causal_de_Interrupcion { get; set; }
        public int? Causa_de_Interrupcion { get; set; }
        public short? Datos_Insuficientes { get; set; }
        public string Actualizacion_de_Sobreseimiento { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Nombre_Completo")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Nombre_Completo_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Causal_de_Interrupcion")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Causal_de_Interrupcion_A_Tiempo { get; set; }
        [ForeignKey("Causa_de_Interrupcion")]
        public virtual Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion Causa_de_Interrupcion_Causas_de_Interrupcion { get; set; }
        [ForeignKey("Datos_Insuficientes")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Datos_Insuficientes_A_Tiempo { get; set; }

    }


}

