using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Quejas_de_MPModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Tipo_de_Cejas { get; set; }
        public string Tipo_de_CejasDescripcion { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public string Tamano_de_CejasDescripcion { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public string Largo_de_CabelloDescripcion { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public string Cantidad_CabelloDescripcion { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public string Implantacion_CabelloDescripcion { get; set; }
        public int? Complexion { get; set; }
        public string ComplexionDescripcion { get; set; }
        public int? Color_Piel { get; set; }
        public string Color_PielDescrpicion { get; set; }
        public int? Frente { get; set; }
        public string FrenteDescripcion { get; set; }
        public int? Forma_Cabello { get; set; }
        public string Forma_CabelloDescripcion { get; set; }
        public int? Color_Cabello { get; set; }
        public string Color_CabelloDescripcion { get; set; }
        public int? Calvicie { get; set; }
        public string CalvicieDescripcion { get; set; }
        public int? Color_Ojos { get; set; }
        public string Color_OjosDescripcion { get; set; }
        public int? Tamano_de_Ojos { get; set; }
        public string Tamano_de_OjosDescripcion { get; set; }
        public int? Forma_Ojos { get; set; }
        public string Forma_OjosDescripcion { get; set; }
        public int? Anteojos { get; set; }
        public string AnteojosDescripcion { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public string Forma_de_NarizDescripcion { get; set; }
        public int? Tamano_Nariz { get; set; }
        public string Tamano_NarizDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public string Grosor_de_LabiosDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
        public int? Forma_de_Menton { get; set; }
        public string Forma_de_MentonDescripcion { get; set; }
        public int? Barba { get; set; }
        public string BarbaDescripcion { get; set; }
        public int? Forma_Orejas { get; set; }
        public string Forma_OrejasDescripcion { get; set; }
        public int? Tamano_Orejas { get; set; }
        public string Tamano_OrejasDescripcion { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public string Tipo_LobuloDescripcion { get; set; }
        public int? Bigote { get; set; }
        public string BigoteDescripcion { get; set; }
        public int? Senas_Particulares { get; set; }
        public string Senas_ParticularesDescripcion { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public HttpPostedFileBase Imagen_TatuajeFile { set; get; }
        public int Imagen_TatuajeRemoveAttachment { set; get; }
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }
        public string Otras_Senas_Particulares { get; set; }
        public string Descripcion_de_los_Hechos { get; set; }
        public string CURP { get; set; }
        public int? Genero { get; set; }
        public string GeneroDescripcion { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public int? Entidad_de_Nacimiento { get; set; }
        public string Entidad_de_NacimientoNombre { get; set; }
        public string Nombres_Hechos { get; set; }
        public string Apellido_Paterno_Hechos { get; set; }
        public string Apellido_Materno_Hechos { get; set; }
        public string Fecha_de_Nacimiento_Hechos { get; set; }
        [Range(0, 9999999999)]
        public int? Edad_Hechos { get; set; }
        public int? Genero_Hechos { get; set; }
        public string Genero_HechosDescripcion { get; set; }
        public string Celular_Hechos { get; set; }
        public string Correo_Hechos { get; set; }
        public int? Tipo_de_Identificacion_Hechos { get; set; }
        public string Tipo_de_Identificacion_HechosNombre { get; set; }
        public string Numero_Identificacion_Hechos { get; set; }
        public int? Fotografia_Identificacion { get; set; }
        public HttpPostedFileBase Fotografia_IdentificacionFile { set; get; }
        public int Fotografia_IdentificacionRemoveAttachment { set; get; }
        public int? Nacionalidad_Hechos { get; set; }
        public string Nacionalidad_HechosNacionalidadC { get; set; }
        public int? Entidad_de_Nacimiento_Hechos { get; set; }
        public string Entidad_de_Nacimiento_HechosNombre { get; set; }
        public string CURP_Identificacion { get; set; }
        public string Nombres_Identificacion { get; set; }
        public string Apellido_Paterno_Identificacion { get; set; }
        public string Apellido_Materno_Identificacion { get; set; }
        public string Fecha_Nacimiento_Identificacion { get; set; }
        [Range(0, 9999999999)]
        public int? Edad_Identificacion { get; set; }
        public int? Genero_Identificacion { get; set; }
        public string Genero_IdentificacionDescripcion { get; set; }
        public string Celular_Identificacion { get; set; }
        public string Correo_Identificacion { get; set; }
        public int? Tipo_de_Identificacion_Identificacion { get; set; }
        public string Tipo_de_Identificacion_IdentificacionNombre { get; set; }
        public string Numero_Identificacion_Identificacion { get; set; }
        public int? Nacionalidad_Identificacion { get; set; }
        public string Nacionalidad_IdentificacionNacionalidadC { get; set; }
        public int? Entidad_de_Nacimiento_Identificacion { get; set; }
        public string Entidad_de_Nacimiento_IdentificacionNombre { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public string Codigo_Postal { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencias_de_domicilio { get; set; }

    }
	
	public class Quejas_de_MP_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }

	public class Quejas_de_MP_Datos_de_Media_FiliacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Tipo_de_Cejas { get; set; }
        public string Tipo_de_CejasDescripcion { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public string Tamano_de_CejasDescripcion { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public string Largo_de_CabelloDescripcion { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public string Cantidad_CabelloDescripcion { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public string Implantacion_CabelloDescripcion { get; set; }
        public int? Complexion { get; set; }
        public string ComplexionDescripcion { get; set; }
        public int? Color_Piel { get; set; }
        public string Color_PielDescrpicion { get; set; }
        public int? Frente { get; set; }
        public string FrenteDescripcion { get; set; }
        public int? Forma_Cabello { get; set; }
        public string Forma_CabelloDescripcion { get; set; }
        public int? Color_Cabello { get; set; }
        public string Color_CabelloDescripcion { get; set; }
        public int? Calvicie { get; set; }
        public string CalvicieDescripcion { get; set; }
        public int? Color_Ojos { get; set; }
        public string Color_OjosDescripcion { get; set; }
        public int? Tamano_de_Ojos { get; set; }
        public string Tamano_de_OjosDescripcion { get; set; }
        public int? Forma_Ojos { get; set; }
        public string Forma_OjosDescripcion { get; set; }
        public int? Anteojos { get; set; }
        public string AnteojosDescripcion { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public string Forma_de_NarizDescripcion { get; set; }
        public int? Tamano_Nariz { get; set; }
        public string Tamano_NarizDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public string Grosor_de_LabiosDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
        public int? Forma_de_Menton { get; set; }
        public string Forma_de_MentonDescripcion { get; set; }
        public int? Barba { get; set; }
        public string BarbaDescripcion { get; set; }
        public int? Forma_Orejas { get; set; }
        public string Forma_OrejasDescripcion { get; set; }
        public int? Tamano_Orejas { get; set; }
        public string Tamano_OrejasDescripcion { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public string Tipo_LobuloDescripcion { get; set; }
        public int? Bigote { get; set; }
        public string BigoteDescripcion { get; set; }
        public int? Senas_Particulares { get; set; }
        public string Senas_ParticularesDescripcion { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public HttpPostedFileBase Imagen_TatuajeFile { set; get; }
        public int Imagen_TatuajeRemoveAttachment { set; get; }
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }
        public string Otras_Senas_Particulares { get; set; }

    }

	public class Quejas_de_MP_Datos_de_los_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion_de_los_Hechos { get; set; }
        public string CURP { get; set; }
        public int? Genero { get; set; }
        public string GeneroDescripcion { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public int? Entidad_de_Nacimiento { get; set; }
        public string Entidad_de_NacimientoNombre { get; set; }
        public string Nombres_Hechos { get; set; }
        public string Apellido_Paterno_Hechos { get; set; }
        public string Apellido_Materno_Hechos { get; set; }
        public string Fecha_de_Nacimiento_Hechos { get; set; }
        [Range(0, 9999999999)]
        public int? Edad_Hechos { get; set; }
        public int? Genero_Hechos { get; set; }
        public string Genero_HechosDescripcion { get; set; }
        public string Celular_Hechos { get; set; }
        public string Correo_Hechos { get; set; }
        public int? Tipo_de_Identificacion_Hechos { get; set; }
        public string Tipo_de_Identificacion_HechosNombre { get; set; }
        public string Numero_Identificacion_Hechos { get; set; }
        public int? Fotografia_Identificacion { get; set; }
        public HttpPostedFileBase Fotografia_IdentificacionFile { set; get; }
        public int Fotografia_IdentificacionRemoveAttachment { set; get; }
        public int? Nacionalidad_Hechos { get; set; }
        public string Nacionalidad_HechosNacionalidadC { get; set; }
        public int? Entidad_de_Nacimiento_Hechos { get; set; }
        public string Entidad_de_Nacimiento_HechosNombre { get; set; }

    }

	public class Quejas_de_MP_Datos_de_IdentificacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string CURP_Identificacion { get; set; }
        public string Nombres_Identificacion { get; set; }
        public string Apellido_Paterno_Identificacion { get; set; }
        public string Apellido_Materno_Identificacion { get; set; }
        public string Fecha_Nacimiento_Identificacion { get; set; }
        [Range(0, 9999999999)]
        public int? Edad_Identificacion { get; set; }
        public int? Genero_Identificacion { get; set; }
        public string Genero_IdentificacionDescripcion { get; set; }
        public string Celular_Identificacion { get; set; }
        public string Correo_Identificacion { get; set; }
        public int? Tipo_de_Identificacion_Identificacion { get; set; }
        public string Tipo_de_Identificacion_IdentificacionNombre { get; set; }
        public string Numero_Identificacion_Identificacion { get; set; }
        public int? Nacionalidad_Identificacion { get; set; }
        public string Nacionalidad_IdentificacionNacionalidadC { get; set; }
        public int? Entidad_de_Nacimiento_Identificacion { get; set; }
        public string Entidad_de_Nacimiento_IdentificacionNombre { get; set; }

    }

	public class Quejas_de_MP_Datos_de_DomicilioModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public string Codigo_Postal { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencias_de_domicilio { get; set; }

    }


}

