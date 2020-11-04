using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_del_Imputado_CCModel
    {
        [Required]
        public int Clave { get; set; }
        public bool A_Quien_Resulte_Responsable { get; set; }
        public string Alias { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Calle { get; set; }
        public string Celular { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Correo_Electronico { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public string Entre_calle { get; set; }
        [Range(0, 9999999999)]
        public short? Escolaridad { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public string Estension { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public bool Inimputable { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Tipo_de_InimputabilidadDescripcion { get; set; }
        public string Especifique { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Completo { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public string Originario_de { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Pais_de_OrigenNombre { get; set; }
        public bool Proteccion_de_datos { get; set; }
        public string Referencia_de_domicilio { get; set; }
        public int? Genero { get; set; }
        public string GeneroDescripcion { get; set; }
        public string Telefono { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Y_calle { get; set; }

    }
	
	public class Detalle_de_Datos_del_Imputado_CC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? A_Quien_Resulte_Responsable { get; set; }
        public string Alias { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Calle { get; set; }
        public string Celular { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Correo_Electronico { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public string Entre_calle { get; set; }
        [Range(0, 9999999999)]
        public short? Escolaridad { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public string Estension { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public bool? Inimputable { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Tipo_de_InimputabilidadDescripcion { get; set; }
        public string Especifique { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Completo { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public string Originario_de { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Pais_de_OrigenNombre { get; set; }
        public bool? Proteccion_de_datos { get; set; }
        public string Referencia_de_domicilio { get; set; }
        public int? Genero { get; set; }
        public string GeneroDescripcion { get; set; }
        public string Telefono { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Y_calle { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_CC_GaleriaModel
    {
        [Required]
        public int Clave { get; set; }

    }


}

