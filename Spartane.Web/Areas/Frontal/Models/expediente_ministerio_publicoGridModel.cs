using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class expediente_ministerio_publicoGridModel
    {
        public int clave { get; set; }
        public string fecha_de_registro { get; set; }
        public string hora_de_registro { get; set; }
        public int? usuario_que_registra { get; set; }
        public string usuario_que_registraName { get; set; }
        public int? unidad { get; set; }
        public string unidadDescripcion { get; set; }
        public string nuat { get; set; }
        public string nic { get; set; }
        public short? detenido { get; set; }
        public string detenidoDescripcion { get; set; }
        public string hora_del_detenido { get; set; }
        public string hora_puesto_a_disposicion { get; set; }
        public short? estatus { get; set; }
        public string estatusdescripcion { get; set; }
        public int? observaciones { get; set; }
        public int? observacionesclave { get; set; }
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
        public decimal? monto_de_reparacion_de_danos { get; set; }
        public int? parcialidades { get; set; }
        public int? periodicidad { get; set; }
        public string periodicidadDescripcion { get; set; }
        public bool? acepta_acuerdo { get; set; }
        public string motivo_de_rechazo_de_acuerdo { get; set; }
        public string fecha_de_cierre { get; set; }
        public string hora_de_cierre { get; set; }
        public int? tipo_de_cierre { get; set; }
        public string tipo_de_cierredescripcion { get; set; }
        public string comentarios_de_cierre { get; set; }
        
    }
}

