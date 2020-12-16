using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Resolucion_MP;
using Spartane.Core.Domain.Tipo_de_Judicializacion;
using Spartane.Core.Domain.Fase_de_Judicializacion;
using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using Spartane.Core.Domain.Sentencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Judicializacion
{
    /// <summary>
    /// Judicializacion table
    /// </summary>
    public class Judicializacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Resolucion { get; set; }
        public int? Tipo { get; set; }
        public string causa_o_cuadernillo { get; set; }
        public int? Fase_Actual { get; set; }
        public DateTime? Fecha_Actos { get; set; }
        public string Hora_Actos { get; set; }
        public string Observaciones_Actos { get; set; }
        public DateTime? Fecha_Genericos { get; set; }
        public string Hora_Genericos { get; set; }
        public string Observaciones_Genericos { get; set; }
        public DateTime? Fecha_Fase_Inicial { get; set; }
        public string Hora_Fase_Inicial { get; set; }
        public string Observaciones_Fase_Inicial { get; set; }
        public DateTime? Fecha_Fase_Intermedia { get; set; }
        public string Hora_Fase_Intermedia { get; set; }
        public string Observaciones_Fase_Intermedia { get; set; }
        public DateTime? Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Presidente { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public string medios_desahogo { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public short? Cuantia_de_Pena_Anos { get; set; }
        public short? Cuantia_de_Pena_Meses { get; set; }
        public decimal? Monto_de_Reparacion_del_Dano { get; set; }
        public string Observaciones_Fase_Juicio_Oral { get; set; }
        public DateTime? Fecha_Fase_Salidas_Alternas { get; set; }
        public string Hora_Fase_Salidas_Alternas { get; set; }
        public string Observaciones_Fase_Salidas_Alternas { get; set; }
        public DateTime? Fecha_Fase_Sobreseimientos { get; set; }
        public string Hora_Fase_Sobreseimientos { get; set; }
        public string Observaciones_Fase_Sobreseimientos { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_MP.Resolucion_MP Resolucion_Resolucion_MP { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Judicializacion.Tipo_de_Judicializacion Tipo_Tipo_de_Judicializacion { get; set; }
        [ForeignKey("Fase_Actual")]
        public virtual Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion Fase_Actual_Fase_de_Judicializacion { get; set; }
        [ForeignKey("Tribunal_de_Enjuiciamiento")]
        public virtual Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento { get; set; }
        [ForeignKey("Tipo_de_Sentencia")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Tipo_de_Sentencia_Sentencia { get; set; }

    }
	
	public class Judicializacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Resolucion { get; set; }
        public int? Tipo { get; set; }
        public string causa_o_cuadernillo { get; set; }
        public int? Fase_Actual { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_MP.Resolucion_MP Resolucion_Resolucion_MP { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Judicializacion.Tipo_de_Judicializacion Tipo_Tipo_de_Judicializacion { get; set; }
        [ForeignKey("Fase_Actual")]
        public virtual Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion Fase_Actual_Fase_de_Judicializacion { get; set; }

    }

	public class Judicializacion_Actos_de_Investigacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_Actos { get; set; }
        public string Hora_Actos { get; set; }
        public string Observaciones_Actos { get; set; }

		
    }

	public class Judicializacion_Genericos
    {
                public int Clave { get; set; }
        public DateTime? Fecha_Genericos { get; set; }
        public string Hora_Genericos { get; set; }
        public string Observaciones_Genericos { get; set; }

		
    }

	public class Judicializacion_Fase_Inicial
    {
                public int Clave { get; set; }
        public DateTime? Fecha_Fase_Inicial { get; set; }
        public string Hora_Fase_Inicial { get; set; }
        public string Observaciones_Fase_Inicial { get; set; }

		
    }

	public class Judicializacion_Fase_Intermedia
    {
                public int Clave { get; set; }
        public DateTime? Fecha_Fase_Intermedia { get; set; }
        public string Hora_Fase_Intermedia { get; set; }
        public string Observaciones_Fase_Intermedia { get; set; }

		
    }

	public class Judicializacion_Fase_Juicio_Oral
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Presidente { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public string medios_desahogo { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public short? Cuantia_de_Pena_Anos { get; set; }
        public short? Cuantia_de_Pena_Meses { get; set; }
        public decimal? Monto_de_Reparacion_del_Dano { get; set; }
        public string Observaciones_Fase_Juicio_Oral { get; set; }

		        [ForeignKey("Tribunal_de_Enjuiciamiento")]
        public virtual Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento { get; set; }
        [ForeignKey("Tipo_de_Sentencia")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Tipo_de_Sentencia_Sentencia { get; set; }

    }

	public class Judicializacion_Salidas_Alternas
    {
                public int Clave { get; set; }
        public DateTime? Fecha_Fase_Salidas_Alternas { get; set; }
        public string Hora_Fase_Salidas_Alternas { get; set; }
        public string Observaciones_Fase_Salidas_Alternas { get; set; }

		
    }

	public class Judicializacion_Sobreseimientos
    {
                public int Clave { get; set; }
        public DateTime? Fecha_Fase_Sobreseimientos { get; set; }
        public string Hora_Fase_Sobreseimientos { get; set; }
        public string Observaciones_Fase_Sobreseimientos { get; set; }

		
    }

	public class Judicializacion_Movimientos
    {
                public int Clave { get; set; }
        public string Observaciones { get; set; }

		
    }


}

