using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_DocumentosGridModel
    {
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? idFormato { get; set; }
        public int? LlaveRegistro { get; set; }
        public string TablaPersona { get; set; }
        public int? LlaveRegistroPersona { get; set; }
        public int? Proceso { get; set; }
        public string ProcesoDescripcion { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Cuerpo_del_Documento { get; set; }
        public int? Archivo { get; set; }
        public Grid_File ArchivoFileInfo { set; get; }
        public string Encabezado { get; set; }
        public string Pie_de_Pagina { get; set; }
        
    }
}

