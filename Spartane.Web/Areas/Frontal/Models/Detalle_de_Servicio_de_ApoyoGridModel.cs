using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Servicio_de_ApoyoGridModel
    {
        public int Clave { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public string Modulo_de_Atencion_InicialNUAT { get; set; }
        public int? Modulo_Mecanismos_Alternos { get; set; }
        public string Modulo_Mecanismos_AlternosCDI { get; set; }
        public int? Modulo_Ministerio_Publico { get; set; }
        public string Modulo_Ministerio_Publiconic { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public string Responsable { get; set; }
        public int? Compareciente { get; set; }
        public string ComparecienteNombre_Completo { get; set; }
        public int? Documento_Atencion_Inicial { get; set; }
        public string Documento_Atencion_InicialObservaciones { get; set; }
        public int? Documento_Mecanismos_Alternos { get; set; }
        public string Documento_Mecanismos_AlternosDescripcion { get; set; }
        public int? Documento_Ministerio_Publico { get; set; }
        public string Documento_Ministerio_PublicoDescripcion { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaDescripcion { get; set; }
        public int? Archivo { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public string Numero_Oficio { get; set; }
        public int? Imagen { get; set; }
        public Grid_File ImagenFileInfo { set; get; }
        public string Nombre_Solicitante { get; set; }
        public string Rango_Solicitante { get; set; }
        public int? Autoridades { get; set; }
        public string AutoridadesDescripcion { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaDescripcion { get; set; }
        public string Observaciones { get; set; }
        public int? Dictamen { get; set; }
        public string DictamenDescripcion { get; set; }
        public bool? Contestacion_lista_para_enviarse { get; set; }
        public int? Area_Pericial { get; set; }
        public string Area_PericialDescripcion { get; set; }
        public int? Perito { get; set; }
        public string PeritoName { get; set; }
        
    }
}

