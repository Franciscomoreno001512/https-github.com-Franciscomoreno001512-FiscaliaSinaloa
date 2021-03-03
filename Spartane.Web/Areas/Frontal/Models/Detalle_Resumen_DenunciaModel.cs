using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Resumen_DenunciaModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnuat { get; set; }
        public string Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public string Usuario_que_registraName { get; set; }
        public int? Generar { get; set; }
        public string GenerarDescripcion { get; set; }
        public string Numero_Generado { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Probable_Responsable { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public string Hechos { get; set; }
        public bool Generado { get; set; }
        public bool Archivo_Descargado { get; set; }
        public int? Documento { get; set; }
        public string DocumentoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Archivo { get; set; }

    }
	
	public class Detalle_Resumen_Denuncia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnuat { get; set; }
        public string Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public string Usuario_que_registraName { get; set; }
        public int? Generar { get; set; }
        public string GenerarDescripcion { get; set; }
        public string Numero_Generado { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Probable_Responsable { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public string Hechos { get; set; }
        public bool? Generado { get; set; }
        public bool? Archivo_Descargado { get; set; }
        public int? Documento { get; set; }
        public string DocumentoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Archivo { get; set; }

    }


}

