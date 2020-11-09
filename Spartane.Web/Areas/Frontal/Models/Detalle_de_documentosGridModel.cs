using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_documentosGridModel
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public string Tipo_de_DocumentoDescripcion { get; set; }
        public int? Documento { get; set; }
        public string DocumentoDescripcion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoFileInfo { set; get; }
        public string Observaciones { get; set; }
        public int? Archivo { get; set; }
        public string Descripcion { get; set; }
        
    }
}

