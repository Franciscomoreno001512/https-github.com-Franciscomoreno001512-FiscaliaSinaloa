using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Medidas_de_ProteccionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_AT { get; set; }
        public string Expediente_ATNUAT { get; set; }
        public int? Expediente_MASC { get; set; }
        public string Expediente_MASCNumero_de_Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Orden_de_Proteccion { get; set; }
        public int? Tipo_de_Medida { get; set; }
        public string Tipo_de_MedidaDescripcion { get; set; }
        public int? Sub_Tipo { get; set; }
        public string Sub_TipoDescripcion { get; set; }
        public string Fecha_de_Inicio { get; set; }
        public string Hora_de_Inicio { get; set; }
        public string Fecha_de_Conclusion { get; set; }
        public string Hora_de_Conclusion { get; set; }
        [Range(0, 9999999999)]
        public short? Duracion_en_Dias { get; set; }
        public int? Aplicar_a { get; set; }
        public string Aplicar_aDescripcion { get; set; }

    }
	
	public class Medidas_de_Proteccion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_AT { get; set; }
        public string Expediente_ATNUAT { get; set; }
        public int? Expediente_MASC { get; set; }
        public string Expediente_MASCNumero_de_Folio { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Orden_de_Proteccion { get; set; }
        public int? Tipo_de_Medida { get; set; }
        public string Tipo_de_MedidaDescripcion { get; set; }
        public int? Sub_Tipo { get; set; }
        public string Sub_TipoDescripcion { get; set; }
        public string Fecha_de_Inicio { get; set; }
        public string Hora_de_Inicio { get; set; }
        public string Fecha_de_Conclusion { get; set; }
        public string Hora_de_Conclusion { get; set; }
        [Range(0, 9999999999)]
        public short? Duracion_en_Dias { get; set; }
        public int? Aplicar_a { get; set; }
        public string Aplicar_aDescripcion { get; set; }

    }


}

