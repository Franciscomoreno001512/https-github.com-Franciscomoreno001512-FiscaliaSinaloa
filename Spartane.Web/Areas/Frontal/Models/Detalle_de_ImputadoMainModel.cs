using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_ImputadoMainModel
    {
        public Detalle_de_ImputadoModel Detalle_de_ImputadoInfo { set; get; }
        public Lugar_de_DetencionGridModelPost Lugar_de_DetencionGridInfo { set; get; }
        public Adicciones_Probable_ResponsableGridModelPost Adicciones_Probable_ResponsableGridInfo { set; get; }
        public Lugares_Frecuentes_Probable_ResponsableGridModelPost Lugares_Frecuentes_Probable_ResponsableGridInfo { set; get; }
        public Datos_Personales_Adicionales_Probable_ResponsableGridModelPost Datos_Personales_Adicionales_Probable_ResponsableGridInfo { set; get; }
        public Otras_Identificaciones_Probable_ResponsableGridModelPost Otras_Identificaciones_Probable_ResponsableGridInfo { set; get; }
        public Otros_Domicilios_Probable_ResponsableGridModelPost Otros_Domicilios_Probable_ResponsableGridInfo { set; get; }
        public Otros_NombresGridModelPost Otros_NombresGridInfo { set; get; }

    }

    public class Lugar_de_DetencionGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha_de_Detencion { get; set; }
        public int? Municipio_de_Detencion { get; set; }
        public int? Corporacion { get; set; }
        public bool? Suspension_Condicional { get; set; }
        public string Fecha_de_Suspension_Condicional { get; set; }

        public bool Removed { set; get; }
    }

    public class Adicciones_Probable_ResponsableGridModelPost
    {
        public int Clave { get; set; }
        public int? Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Lugares_Frecuentes_Probable_ResponsableGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Datos_Personales_Adicionales_Probable_ResponsableGridModelPost
    {
        public int Clave { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Otras_Identificaciones_Probable_ResponsableGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_identificacion { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Otros_Domicilios_Probable_ResponsableGridModelPost
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
        public string Numero_Interior { get; set; }
        public string Coordenada_X { get; set; }
        public string Coordenada_Y { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Otros_NombresGridModelPost
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }



}

