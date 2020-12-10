using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Proceso_PenalModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Imputado { get; set; }
        public string ImputadoNombre_Completo_Detenido { get; set; }
        public short? Reclasificacion_Juridica { get; set; }
        public string Reclasificacion_JuridicaDescripcion { get; set; }
        public int? Plazo_Constitucional { get; set; }
        public string Plazo_ConstitucionalDescripcion { get; set; }
        public string Fecha_Continuacion_Audiencia { get; set; }
        public string Hora_Continuacion_Audiencia { get; set; }
        public int? Vinculacion { get; set; }
        public string VinculacionDescripcion { get; set; }
        public int? Resultado_No_Vinculacion { get; set; }
        public string Resultado_No_VinculacionDescripcion { get; set; }
        public int? Resultado_Vinculacion { get; set; }
        public string Resultado_VinculacionDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? plazo_investigacion_complementaria { get; set; }
        public int? Resultado_de_Investigacion_Complementari { get; set; }
        public string Resultado_de_Investigacion_ComplementariDescripcion { get; set; }
        public string fecha_investigacion_complementaria { get; set; }
        public string hora_investigacion_complementaria { get; set; }
        public string Nombre_del_Juez_de_Control { get; set; }
        public string Fecha_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public string Hora_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public string Fecha_de_Audiencia_Intermedia { get; set; }
        public string Hora_de_Audiencia_Intermedia { get; set; }
        public short? Acusador_Coadyudante { get; set; }
        public string Acusador_CoadyudanteDescripcion { get; set; }
        public short? cumplio_descubrimiento_probatorio { get; set; }
        public string cumplio_descubrimiento_probatorioDescripcion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public short? Acuerdos_Probatorios { get; set; }
        public string Acuerdos_ProbatoriosDescripcion { get; set; }
        public string acuerdos_probatorios_cuales_fueron { get; set; }
        public int? Resultado { get; set; }
        public string ResultadoDescripcion { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Tribunal_de_EnjuiciamientoDescripcion { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Colegiado { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public string Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Fallo_del_Tribunal { get; set; }
        public string Fallo_del_TribunalDescripcion { get; set; }
        public string pruebas_a_desahogar { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Plazo_meses { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public string Tipo_de_SentenciaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? cuantia_de_pena_anios { get; set; }
        [Range(0, 9999999999)]
        public short? cuantia_de_pena_meses { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_la_Reparacion_del_Dano { get; set; }

    }
	
	public class Proceso_Penal_Fase_ComplementariaModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Imputado { get; set; }
        public string ImputadoNombre_Completo_Detenido { get; set; }
        public short? Reclasificacion_Juridica { get; set; }
        public string Reclasificacion_JuridicaDescripcion { get; set; }
        public int? Plazo_Constitucional { get; set; }
        public string Plazo_ConstitucionalDescripcion { get; set; }
        public string Fecha_Continuacion_Audiencia { get; set; }
        public string Hora_Continuacion_Audiencia { get; set; }
        public int? Vinculacion { get; set; }
        public string VinculacionDescripcion { get; set; }
        public int? Resultado_No_Vinculacion { get; set; }
        public string Resultado_No_VinculacionDescripcion { get; set; }
        public int? Resultado_Vinculacion { get; set; }
        public string Resultado_VinculacionDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? plazo_investigacion_complementaria { get; set; }
        public int? Resultado_de_Investigacion_Complementari { get; set; }
        public string Resultado_de_Investigacion_ComplementariDescripcion { get; set; }
        public string fecha_investigacion_complementaria { get; set; }
        public string hora_investigacion_complementaria { get; set; }

    }

	public class Proceso_Penal_Fase_EscritaModel
    {
        [Required]
        public int Folio { get; set; }
        public string Nombre_del_Juez_de_Control { get; set; }
        public string Fecha_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public string Hora_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public string Fecha_de_Audiencia_Intermedia { get; set; }
        public string Hora_de_Audiencia_Intermedia { get; set; }
        public short? Acusador_Coadyudante { get; set; }
        public string Acusador_CoadyudanteDescripcion { get; set; }
        public short? cumplio_descubrimiento_probatorio { get; set; }
        public string cumplio_descubrimiento_probatorioDescripcion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

    }

	public class Proceso_Penal_Audiencia_IntermediaModel
    {
        [Required]
        public int Folio { get; set; }
        public short? Acuerdos_Probatorios { get; set; }
        public string Acuerdos_ProbatoriosDescripcion { get; set; }
        public string acuerdos_probatorios_cuales_fueron { get; set; }
        public int? Resultado { get; set; }
        public string ResultadoDescripcion { get; set; }

    }

	public class Proceso_Penal_Juicio_OralModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Tribunal_de_EnjuiciamientoDescripcion { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Colegiado { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public string Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Fallo_del_Tribunal { get; set; }
        public string Fallo_del_TribunalDescripcion { get; set; }
        public string pruebas_a_desahogar { get; set; }

    }

	public class Proceso_Penal_ResolucionModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Plazo_meses { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public string Tipo_de_SentenciaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? cuantia_de_pena_anios { get; set; }
        [Range(0, 9999999999)]
        public short? cuantia_de_pena_meses { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_la_Reparacion_del_Dano { get; set; }

    }


}

