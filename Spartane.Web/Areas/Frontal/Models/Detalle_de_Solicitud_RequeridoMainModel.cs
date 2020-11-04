using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_RequeridoMainModel
    {
        public Detalle_de_Solicitud_RequeridoModel Detalle_de_Solicitud_RequeridoInfo { set; get; }
        public Otros_Nombres_Requerido_MASCGridModelPost Otros_Nombres_Requerido_MASCGridInfo { set; get; }
        public Otros_Domicilios_Requeridos_MASCGridModelPost Otros_Domicilios_Requeridos_MASCGridInfo { set; get; }
        public Adicciones_Requerido_MASCGridModelPost Adicciones_Requerido_MASCGridInfo { set; get; }
        public Lugares_Frecuentes_Requerido_MASCGridModelPost Lugares_Frecuentes_Requerido_MASCGridInfo { set; get; }
        public Datos_Personales_Adicionales_Requerido_MASCGridModelPost Datos_Personales_Adicionales_Requerido_MASCGridInfo { set; get; }
        public Otras_Identificaciones_Requerido_MASCGridModelPost Otras_Identificaciones_Requerido_MASCGridInfo { set; get; }

    }

    public class Otros_Nombres_Requerido_MASCGridModelPost
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Otros_Domicilios_Requeridos_MASCGridModelPost
    {
        public int Clave { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }

        public bool Removed { set; get; }
    }

    public class Adicciones_Requerido_MASCGridModelPost
    {
        public int Clave { get; set; }
        public int? Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Lugares_Frecuentes_Requerido_MASCGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Datos_Personales_Adicionales_Requerido_MASCGridModelPost
    {
        public int Clave { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Otras_Identificaciones_Requerido_MASCGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }



}

