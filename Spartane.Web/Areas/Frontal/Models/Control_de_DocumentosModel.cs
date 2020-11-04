using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_DocumentosModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        [Range(0, 9999999999)]
        public int? idFormato { get; set; }
        [Range(0, 9999999999)]
        public int? LlaveRegistro { get; set; }
        public string TablaPersona { get; set; }
        [Range(0, 9999999999)]
        public int? LlaveRegistroPersona { get; set; }
        public int? Proceso { get; set; }
        public string ProcesoDescripcion { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Cuerpo_del_Documento { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }
        public string Encabezado { get; set; }
        public string Pie_de_Pagina { get; set; }

    }
	
	public class Control_de_Documentos_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        [Range(0, 9999999999)]
        public int? idFormato { get; set; }
        [Range(0, 9999999999)]
        public int? LlaveRegistro { get; set; }
        public string TablaPersona { get; set; }
        [Range(0, 9999999999)]
        public int? LlaveRegistroPersona { get; set; }

    }

	public class Control_de_Documentos_DocumentoModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Proceso { get; set; }
        public string ProcesoDescripcion { get; set; }
        public string Numero_de_Expediente { get; set; }
        [AllowHtml]
        public string Cuerpo_del_Documento { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

    }

	public class Control_de_Documentos_SeccionesModel
    {
        [Required]
        public int Folio { get; set; }
        [AllowHtml]
        public string Encabezado { get; set; }
        [AllowHtml]
        public string Pie_de_Pagina { get; set; }

    }

	public class Control_de_Documentos_HistorialModel
    {
        [Required]
        public int Folio { get; set; }

    }


}

