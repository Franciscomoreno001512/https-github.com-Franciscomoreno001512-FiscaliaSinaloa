using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Compareciente;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.Estatus_de_Solicitud_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;

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
        public string Responsable { get; set; }
        public int? Clave_MR { get; set; }
        public int? Compareciente { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public int? Usuario_que_Solicita { get; set; }
        public int? Origen { get; set; }
        public int? Numero_de_Expediente_AT { get; set; }
        public int? Numero_de_Expediente_MP { get; set; }
        public string NUAT { get; set; }
        public string Numero_de_Denuncia { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Solicitud { get; set; }
        public int? Ver_Documento { get; set; }
        public string Ver_Documento_URL { get; set; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }
        public DateTime? Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public int? Area_Asignada { get; set; }
        public int? SubArea_Asignada { get; set; }
        public string Observaciones_Recepcion { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public int? Tipo_de_Asignacion { get; set; }
        public int? Responsable_Asignado { get; set; }
        public string Observaciones_Asignacion { get; set; }
        public DateTime? Fecha_de_Contestacion { get; set; }
        public string Hora_de_Contestacion { get; set; }
        public int? Usuario_que_contesta { get; set; }
        public int? Dictamen { get; set; }
        public bool? Enviar_Contestacion { get; set; }
        public int? Archivo { get; set; }
        public string Observaciones_Contestacion { get; set; }
        public DateTime? Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public short? Resultado_de_Autorizacion { get; set; }
        public string Motivo_de_Rechazo { get; set; }
        public string Observaciones_Autorizacion { get; set; }

        [ForeignKey("Folio_del_Caso")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Folio_del_Caso_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }
        [ForeignKey("Usuario_que_Solicita")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Solicita_Spartan_User { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Numero_de_Expediente_AT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Numero_de_Expediente_AT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Numero_de_Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Numero_de_Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Documento.Documento Solicitud_Documento { get; set; }
        [ForeignKey("Ver_Documento")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Ver_Documento_Spartane_File { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Solicitud_de_Apoyo.Estatus_de_Solicitud_de_Apoyo Estatus_Estatus_de_Solicitud_de_Apoyo { get; set; }
        [ForeignKey("Usuario_que_Recibe")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Recibe_Spartan_User { get; set; }
        [ForeignKey("Area_Asignada")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Asignada_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea_Asignada")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_Asignada_SubArea_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("Usuario_que_Asigna")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Asigna_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Asignacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo { get; set; }
        [ForeignKey("Responsable_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Responsable_Asignado_Spartan_User { get; set; }
        [ForeignKey("Usuario_que_contesta")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_contesta_Spartan_User { get; set; }
        [ForeignKey("Dictamen")]
        public virtual Spartane.Core.Domain.Documento.Documento Dictamen_Documento { get; set; }
        [ForeignKey("Usuario_que_Revisa")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Revisa_Spartan_User { get; set; }
        [ForeignKey("Resultado_de_Autorizacion")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision Resultado_de_Autorizacion_Resultado_de_Revision { get; set; }

    }
	
	public class Solicitud_de_Servicios_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_del_Caso { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Responsable { get; set; }
        public int? Clave_MR { get; set; }
        public int? Compareciente { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public int? Usuario_que_Solicita { get; set; }
        public int? Origen { get; set; }
        public int? Numero_de_Expediente_AT { get; set; }
        public int? Numero_de_Expediente_MP { get; set; }
        public string NUAT { get; set; }
        public string Numero_de_Denuncia { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Solicitud { get; set; }
        public int? Ver_Documento { get; set; }
        public string Ver_Documento_URL { get; set; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Folio_del_Caso")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Folio_del_Caso_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }
        [ForeignKey("Usuario_que_Solicita")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Solicita_Spartan_User { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Numero_de_Expediente_AT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Numero_de_Expediente_AT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Numero_de_Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Numero_de_Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Documento.Documento Solicitud_Documento { get; set; }
        [ForeignKey("Ver_Documento")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Ver_Documento_Spartane_File { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Solicitud_de_Apoyo.Estatus_de_Solicitud_de_Apoyo Estatus_Estatus_de_Solicitud_de_Apoyo { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_Recepcion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public int? Area_Asignada { get; set; }
        public int? SubArea_Asignada { get; set; }
        public string Observaciones_Recepcion { get; set; }

		        [ForeignKey("Usuario_que_Recibe")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Recibe_Spartan_User { get; set; }
        [ForeignKey("Area_Asignada")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Asignada_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea_Asignada")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_Asignada_SubArea_de_Servicios_de_Apoyo { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_Asignacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public int? Tipo_de_Asignacion { get; set; }
        public int? Responsable_Asignado { get; set; }
        public string Observaciones_Asignacion { get; set; }

		        [ForeignKey("Usuario_que_Asigna")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Asigna_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Asignacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo { get; set; }
        [ForeignKey("Responsable_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Responsable_Asignado_Spartan_User { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_Contestacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Contestacion { get; set; }
        public string Hora_de_Contestacion { get; set; }
        public int? Usuario_que_contesta { get; set; }
        public int? Dictamen { get; set; }
        public bool? Enviar_Contestacion { get; set; }
        public int? Archivo { get; set; }
        public string Observaciones_Contestacion { get; set; }

		        [ForeignKey("Usuario_que_contesta")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_contesta_Spartan_User { get; set; }
        [ForeignKey("Dictamen")]
        public virtual Spartane.Core.Domain.Documento.Documento Dictamen_Documento { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_Autorizacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public short? Resultado_de_Autorizacion { get; set; }
        public string Motivo_de_Rechazo { get; set; }
        public string Observaciones_Autorizacion { get; set; }

		        [ForeignKey("Usuario_que_Revisa")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Revisa_Spartan_User { get; set; }
        [ForeignKey("Resultado_de_Autorizacion")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision Resultado_de_Autorizacion_Resultado_de_Revision { get; set; }

    }


}

