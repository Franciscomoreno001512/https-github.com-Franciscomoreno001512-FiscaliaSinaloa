using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_de_TurnosGridModel
    {
        public int Folio { get; set; }
        public string Fecha_de_Turno { get; set; }
        public string Hora_de_Turno { get; set; }
        public string Numero_de_Turno { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public string Unidad_de_AtencionDescripcion { get; set; }
        public int? Recepcion { get; set; }
        public string RecepcionName { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public short? Edad { get; set; }
        public int? Tipo_de_Atencion { get; set; }
        public string Tipo_de_AtencionDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Otra_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public bool? Urgencia { get; set; }
        public int? Tipo_de_Urgencia { get; set; }
        public string Tipo_de_UrgenciaDescripcion { get; set; }
        public int? Denuncia_Ciudadana { get; set; }
        public string Denuncia_CiudadanaFolio { get; set; }
        public int? Turno_Previo { get; set; }
        public string Turno_PrevioNumero_Turno { get; set; }
        public int? Orientador { get; set; }
        public string OrientadorName { get; set; }
        public int? Estatus_de_Turno { get; set; }
        public string Estatus_de_TurnoDescripcion { get; set; }
        public int? Modulo { get; set; }
        public string ModuloDescripcion { get; set; }
        public int? Motivo_Finalizacion_Turno { get; set; }
        public string Motivo_Finalizacion_TurnoDescripcion { get; set; }
        public string Observaciones { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public string Fecha_de_Finalizacion { get; set; }
        public string Hora_de_Finalizacion { get; set; }
        
    }
}

