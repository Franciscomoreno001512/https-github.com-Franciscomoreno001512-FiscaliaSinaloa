using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Estatus_Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Razon_de_Incumplimiento;
using Spartane.Core.Domain.Tipo_de_Conclusion_Anticipada;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Solicitud
{
    /// <summary>
    /// Solicitud table
    /// </summary>
    public class Solicitud: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Numero_de_Folio { get; set; }
        public int? Unidad_MASC { get; set; }
        public string Remitente { get; set; }
        public int? NUAT { get; set; }
        public int? Unidad { get; set; }
        public int? Municipio { get; set; }
        public int? Region { get; set; }
        public string NUC { get; set; }
        public string CDI { get; set; }
        public string Numero_de_Expediente { get; set; }
        public int? Estatus { get; set; }
        public DateTime? Fecha_en_que_llega_a_Coordinador { get; set; }
        public DateTime? Fecha_en_que_llega_a_Especialista { get; set; }
        public int? Agente_del_Ministerio_Publico_Orientador { get; set; }
        public int? Agente_del_Ministerio_Publico_Invest { get; set; }
        public int? Juez_de_Control { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public int? PaisH { get; set; }
        public int? EstadoH { get; set; }
        public int? MunicipioH { get; set; }
        public int? Poblacion { get; set; }
        public int? ColoniaH { get; set; }
        public string CalleH { get; set; }
        public string Numero_ExteriorH { get; set; }
        public string Numero_InteriorH { get; set; }
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }
        public int? Especialista_AsignadoA { get; set; }
        public bool? Asignar_Especialista_Automatico { get; set; }
        public string Razone { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public DateTime? Fecha_de_AsignacionA { get; set; }
        public string Hora_de_AsignacionA { get; set; }
        public DateTime? Fecha_de_Atencion_del_Especialista { get; set; }
        public string Hora_de_Atencion_del_Especialista { get; set; }
        public bool? Rechazar { get; set; }
        public string Motivo_de_Rechazo { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public int? Tipo_de_Conclusion_Anticipada { get; set; }
        public DateTime? Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Unidad_MASC")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_MASC_Unidad { get; set; }
        [ForeignKey("NUAT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial NUAT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud Estatus_Estatus_Solicitud { get; set; }
        [ForeignKey("Agente_del_Ministerio_Publico_Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Agente_del_Ministerio_Publico_Orientador_Spartan_User { get; set; }
        [ForeignKey("Agente_del_Ministerio_Publico_Invest")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Agente_del_Ministerio_Publico_Invest_Spartan_User { get; set; }
        [ForeignKey("Juez_de_Control")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Juez_de_Control_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
        [ForeignKey("PaisH")]
        public virtual Spartane.Core.Domain.Pais.Pais PaisH_Pais { get; set; }
        [ForeignKey("EstadoH")]
        public virtual Spartane.Core.Domain.Estado.Estado EstadoH_Estado { get; set; }
        [ForeignKey("MunicipioH")]
        public virtual Spartane.Core.Domain.Municipio.Municipio MunicipioH_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("ColoniaH")]
        public virtual Spartane.Core.Domain.Colonia.Colonia ColoniaH_Colonia { get; set; }
        [ForeignKey("Especialista_AsignadoA")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Especialista_AsignadoA_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Mecanismo")]
        public virtual Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno { get; set; }
        [ForeignKey("Acuerdo_Cumplido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acuerdo_Cumplido_A_Tiempo { get; set; }
        [ForeignKey("Razon_de_Incumplimiento")]
        public virtual Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento Razon_de_Incumplimiento_Razon_de_Incumplimiento { get; set; }
        [ForeignKey("Tipo_de_Conclusion_Anticipada")]
        public virtual Spartane.Core.Domain.Tipo_de_Conclusion_Anticipada.Tipo_de_Conclusion_Anticipada Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada { get; set; }

    }
	
	public class Solicitud_Solicitud
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Numero_de_Folio { get; set; }
        public int? Unidad_MASC { get; set; }
        public string Remitente { get; set; }
        public int? NUAT { get; set; }
        public int? Unidad { get; set; }
        public int? Municipio { get; set; }
        public int? Region { get; set; }
        public string NUC { get; set; }
        public string CDI { get; set; }
        public string Numero_de_Expediente { get; set; }
        public int? Estatus { get; set; }
        public DateTime? Fecha_en_que_llega_a_Coordinador { get; set; }
        public DateTime? Fecha_en_que_llega_a_Especialista { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Unidad_MASC")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_MASC_Unidad { get; set; }
        [ForeignKey("NUAT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial NUAT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud Estatus_Estatus_Solicitud { get; set; }

    }

	public class Solicitud_Control
    {
                public int Clave { get; set; }
        public int? Agente_del_Ministerio_Publico_Orientador { get; set; }
        public int? Agente_del_Ministerio_Publico_Invest { get; set; }
        public int? Juez_de_Control { get; set; }

		        [ForeignKey("Agente_del_Ministerio_Publico_Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Agente_del_Ministerio_Publico_Orientador_Spartan_User { get; set; }
        [ForeignKey("Agente_del_Ministerio_Publico_Invest")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Agente_del_Ministerio_Publico_Invest_Spartan_User { get; set; }
        [ForeignKey("Juez_de_Control")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Juez_de_Control_Spartan_User { get; set; }

    }

	public class Solicitud_Hechos
    {
                public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public int? PaisH { get; set; }
        public int? EstadoH { get; set; }
        public int? MunicipioH { get; set; }
        public int? Poblacion { get; set; }
        public int? ColoniaH { get; set; }
        public string CalleH { get; set; }
        public string Numero_ExteriorH { get; set; }
        public string Numero_InteriorH { get; set; }
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }

		        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
        [ForeignKey("PaisH")]
        public virtual Spartane.Core.Domain.Pais.Pais PaisH_Pais { get; set; }
        [ForeignKey("EstadoH")]
        public virtual Spartane.Core.Domain.Estado.Estado EstadoH_Estado { get; set; }
        [ForeignKey("MunicipioH")]
        public virtual Spartane.Core.Domain.Municipio.Municipio MunicipioH_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("ColoniaH")]
        public virtual Spartane.Core.Domain.Colonia.Colonia ColoniaH_Colonia { get; set; }

    }

	public class Solicitud_Asignacion
    {
                public int Clave { get; set; }
        public int? Especialista_AsignadoA { get; set; }
        public bool? Asignar_Especialista_Automatico { get; set; }
        public string Razone { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public DateTime? Fecha_de_AsignacionA { get; set; }
        public string Hora_de_AsignacionA { get; set; }
        public DateTime? Fecha_de_Atencion_del_Especialista { get; set; }
        public string Hora_de_Atencion_del_Especialista { get; set; }

		        [ForeignKey("Especialista_AsignadoA")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Especialista_AsignadoA_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Mecanismo")]
        public virtual Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno { get; set; }

    }

	public class Solicitud_Bitacora_de_Coincidencias
    {
                public int Clave { get; set; }

		
    }

	public class Solicitud_Cierre
    {
                public int Clave { get; set; }
        public bool? Rechazar { get; set; }
        public string Motivo_de_Rechazo { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public int? Tipo_de_Conclusion_Anticipada { get; set; }
        public DateTime? Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }

		        [ForeignKey("Acuerdo_Cumplido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acuerdo_Cumplido_A_Tiempo { get; set; }
        [ForeignKey("Razon_de_Incumplimiento")]
        public virtual Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento Razon_de_Incumplimiento_Razon_de_Incumplimiento { get; set; }
        [ForeignKey("Tipo_de_Conclusion_Anticipada")]
        public virtual Spartane.Core.Domain.Tipo_de_Conclusion_Anticipada.Tipo_de_Conclusion_Anticipada Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada { get; set; }

    }

	public class Solicitud_Historial_de_Movimientos
    {
                public int Clave { get; set; }

		
    }


}

