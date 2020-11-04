using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_de_la_Victima_MPIMainModel
    {
        public Detalle_de_Datos_de_la_Victima_MPIModel Detalle_de_Datos_de_la_Victima_MPIInfo { set; get; }
        public Detalle_del_Abogado_Victima_MPIGridModelPost Detalle_del_Abogado_Victima_MPIGridInfo { set; get; }

    }

    public class Detalle_del_Abogado_Victima_MPIGridModelPost
    {
        public int Consecutivo_Victima { get; set; }
        public int? Nombre_Completo_del_Abogado_Victima { get; set; }
        public string Nombre_del_Abogado_Victima { get; set; }
        public string Apellido_Paterno_del_Abogado_Victima { get; set; }
        public string Apellido_Materno_del_Abogado_Victima { get; set; }
        public string Fecha_de_Nacimiento_del_Abogado_Victima { get; set; }
        public short? Edad_del_Abogado_Victima { get; set; }
        public int? Sexo_del_Abogado_Victima { get; set; }
        public int? Estado_Civil_del_Abogado_Victima { get; set; }
        public int? Tipo_de_Identificacion_Abogado_Victima { get; set; }
        public string Numero_de_Identificacion_Abogado_Victima { get; set; }
        public int? Nacionalidad_del_Abogado_Victima { get; set; }
        public string Cedula_Profesional_del_Abogado_Victima { get; set; }
        public int? Pais_del_Abogado_Victima { get; set; }
        public int? Estado_del_Abogado_Victima { get; set; }
        public int? Municipio_del_Abogado_Victima { get; set; }
        public int? Colonia_del_Abogado_Victima { get; set; }
        public int? Codigo_Postal_del_Abogado_Victima { get; set; }
        public string Calle_del_Abogado_Victima { get; set; }
        public string Numero_Exterior_del_Abogado_Victima { get; set; }
        public string Numero_Interior_del_Abogado_Victima { get; set; }
        public string Telefono_del_Abogado_Victima { get; set; }
        public string Celular_del_Abogado_Victima { get; set; }
        public string Correo_Electronico_del_Abogado_Victima { get; set; }
        public bool? Aceptar_Notificaciones { get; set; }

        public bool Removed { set; get; }
    }



}

