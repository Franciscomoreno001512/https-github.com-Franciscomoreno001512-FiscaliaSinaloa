using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Proceso_PenalGridModel
    {
        public int Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Imputado { get; set; }
        public string ImputadoNombre_Completo_del_Tutor { get; set; }
        public short? Reclasificacion_Juridica { get; set; }
        public string Reclasificacion_JuridicaDescripcion { get; set; }
        public int? Plazo_Constitucional { get; set; }
        public string Plazo_ConstitucionalDescripcion { get; set; }
        public int? Vinculacion { get; set; }
        public string VinculacionDescripcion { get; set; }
        public int? Resultado_No_Vinculacion { get; set; }
        public string Resultado_No_VinculacionDescripcion { get; set; }
        public int? Resultado_Vinculacion { get; set; }
        public string Resultado_VinculacionDescripcion { get; set; }
        public int? plazo_investigacion_complementaria { get; set; }
        public string plazo_investigacion_complementariaDescripcion { get; set; }
        public int? fecha_investigacion_complementaria { get; set; }
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
        public short? Plazo_meses { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public string Tipo_de_SentenciaDescripcion { get; set; }
        public short? cuantia_de_pena_anios { get; set; }
        public short? cuantia_de_pena_meses { get; set; }
        public decimal? Monto_de_la_Reparacion_del_Dano { get; set; }
        
    }
}

