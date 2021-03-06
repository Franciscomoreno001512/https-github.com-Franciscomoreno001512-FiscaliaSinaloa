﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Servicios_de_ApoyoModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public int? Usuario_que_Solicita { get; set; }
        public string Usuario_que_SolicitaName { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public int? Numero_de_Expediente_AT { get; set; }
        public string Numero_de_Expediente_ATNUAT { get; set; }
        public int? Diligencia_AT { get; set; }
        public string Diligencia_ATObservaciones { get; set; }
        public int? Numero_de_Expediente_MP { get; set; }
        public string Numero_de_Expediente_MPnuat { get; set; }
        public int? Diligencia_MP { get; set; }
        public string Diligencia_MPObservaciones { get; set; }
        public string NUAT { get; set; }
        public string Numero_de_Denuncia { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Solicitud_de_Apoyo_Externa { get; set; }
        public bool Solicitud_Externa { get; set; }
        public int? Autoridad_que_Solicita { get; set; }
        public string Autoridad_que_SolicitaDescripcion { get; set; }
        public string Narracion_Solicitud { get; set; }
        public int? Ver_Documento { get; set; }
        public HttpPostedFileBase Ver_DocumentoFile { set; get; }
        public int Ver_DocumentoRemoveAttachment { set; get; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public string Usuario_que_RecibeName { get; set; }
        public int? Area_Asignada { get; set; }
        public string Area_AsignadaDescripcion { get; set; }
        public int? SubArea_Asignada { get; set; }
        public string SubArea_AsignadaDescripcion { get; set; }
        public string Observaciones_Recepcion { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public string Usuario_que_AsignaName { get; set; }
        public int? Tipo_de_Asignacion { get; set; }
        public string Tipo_de_AsignacionDescripcion { get; set; }
        public int? Responsable_Asignado { get; set; }
        public string Responsable_AsignadoName { get; set; }
        public string Observaciones_Asignacion { get; set; }
        public string Fecha_de_Contestacion { get; set; }
        public string Hora_de_Contestacion { get; set; }
        public int? Usuario_que_contesta { get; set; }
        public string Usuario_que_contestaName { get; set; }
        public int? Dictamen { get; set; }
        public string DictamenDescripcion { get; set; }
        public string numero_contestacion { get; set; }
        public bool Enviar_Contestacion { get; set; }
        [Range(0, 9999999999)]
        public int? Archivo { get; set; }
        public string Observaciones_Contestacion { get; set; }
        public string Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public string Usuario_que_RevisaName { get; set; }
        public short? Resultado_de_Autorizacion { get; set; }
        public string Resultado_de_AutorizacionDescripcion { get; set; }
        public string Motivo_de_Rechazo { get; set; }
        public string Observaciones_Autorizacion { get; set; }

    }
	
	public class Solicitud_de_Servicios_de_Apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public int? Usuario_que_Solicita { get; set; }
        public string Usuario_que_SolicitaName { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public int? Numero_de_Expediente_AT { get; set; }
        public string Numero_de_Expediente_ATNUAT { get; set; }
        public int? Diligencia_AT { get; set; }
        public string Diligencia_ATObservaciones { get; set; }
        public int? Numero_de_Expediente_MP { get; set; }
        public string Numero_de_Expediente_MPnuat { get; set; }
        public int? Diligencia_MP { get; set; }
        public string Diligencia_MPObservaciones { get; set; }
        public string NUAT { get; set; }
        public string Numero_de_Denuncia { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Solicitud_de_Apoyo_Externa { get; set; }
        public bool? Solicitud_Externa { get; set; }
        public int? Autoridad_que_Solicita { get; set; }
        public string Autoridad_que_SolicitaDescripcion { get; set; }
        public string Narracion_Solicitud { get; set; }
        public int? Ver_Documento { get; set; }
        public HttpPostedFileBase Ver_DocumentoFile { set; get; }
        public int Ver_DocumentoRemoveAttachment { set; get; }
        public string Observaciones { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_RecepcionModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public string Usuario_que_RecibeName { get; set; }
        public int? Area_Asignada { get; set; }
        public string Area_AsignadaDescripcion { get; set; }
        public int? SubArea_Asignada { get; set; }
        public string SubArea_AsignadaDescripcion { get; set; }
        public string Observaciones_Recepcion { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_AsignacionModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public string Usuario_que_AsignaName { get; set; }
        public int? Tipo_de_Asignacion { get; set; }
        public string Tipo_de_AsignacionDescripcion { get; set; }
        public int? Responsable_Asignado { get; set; }
        public string Responsable_AsignadoName { get; set; }
        public string Observaciones_Asignacion { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_ContestacionModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Contestacion { get; set; }
        public string Hora_de_Contestacion { get; set; }
        public int? Usuario_que_contesta { get; set; }
        public string Usuario_que_contestaName { get; set; }
        public int? Dictamen { get; set; }
        public string DictamenDescripcion { get; set; }
        public string numero_contestacion { get; set; }
        public bool? Enviar_Contestacion { get; set; }
        [Range(0, 9999999999)]
        public int? Archivo { get; set; }
        public string Observaciones_Contestacion { get; set; }

    }

	public class Solicitud_de_Servicios_de_Apoyo_AutorizacionModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public string Usuario_que_RevisaName { get; set; }
        public short? Resultado_de_Autorizacion { get; set; }
        public string Resultado_de_AutorizacionDescripcion { get; set; }
        public string Motivo_de_Rechazo { get; set; }
        public string Observaciones_Autorizacion { get; set; }

    }


}

