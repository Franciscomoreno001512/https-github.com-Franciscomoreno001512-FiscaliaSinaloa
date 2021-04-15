using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Denuncia_CiudadanaGridModel
    {
        public int Clave { get; set; }
        public string Folio { get; set; }
        public string Contrasena { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public string Tipo_de_SolicitudDescripcion { get; set; }
        public int? Estatus_de_Solicitud { get; set; }
        public string Estatus_de_SolicitudDescripcion { get; set; }
        public string Motivo { get; set; }
        public int? Canalizar_a { get; set; }
        public string Canalizar_aDescripcion { get; set; }
        public string Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public string Usuario_que_RevisaName { get; set; }
        public int? Tipo_de_Resolucion { get; set; }
        public string Tipo_de_ResolucionDescripcion { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Unidad_canaliza { get; set; }
        public string Unidad_canalizaDescripcion { get; set; }
        public string Contestacion { get; set; }
        public string Observaciones_resolucion { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public string Usuario_que_AsignaName { get; set; }
        public int? Responsable_Asignado { get; set; }
        public string Responsable_AsignadoName { get; set; }
        public string Observaciones_responsable { get; set; }
        public string Fecha_de_Atencion { get; set; }
        public string Hora_de_Atencion { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public string Usuario_que_AtiendeName { get; set; }
        public int? Atencion_Realizada { get; set; }
        public string Atencion_RealizadaDescripcion { get; set; }
        public string Observaciones_atencion { get; set; }
        
    }
}

