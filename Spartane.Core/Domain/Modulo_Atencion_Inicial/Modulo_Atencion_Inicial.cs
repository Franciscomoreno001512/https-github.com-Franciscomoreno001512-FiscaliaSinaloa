using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Asignacion_de_Turnos;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Estatus;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Tipo_de_Atencion;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using Spartane.Core.Domain.Motivo_Finalizacion_Turno;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Documento_Extraviado;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Zona;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Modulo_Atencion_Inicial
{
    /// <summary>
    /// Modulo_Atencion_Inicial table
    /// </summary>
    public class Modulo_Atencion_Inicial: BaseEntity
    {
        public int Clave { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Turno_Asignado { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Unidad { get; set; }
        public int? Municipio { get; set; }
        public int? Region { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string NUAT { get; set; }
        public string CDI { get; set; }
        public string Expedientes_Relacionados { get; set; }
        public int? Estatus { get; set; }
        public DateTime? Generar_Cita { get; set; }
        public string Nombres_del_Remitente { get; set; }
        public string Apellido_Paterno_del_Remitente { get; set; }
        public string Apellido_Materno_del_Remitente { get; set; }
        public DateTime? Fecha_en_que_llega_para_validacion { get; set; }
        public int? Delegacion { get; set; }
        public int? Agencia { get; set; }
        public int? Ministerio_Publico_en_Turno { get; set; }
        public int? Solicitud_de_Denuncia_Ciudadana { get; set; }
        public string Nombres_turno { get; set; }
        public string Apellido_Paterno_turno { get; set; }
        public string Apellido_Materno_turno { get; set; }
        public int? Sexo_turno { get; set; }
        public int? Edad_turno { get; set; }
        public int? Tipo_de_Atencion_turno { get; set; }
        public int? Tipo_de_Identificacion_turno { get; set; }
        public string Numero_de_Identificacion_turno { get; set; }
        public bool? Urgencia_turno { get; set; }
        public int? Tipo_de_Urgencia_turno { get; set; }
        public int? Motivo_Finalizacion_Turno { get; set; }
        public string Observaciones_turno { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public int? Orientador { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos { get; set; }
        public int? Estado_de_los_Hechos { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exrterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Referencia_hechos { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Documento_Extraviado_hechos { get; set; }
        public int? Tipo_de_Documento_Extraviado { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public int? Zona_de_los_Hechos { get; set; }
        public string Turno { get; set; }
        public bool? Cerrar { get; set; }
        public DateTime? Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }

        [ForeignKey("Turno_Asignado")]
        public virtual Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos Turno_Asignado_Asignacion_de_Turnos { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Estatus { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }
        [ForeignKey("Ministerio_Publico_en_Turno")]
        public virtual Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema { get; set; }
        [ForeignKey("Solicitud_de_Denuncia_Ciudadana")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana { get; set; }
        [ForeignKey("Sexo_turno")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_turno_Genero { get; set; }
        [ForeignKey("Tipo_de_Atencion_turno")]
        public virtual Spartane.Core.Domain.Tipo_de_Atencion.Tipo_de_Atencion Tipo_de_Atencion_turno_Tipo_de_Atencion { get; set; }
        [ForeignKey("Tipo_de_Identificacion_turno")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_turno_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Tipo_de_Urgencia_turno")]
        public virtual Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia Tipo_de_Urgencia_turno_Tipo_de_Urgencia { get; set; }
        [ForeignKey("Motivo_Finalizacion_Turno")]
        public virtual Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno { get; set; }
        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Orientador_Spartan_User { get; set; }
        [ForeignKey("Pais_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_los_Hechos_Pais { get; set; }
        [ForeignKey("Estado_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_los_Hechos_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_Colonia { get; set; }
        [ForeignKey("Tipo_de_Documento_Extraviado")]
        public virtual Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado Tipo_de_Documento_Extraviado_Documento_Extraviado { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
        [ForeignKey("Zona_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona_de_los_Hechos_Zona { get; set; }

    }
	
	public class Modulo_Atencion_Inicial_Datos_del_Caso
    {
                public int Clave { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Turno_Asignado { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Unidad { get; set; }
        public int? Municipio { get; set; }
        public int? Region { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string NUAT { get; set; }
        public string CDI { get; set; }
        public string Expedientes_Relacionados { get; set; }
        public int? Estatus { get; set; }
        public DateTime? Generar_Cita { get; set; }
        public string Nombres_del_Remitente { get; set; }
        public string Apellido_Paterno_del_Remitente { get; set; }
        public string Apellido_Materno_del_Remitente { get; set; }
        public DateTime? Fecha_en_que_llega_para_validacion { get; set; }
        public int? Delegacion { get; set; }
        public int? Agencia { get; set; }
        public int? Ministerio_Publico_en_Turno { get; set; }
        public int? Solicitud_de_Denuncia_Ciudadana { get; set; }

		        [ForeignKey("Turno_Asignado")]
        public virtual Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos Turno_Asignado_Asignacion_de_Turnos { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Estatus { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }
        [ForeignKey("Ministerio_Publico_en_Turno")]
        public virtual Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema { get; set; }
        [ForeignKey("Solicitud_de_Denuncia_Ciudadana")]
        public virtual Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana { get; set; }

    }

	public class Modulo_Atencion_Inicial_Informacion_de_Turno
    {
                public int Clave { get; set; }
        public string Nombres_turno { get; set; }
        public string Apellido_Paterno_turno { get; set; }
        public string Apellido_Materno_turno { get; set; }
        public int? Sexo_turno { get; set; }
        public int? Edad_turno { get; set; }
        public int? Tipo_de_Atencion_turno { get; set; }
        public int? Tipo_de_Identificacion_turno { get; set; }
        public string Numero_de_Identificacion_turno { get; set; }
        public bool? Urgencia_turno { get; set; }
        public int? Tipo_de_Urgencia_turno { get; set; }
        public int? Motivo_Finalizacion_Turno { get; set; }
        public string Observaciones_turno { get; set; }

		        [ForeignKey("Sexo_turno")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_turno_Genero { get; set; }
        [ForeignKey("Tipo_de_Atencion_turno")]
        public virtual Spartane.Core.Domain.Tipo_de_Atencion.Tipo_de_Atencion Tipo_de_Atencion_turno_Tipo_de_Atencion { get; set; }
        [ForeignKey("Tipo_de_Identificacion_turno")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_turno_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Tipo_de_Urgencia_turno")]
        public virtual Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia Tipo_de_Urgencia_turno_Tipo_de_Urgencia { get; set; }
        [ForeignKey("Motivo_Finalizacion_Turno")]
        public virtual Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno { get; set; }

    }

	public class Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO
    {
                public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public int? Orientador { get; set; }
        public DateTime? Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos { get; set; }
        public int? Estado_de_los_Hechos { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exrterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Referencia_hechos { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Documento_Extraviado_hechos { get; set; }
        public int? Tipo_de_Documento_Extraviado { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public int? Zona_de_los_Hechos { get; set; }
        public string Turno { get; set; }

		        [ForeignKey("Prioridad_del_Hecho")]
        public virtual Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho Prioridad_del_Hecho_Prioridad_del_Hecho { get; set; }
        [ForeignKey("Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Orientador_Spartan_User { get; set; }
        [ForeignKey("Pais_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Pais.Pais Pais_de_los_Hechos_Pais { get; set; }
        [ForeignKey("Estado_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_los_Hechos_Estado { get; set; }
        [ForeignKey("Municipio_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_los_Hechos_Municipio { get; set; }
        [ForeignKey("Poblacion")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Poblacion_Colonia { get; set; }
        [ForeignKey("Colonia_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_los_Hechos_Colonia { get; set; }
        [ForeignKey("Tipo_de_Documento_Extraviado")]
        public virtual Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado Tipo_de_Documento_Extraviado_Documento_Extraviado { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Hecho")]
        public virtual Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo Tipo_de_Lugar_del_Hecho_Lugar_Tipo { get; set; }
        [ForeignKey("Zona_de_los_Hechos")]
        public virtual Spartane.Core.Domain.Zona.Zona Zona_de_los_Hechos_Zona { get; set; }

    }

	public class Modulo_Atencion_Inicial_Bitacora_de_Coincidencias
    {
                public int Clave { get; set; }

		
    }

	public class Modulo_Atencion_Inicial_Cierre
    {
                public int Clave { get; set; }
        public bool? Cerrar { get; set; }
        public DateTime? Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }

		
    }

	public class Modulo_Atencion_Inicial_Historial_de_movimientos
    {
                public int Clave { get; set; }

		
    }


}

