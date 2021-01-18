using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Diligencias_MPGridModel
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public string Tipo_de_DocumentoDescripcion { get; set; }
        public int? Documento { get; set; }
        public string DocumentoDescripcion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Involucrado { get; set; }
        public string InvolucradoNombre_Completo { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo_Detenido { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoFileInfo { set; get; }
        public string Observaciones { get; set; }
        public int? Archivo { get; set; }
        public string Descripcion { get; set; }
        public bool? Lista_para_periciales { get; set; }
        
    }
}

