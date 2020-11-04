using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_de_TutorGridModel
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Localidad { get; set; }
        public string LocalidadDescripcion { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public int? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        
    }
}

