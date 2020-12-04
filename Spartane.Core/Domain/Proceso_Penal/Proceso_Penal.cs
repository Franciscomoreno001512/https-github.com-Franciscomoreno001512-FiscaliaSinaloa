using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Plazo_Constitucional;
using Spartane.Core.Domain.Vinculacion_a_Proceso;
using Spartane.Core.Domain.Continuacion_de_Proceso;
using Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso;
using Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia;
using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using Spartane.Core.Domain.Sentencia;
using Spartane.Core.Domain.Resolucion;
using Spartane.Core.Domain.Sentencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Proceso_Penal
{
    /// <summary>
    /// Proceso_Penal table
    /// </summary>
    public class Proceso_Penal: BaseEntity
    {
        public int Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Imputado { get; set; }
        public short? Reclasificacion_Juridica { get; set; }
        public int? Plazo_Constitucional { get; set; }
        public int? Vinculacion { get; set; }
        public int? Resultado_No_Vinculacion { get; set; }
        public int? Resultado_Vinculacion { get; set; }
        public int? plazo_investigacion_complementaria { get; set; }
        public int? fecha_investigacion_complementaria { get; set; }
        public string hora_investigacion_complementaria { get; set; }
        public string Nombre_del_Juez_de_Control { get; set; }
        public DateTime? Fecha_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public string Hora_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public DateTime? Fecha_de_Audiencia_Intermedia { get; set; }
        public string Hora_de_Audiencia_Intermedia { get; set; }
        public short? Acusador_Coadyudante { get; set; }
        public short? cumplio_descubrimiento_probatorio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public short? Acuerdos_Probatorios { get; set; }
        public string acuerdos_probatorios_cuales_fueron { get; set; }
        public int? Resultado { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Colegiado { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public DateTime? Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Fallo_del_Tribunal { get; set; }
        public string pruebas_a_desahogar { get; set; }
        public int? Resolucion { get; set; }
        public short? Plazo_meses { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public short? cuantia_de_pena_anios { get; set; }
        public short? cuantia_de_pena_meses { get; set; }
        public decimal? Monto_de_la_Reparacion_del_Dano { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Imputado_Detalle_de_Imputado { get; set; }
        [ForeignKey("Reclasificacion_Juridica")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Reclasificacion_Juridica_A_Tiempo { get; set; }
        [ForeignKey("Plazo_Constitucional")]
        public virtual Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional Plazo_Constitucional_Plazo_Constitucional { get; set; }
        [ForeignKey("Vinculacion")]
        public virtual Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso Vinculacion_Vinculacion_a_Proceso { get; set; }
        [ForeignKey("Resultado_No_Vinculacion")]
        public virtual Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso Resultado_No_Vinculacion_Continuacion_de_Proceso { get; set; }
        [ForeignKey("Resultado_Vinculacion")]
        public virtual Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso { get; set; }
        [ForeignKey("plazo_investigacion_complementaria")]
        public virtual Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria { get; set; }
        [ForeignKey("Acusador_Coadyudante")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acusador_Coadyudante_A_Tiempo { get; set; }
        [ForeignKey("cumplio_descubrimiento_probatorio")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo cumplio_descubrimiento_probatorio_A_Tiempo { get; set; }
        [ForeignKey("Acuerdos_Probatorios")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acuerdos_Probatorios_A_Tiempo { get; set; }
        [ForeignKey("Resultado")]
        public virtual Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia Resultado_Resultado_de_Audiencia_Intermedia { get; set; }
        [ForeignKey("Tribunal_de_Enjuiciamiento")]
        public virtual Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento { get; set; }
        [ForeignKey("Fallo_del_Tribunal")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Fallo_del_Tribunal_Sentencia { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Resolucion { get; set; }
        [ForeignKey("Tipo_de_Sentencia")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Tipo_de_Sentencia_Sentencia { get; set; }

    }
	
	public class Proceso_Penal_Fase_Complementaria
    {
                public int Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Imputado { get; set; }
        public short? Reclasificacion_Juridica { get; set; }
        public int? Plazo_Constitucional { get; set; }
        public int? Vinculacion { get; set; }
        public int? Resultado_No_Vinculacion { get; set; }
        public int? Resultado_Vinculacion { get; set; }
        public int? plazo_investigacion_complementaria { get; set; }
        public int? fecha_investigacion_complementaria { get; set; }
        public string hora_investigacion_complementaria { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Imputado_Detalle_de_Imputado { get; set; }
        [ForeignKey("Reclasificacion_Juridica")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Reclasificacion_Juridica_A_Tiempo { get; set; }
        [ForeignKey("Plazo_Constitucional")]
        public virtual Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional Plazo_Constitucional_Plazo_Constitucional { get; set; }
        [ForeignKey("Vinculacion")]
        public virtual Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso Vinculacion_Vinculacion_a_Proceso { get; set; }
        [ForeignKey("Resultado_No_Vinculacion")]
        public virtual Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso Resultado_No_Vinculacion_Continuacion_de_Proceso { get; set; }
        [ForeignKey("Resultado_Vinculacion")]
        public virtual Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso { get; set; }
        [ForeignKey("plazo_investigacion_complementaria")]
        public virtual Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria.Plazo_de_Investigacion_Complementaria plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria { get; set; }

    }

	public class Proceso_Penal_Fase_Escrita
    {
                public int Folio { get; set; }
        public string Nombre_del_Juez_de_Control { get; set; }
        public DateTime? Fecha_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public string Hora_de_Entrega_de_Escrito_de_Acusacion { get; set; }
        public DateTime? Fecha_de_Audiencia_Intermedia { get; set; }
        public string Hora_de_Audiencia_Intermedia { get; set; }
        public short? Acusador_Coadyudante { get; set; }
        public short? cumplio_descubrimiento_probatorio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }

		        [ForeignKey("Acusador_Coadyudante")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acusador_Coadyudante_A_Tiempo { get; set; }
        [ForeignKey("cumplio_descubrimiento_probatorio")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo cumplio_descubrimiento_probatorio_A_Tiempo { get; set; }

    }

	public class Proceso_Penal_Audiencia_Intermedia
    {
                public int Folio { get; set; }
        public short? Acuerdos_Probatorios { get; set; }
        public string acuerdos_probatorios_cuales_fueron { get; set; }
        public int? Resultado { get; set; }

		        [ForeignKey("Acuerdos_Probatorios")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acuerdos_Probatorios_A_Tiempo { get; set; }
        [ForeignKey("Resultado")]
        public virtual Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia Resultado_Resultado_de_Audiencia_Intermedia { get; set; }

    }

	public class Proceso_Penal_Juicio_Oral
    {
                public int Folio { get; set; }
        public int? Tribunal_de_Enjuiciamiento { get; set; }
        public string Nombre_del_Juez { get; set; }
        public string Juez_Colegiado { get; set; }
        public string Juez_Relator { get; set; }
        public string Juez_Vocal { get; set; }
        public DateTime? Fecha_de_Audiencia_de_Juicio { get; set; }
        public string Hora_de_Audiencia_de_Juicio { get; set; }
        public int? Fallo_del_Tribunal { get; set; }
        public string pruebas_a_desahogar { get; set; }

		        [ForeignKey("Tribunal_de_Enjuiciamiento")]
        public virtual Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento { get; set; }
        [ForeignKey("Fallo_del_Tribunal")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Fallo_del_Tribunal_Sentencia { get; set; }

    }

	public class Proceso_Penal_Resolucion
    {
                public int Folio { get; set; }
        public int? Resolucion { get; set; }
        public short? Plazo_meses { get; set; }
        public int? Tipo_de_Sentencia { get; set; }
        public short? cuantia_de_pena_anios { get; set; }
        public short? cuantia_de_pena_meses { get; set; }
        public decimal? Monto_de_la_Reparacion_del_Dano { get; set; }

		        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Resolucion { get; set; }
        [ForeignKey("Tipo_de_Sentencia")]
        public virtual Spartane.Core.Domain.Sentencia.Sentencia Tipo_de_Sentencia_Sentencia { get; set; }

    }


}

