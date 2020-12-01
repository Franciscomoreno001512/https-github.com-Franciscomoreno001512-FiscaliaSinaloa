using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class expediente_ministerio_publicoModel
    {
        [Required]
        public int clave { get; set; }
        public string fecha_de_registro { get; set; }
        public string hora_de_registro { get; set; }
        public int? usuario_que_registra { get; set; }
        public string usuario_que_registraName { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public int? unidad { get; set; }
        public string unidadDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public string nuat { get; set; }
        public string nic { get; set; }
        public short? detenido { get; set; }
        public string detenidoDescripcion { get; set; }
        public string hora_del_detenido { get; set; }
        public string hora_puesto_a_disposicion { get; set; }
        public short? estatus { get; set; }
        public string estatusdescripcion { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public string Lugar_de_los_HechosDescripcion { get; set; }
        public int? PaisH { get; set; }
        public string PaisHNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio_Hechos { get; set; }
        public string Municipio_HechosNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? ColoniaH { get; set; }
        public string ColoniaHNombre { get; set; }
        public string CalleH { get; set; }
        public string Numero_InteriorH { get; set; }
        public string Numero_ExteriorH { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }
        public string Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? usuario_que_canaliza { get; set; }
        public string usuario_que_canalizaName { get; set; }
        public int? canalizar_a { get; set; }
        public string canalizar_aDescripcion { get; set; }
        public int? tipo_de_acuerdo { get; set; }
        public string tipo_de_acuerdoDescripcion { get; set; }
        public string fecha_de_inicio_de_acuerdo { get; set; }
        public string fecha_de_cumplimiento { get; set; }
        public string hora_de_cumplimiento { get; set; }
        public string domicilio_para_el_cumplimiento { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? monto_de_reparacion_de_danos { get; set; }
        [Range(0, 9999999999)]
        public int? parcialidades { get; set; }
        public int? periodicidad { get; set; }
        public string periodicidadDescripcion { get; set; }
        public short? acepta_acuerdo { get; set; }
        public string acepta_acuerdoDescripcion { get; set; }
        public string motivo_de_rechazo_de_acuerdo { get; set; }
        public string fecha_de_cierre { get; set; }
        public string hora_de_cierre { get; set; }
        public int? Usuario_que_Cierra { get; set; }
        public string Usuario_que_CierraName { get; set; }
        public int? tipo_de_cierre { get; set; }
        public string tipo_de_cierredescripcion { get; set; }
        public string comentarios_de_cierre { get; set; }

    }
	
	public class expediente_ministerio_publico_Datos_del_CasoModel
    {
        [Required]
        public int clave { get; set; }
        public string fecha_de_registro { get; set; }
        public string hora_de_registro { get; set; }
        public int? usuario_que_registra { get; set; }
        public string usuario_que_registraName { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public int? unidad { get; set; }
        public string unidadDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public string nuat { get; set; }
        public string nic { get; set; }
        public short? detenido { get; set; }
        public string detenidoDescripcion { get; set; }
        public string hora_del_detenido { get; set; }
        public string hora_puesto_a_disposicion { get; set; }
        public short? estatus { get; set; }
        public string estatusdescripcion { get; set; }

    }

	public class expediente_ministerio_publico_HechosModel
    {
        [Required]
        public int clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public string Lugar_de_los_HechosDescripcion { get; set; }
        public int? PaisH { get; set; }
        public string PaisHNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio_Hechos { get; set; }
        public string Municipio_HechosNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? ColoniaH { get; set; }
        public string ColoniaHNombre { get; set; }
        public string CalleH { get; set; }
        public string Numero_InteriorH { get; set; }
        public string Numero_ExteriorH { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }

    }

	public class expediente_ministerio_publico_CanalizarModel
    {
        [Required]
        public int clave { get; set; }
        public string Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? usuario_que_canaliza { get; set; }
        public string usuario_que_canalizaName { get; set; }
        public int? canalizar_a { get; set; }
        public string canalizar_aDescripcion { get; set; }

    }

	public class expediente_ministerio_publico_Datos_del_AcuerdoModel
    {
        [Required]
        public int clave { get; set; }
        public int? tipo_de_acuerdo { get; set; }
        public string tipo_de_acuerdoDescripcion { get; set; }
        public string fecha_de_inicio_de_acuerdo { get; set; }
        public string fecha_de_cumplimiento { get; set; }
        public string hora_de_cumplimiento { get; set; }
        public string domicilio_para_el_cumplimiento { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? monto_de_reparacion_de_danos { get; set; }
        [Range(0, 9999999999)]
        public int? parcialidades { get; set; }
        public int? periodicidad { get; set; }
        public string periodicidadDescripcion { get; set; }
        public short? acepta_acuerdo { get; set; }
        public string acepta_acuerdoDescripcion { get; set; }
        public string motivo_de_rechazo_de_acuerdo { get; set; }

    }

	public class expediente_ministerio_publico_Resolucion_o_DictaminacionModel
    {
        [Required]
        public int clave { get; set; }
        public string fecha_de_cierre { get; set; }
        public string hora_de_cierre { get; set; }
        public int? Usuario_que_Cierra { get; set; }
        public string Usuario_que_CierraName { get; set; }
        public int? tipo_de_cierre { get; set; }
        public string tipo_de_cierredescripcion { get; set; }
        public string comentarios_de_cierre { get; set; }

    }


}

