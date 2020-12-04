using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Audiencia_InicialGridModel
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Nombre_del_Juez_de_Control { get; set; }
        public string causa_penal { get; set; }
        public string Fecha_Audiencia_Inicial { get; set; }
        public string Hora_Audiencia_Inicial { get; set; }
        public string Sala_de_Audiencia { get; set; }
        public short? Con_Detenido { get; set; }
        public string Con_DetenidoDescripcion { get; set; }
        public int? Especificar_Detencion { get; set; }
        public string Especificar_DetencionDescripcion { get; set; }
        public int? Control_de_Detencion { get; set; }
        public string Control_de_DetencionDescripcion { get; set; }
        public int? Especificar_Control_Detencion { get; set; }
        public string Especificar_Control_DetencionDescripcion { get; set; }
        public int? Formulacion_de_Imputacion { get; set; }
        public string Formulacion_de_ImputacionDescripcion { get; set; }
        
    }
}

