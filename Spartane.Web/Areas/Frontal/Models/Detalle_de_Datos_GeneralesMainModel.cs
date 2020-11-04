using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_GeneralesMainModel
    {
        public Detalle_de_Datos_GeneralesModel Detalle_de_Datos_GeneralesInfo { set; get; }
        public Adicciones_de_InvolucradoGridModelPost Adicciones_de_InvolucradoGridInfo { set; get; }
        public Lugares_Frecuentes_InvolucradoGridModelPost Lugares_Frecuentes_InvolucradoGridInfo { set; get; }
        public Datos_Personales_Adicionales_InvolucradoGridModelPost Datos_Personales_Adicionales_InvolucradoGridInfo { set; get; }
        public Otras_Identificaciones_InvolucradoGridModelPost Otras_Identificaciones_InvolucradoGridInfo { set; get; }
        public Otros_Domicilios_InvolucradoGridModelPost Otros_Domicilios_InvolucradoGridInfo { set; get; }

    }

    public class Adicciones_de_InvolucradoGridModelPost
    {
        public int Clave { get; set; }
        public int? Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Lugares_Frecuentes_InvolucradoGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Datos_Personales_Adicionales_InvolucradoGridModelPost
    {
        public int Clave { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Otras_Identificaciones_InvolucradoGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_identificacion { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Otros_Domicilios_InvolucradoGridModelPost
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



}

