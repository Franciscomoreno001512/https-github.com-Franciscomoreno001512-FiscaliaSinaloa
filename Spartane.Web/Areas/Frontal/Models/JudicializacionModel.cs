using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class JudicializacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionObservaciones { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string causa_o_cuadernillo { get; set; }
        public int? Fase_Actual { get; set; }
        public string Fase_ActualDescripcion { get; set; }
        public string Fecha_Actos { get; set; }
        public string Hora_Actos { get; set; }
        public string Observaciones_Actos { get; set; }
        public string Fecha_Genericos { get; set; }
        public string Hora_Genericos { get; set; }
        public string Observaciones_Genericos { get; set; }
        public string Fecha_Fase_Inicial { get; set; }
        public string Hora_Fase_Inicial { get; set; }
        public string Observaciones_Fase_Inicial { get; set; }
        public string Fecha_Fase_Intermedia { get; set; }
        public string Hora_Fase_Intermedia { get; set; }
        public string Observaciones_Fase_Intermedia { get; set; }
        public string Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Tribunal_de_EnjuiciamientoDescripcion { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Presidente { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public string medios_desahogo { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public string Tipo_de_SentenciaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Cuantia_de_Pena_Anos { get; set; }
        [Range(0, 9999999999)]
        public short? Cuantia_de_Pena_Meses { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_del_Dano { get; set; }
        public string Observaciones_Fase_Juicio_Oral { get; set; }
        public string Fecha_Fase_Salidas_Alternas { get; set; }
        public string Hora_Fase_Salidas_Alternas { get; set; }
        public string Observaciones_Fase_Salidas_Alternas { get; set; }
        public string Fecha_Fase_Sobreseimientos { get; set; }
        public string Hora_Fase_Sobreseimientos { get; set; }
        public string Observaciones_Fase_Sobreseimientos { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Judicializacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionObservaciones { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string causa_o_cuadernillo { get; set; }
        public int? Fase_Actual { get; set; }
        public string Fase_ActualDescripcion { get; set; }

    }

	public class Judicializacion_Actos_de_InvestigacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_Actos { get; set; }
        public string Hora_Actos { get; set; }
        public string Observaciones_Actos { get; set; }

    }

	public class Judicializacion_GenericosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_Genericos { get; set; }
        public string Hora_Genericos { get; set; }
        public string Observaciones_Genericos { get; set; }

    }

	public class Judicializacion_Fase_InicialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_Fase_Inicial { get; set; }
        public string Hora_Fase_Inicial { get; set; }
        public string Observaciones_Fase_Inicial { get; set; }

    }

	public class Judicializacion_Fase_IntermediaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_Fase_Intermedia { get; set; }
        public string Hora_Fase_Intermedia { get; set; }
        public string Observaciones_Fase_Intermedia { get; set; }

    }

	public class Judicializacion_Fase_Juicio_OralModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Tribunal_de_EnjuiciamientoDescripcion { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Presidente { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public string medios_desahogo { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public string Tipo_de_SentenciaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Cuantia_de_Pena_Anos { get; set; }
        [Range(0, 9999999999)]
        public short? Cuantia_de_Pena_Meses { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_del_Dano { get; set; }
        public string Observaciones_Fase_Juicio_Oral { get; set; }

    }

	public class Judicializacion_Salidas_AlternasModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_Fase_Salidas_Alternas { get; set; }
        public string Hora_Fase_Salidas_Alternas { get; set; }
        public string Observaciones_Fase_Salidas_Alternas { get; set; }

    }

	public class Judicializacion_SobreseimientosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_Fase_Sobreseimientos { get; set; }
        public string Hora_Fase_Sobreseimientos { get; set; }
        public string Observaciones_Fase_Sobreseimientos { get; set; }

    }

	public class Judicializacion_MovimientosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Observaciones { get; set; }

    }


}

