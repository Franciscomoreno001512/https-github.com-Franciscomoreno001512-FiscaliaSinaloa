using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Apoyo_ExternaGridModel
    {
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public short? Anio { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public string Numero_de_Oficio_Externo { get; set; }
        public string Solicitante { get; set; }
        public string Rango { get; set; }
        public int? Autoridad_Externa { get; set; }
        public string Autoridad_ExternaDescripcion { get; set; }
        public string Narracion_Solicitud { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoFileInfo { set; get; }
        public int? Area_Asignada { get; set; }
        public string Area_AsignadaDescripcion { get; set; }
        public int? SubArea_Asignada { get; set; }
        public string SubArea_AsignadaDescripcion { get; set; }
        public int? Dictamen_Solicitado { get; set; }
        public string Dictamen_SolicitadoDescripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Fecha_de_Contestacion { get; set; }
        public string Hora_de_Contestacion { get; set; }
        public int? Responsable_que_Contesta { get; set; }
        public string Responsable_que_ContestaName { get; set; }
        public string No__Contestacion { get; set; }
        public int? Dictamen { get; set; }
        public string DictamenDescripcion { get; set; }
        public string Observaciones { get; set; }
        public int? Ver_Documento { get; set; }
        public Grid_File Ver_DocumentoFileInfo { set; get; }
        
    }
}

