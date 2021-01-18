using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_SeguimientoGridModel
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre { get; set; }
        public string Fecha_Requerida { get; set; }
        public int? Cumplimiento { get; set; }
        public string CumplimientoDescripcion { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        public int? Forma_de_Pago { get; set; }
        public string Forma_de_PagoDescripcion { get; set; }
        public decimal? Cantidad_del_Monto { get; set; }
        public string Descripcion_de_Cumplimiento { get; set; }
        public short? Concluir_Acuerdo { get; set; }
        public string Concluir_AcuerdoDescripcion { get; set; }
        public int? Especialista { get; set; }
        public string EspecialistaName { get; set; }
        public string Comentarios { get; set; }
        public int? Archivo { get; set; }
        public Grid_File ArchivoFileInfo { set; get; }
        
    }
}

