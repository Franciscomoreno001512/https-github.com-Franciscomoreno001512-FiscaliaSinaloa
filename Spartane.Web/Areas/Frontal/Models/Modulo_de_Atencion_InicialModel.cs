using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_de_Atencion_InicialModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string NUAT { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
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
        public string Calle { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool Menor_de_Edad { get; set; }
        public bool Representante_Legal { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Fecha_de_Nacimiento_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public string Sexo_del_TutorDescripcion { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public string Estado_Civil_del_TutorDescripcion { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Tipo_de_Identificacion_del_TutorNombre { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public string Nacionalidad_del_TutorNacionalidadC { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public string Escolaridad_del_TutorDescripcion { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Ocupacion_del_TutorDescripcion { get; set; }
        public string Calle_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public string Colonia_del_TutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public string Localidad_del_TutorDescripcion { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public string Municipio_del_TutorNombre { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Estado_del_TutorNombre { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public string Nombre_del_Representante { get; set; }
        public string Apellido_Paterno_del_Representante { get; set; }
        public string Apellido_Materno_del_Representante { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Calle_del_Representante { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior_del_Representante { get; set; }
        public string Numero_Interior_del_Representante { get; set; }
        public int? Colonia_del_Representante { get; set; }
        public string Colonia_del_RepresentanteNombre { get; set; }
        public int? Localidad_del_Representante { get; set; }
        public string Localidad_del_RepresentanteDescripcion { get; set; }
        public int? Municipio_del_Representante { get; set; }
        public string Municipio_del_RepresentanteNombre { get; set; }
        public int? Estado_del_Representante { get; set; }
        public string Estado_del_RepresentanteNombre { get; set; }
        public string Telefono_del_Representante { get; set; }
        public string Celular_del_Representante { get; set; }
        public string Correo_Electronico_del_Representante { get; set; }
        public string Narrativa { get; set; }
        public bool Atencion_Medica { get; set; }
        public bool Atencion_Psicologica { get; set; }
        public bool Requiere_Traductor { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Turno_Asignado { get; set; }
        public string Turno_AsignadoNumero_de_Turno { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Municipio_Caso { get; set; }
        public string Municipio_CasoNombre { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Expediente { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia_Hechos_MPO { get; set; }
        public string Colonia_Hechos_MPONombre { get; set; }

    }
	
	public class Modulo_de_Atencion_Inicial_Datos_del_CasoModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string NUAT { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Turno_Asignado { get; set; }
        public string Turno_AsignadoNumero_de_Turno { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Municipio_Caso { get; set; }
        public string Municipio_CasoNombre { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Expediente { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
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
        public string Calle { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Menor_de_Edad { get; set; }
        public bool? Representante_Legal { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_del_TutorModel
    {
        [Required]
        public int Folio { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Fecha_de_Nacimiento_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public string Sexo_del_TutorDescripcion { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public string Estado_Civil_del_TutorDescripcion { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Tipo_de_Identificacion_del_TutorNombre { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public string Nacionalidad_del_TutorNacionalidadC { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public string Escolaridad_del_TutorDescripcion { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Ocupacion_del_TutorDescripcion { get; set; }
        public string Calle_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public string Colonia_del_TutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Tutor { get; set; }
        public int? Localidad_del_Tutor { get; set; }
        public string Localidad_del_TutorDescripcion { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public string Municipio_del_TutorNombre { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Estado_del_TutorNombre { get; set; }
        public string Telefono_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_del_Representante_LegalModel
    {
        [Required]
        public int Folio { get; set; }
        public string Nombre_del_Representante { get; set; }
        public string Apellido_Paterno_del_Representante { get; set; }
        public string Apellido_Materno_del_Representante { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Calle_del_Representante { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_Exterior_del_Representante { get; set; }
        public string Numero_Interior_del_Representante { get; set; }
        public int? Colonia_del_Representante { get; set; }
        public string Colonia_del_RepresentanteNombre { get; set; }
        public int? Localidad_del_Representante { get; set; }
        public string Localidad_del_RepresentanteDescripcion { get; set; }
        public int? Municipio_del_Representante { get; set; }
        public string Municipio_del_RepresentanteNombre { get; set; }
        public int? Estado_del_Representante { get; set; }
        public string Estado_del_RepresentanteNombre { get; set; }
        public string Telefono_del_Representante { get; set; }
        public string Celular_del_Representante { get; set; }
        public string Correo_Electronico_del_Representante { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_de_los_HechosModel
    {
        [Required]
        public int Folio { get; set; }
        public string Narrativa { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_ApoyoModel
    {
        [Required]
        public int Folio { get; set; }
        public bool? Atencion_Medica { get; set; }
        public bool? Atencion_Psicologica { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Servicios_de_ApoyoModel
    {
        [Required]
        public int Folio { get; set; }
        public bool? Requiere_Traductor { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Tipo_de_ComparecienteModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }

    }

	public class Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPOModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia_Hechos_MPO { get; set; }
        public string Colonia_Hechos_MPONombre { get; set; }

    }


}

