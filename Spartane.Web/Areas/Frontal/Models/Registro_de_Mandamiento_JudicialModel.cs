using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Mandamiento_JudicialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Folio_de_la_Orden_de_Aprehension { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public string Pais_al_que_Pertenece_la_InformacionNombre { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public string Estado_que_Envia_la_InformacionNombre { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public string Municipio_que_Envia_la_InformacionNombre { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public string Institucion_que_RemiteNombre { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public string Entidad_que_Emite_MandamientoNombre { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Juzgado_que_Emitio_MandamientoNombre { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        [Range(0, 9999999999)]
        public short? Estatura { get; set; }
        [Range(0, 9999999999)]
        public short? Peso { get; set; }
        public bool Usa_Anteojos { get; set; }
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
        public int? Pais_de_Nacimiento { get; set; }
        public string Pais_de_NacimientoNombre { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public string Estado_de_NacimientoNombre { get; set; }
        public int? Tipo_de_Orden { get; set; }
        public string Tipo_de_OrdenTipo_de_Ordenx { get; set; }
        public string Fecha_de_Orden { get; set; }
        public string Hora_de_Orden { get; set; }
        public string Dirigida_Por { get; set; }
        public int? Ambito { get; set; }
        public string AmbitoAmbitox { get; set; }
        public int? Juzgado { get; set; }
        public string JuzgadoNombre { get; set; }
        public string Juez { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadDescripcion { get; set; }
        public string Numero_de_Causa { get; set; }
        public string Fecha_de_Oficio { get; set; }
        public int? Tipo_de_Cuantia { get; set; }
        public string Tipo_de_CuantiaDescripcion { get; set; }
        public string Observaciones { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Cejas { get; set; }
        public string CejasDescripcion { get; set; }
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
        public int? Ojos { get; set; }
        public string OjosDescripcion { get; set; }
        public int? Forma_Ojos { get; set; }
        public string Forma_OjosDescripcion { get; set; }
        public int? Nariz_Base { get; set; }
        public string Nariz_BaseDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
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
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }
        public string Fecha_de_Libramiento { get; set; }
        public int? Fuerzo { get; set; }
        public string FuerzoDescripcion { get; set; }
        public int? Tipo_Mandato { get; set; }
        public string Tipo_MandatoDescripcion { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public string Numero_de_Averiguacion { get; set; }
        public string Fecha_de_Captura { get; set; }
        public string Fecha_de_Recepcion { get; set; }
        public string Fecha_de_Prescripcion { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        public string Oficio_de_Cumplimiento { get; set; }
        public string Fecha_de_Cancelacion { get; set; }
        public int? Motivo_de_Cancelacion { get; set; }
        public string Motivo_de_CancelacionDescripcion { get; set; }
        public string Oficio_de_Cancelacion { get; set; }
        public int? Tipo_de_Proceso { get; set; }
        public string Tipo_de_ProcesoDescripcion { get; set; }
        public int? Proceso_de_Extradiccion { get; set; }
        public string Proceso_de_ExtradiccionDescripcion { get; set; }
        public string Observacionesx { get; set; }
        [Range(0, 9999999999)]
        public int? Huellas_Digitales { get; set; }
        [Range(0, 9999999999)]
        public int? Mano_Izquierda_dedos { get; set; }
        [Range(0, 9999999999)]
        public int? Mano_Derecha_Pulgar { get; set; }
        [Range(0, 9999999999)]
        public int? Mano_Derecha_Dedos { get; set; }

    }
	
	public class Registro_de_Mandamiento_Judicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Folio_de_la_Orden_de_Aprehension { get; set; }
        public int? Pais_al_que_Pertenece_la_Informacion { get; set; }
        public string Pais_al_que_Pertenece_la_InformacionNombre { get; set; }
        public int? Estado_que_Envia_la_Informacion { get; set; }
        public string Estado_que_Envia_la_InformacionNombre { get; set; }
        public int? Municipio_que_Envia_la_Informacion { get; set; }
        public string Municipio_que_Envia_la_InformacionNombre { get; set; }
        public int? Institucion_que_Remite { get; set; }
        public string Institucion_que_RemiteNombre { get; set; }
        public int? Entidad_que_Emite_Mandamiento { get; set; }
        public string Entidad_que_Emite_MandamientoNombre { get; set; }
        public int? Juzgado_que_Emitio_Mandamiento { get; set; }
        public string Juzgado_que_Emitio_MandamientoNombre { get; set; }
        public string Numero_de_Mandamiento { get; set; }
        public string Oficio_de_Juzgado { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        [Range(0, 9999999999)]
        public short? Estatura { get; set; }
        [Range(0, 9999999999)]
        public short? Peso { get; set; }
        public bool? Usa_Anteojos { get; set; }
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
        public int? Pais_de_Nacimiento { get; set; }
        public string Pais_de_NacimientoNombre { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public string Estado_de_NacimientoNombre { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_DomicilioModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_TelefonosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Otros_NombresModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Datos_de_la_OrdenModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Orden { get; set; }
        public string Tipo_de_OrdenTipo_de_Ordenx { get; set; }
        public string Fecha_de_Orden { get; set; }
        public string Hora_de_Orden { get; set; }
        public string Dirigida_Por { get; set; }
        public int? Ambito { get; set; }
        public string AmbitoAmbitox { get; set; }
        public int? Juzgado { get; set; }
        public string JuzgadoNombre { get; set; }
        public string Juez { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadDescripcion { get; set; }
        public string Numero_de_Causa { get; set; }
        public string Fecha_de_Oficio { get; set; }
        public int? Tipo_de_Cuantia { get; set; }
        public string Tipo_de_CuantiaDescripcion { get; set; }
        public string Observaciones { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_DelitoModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_AmparoModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Media_FiliacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Cejas { get; set; }
        public string CejasDescripcion { get; set; }
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
        public int? Ojos { get; set; }
        public string OjosDescripcion { get; set; }
        public int? Forma_Ojos { get; set; }
        public string Forma_OjosDescripcion { get; set; }
        public int? Nariz_Base { get; set; }
        public string Nariz_BaseDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
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
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_ProcesoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Libramiento { get; set; }
        public int? Fuerzo { get; set; }
        public string FuerzoDescripcion { get; set; }
        public int? Tipo_Mandato { get; set; }
        public string Tipo_MandatoDescripcion { get; set; }
        public string Numero_de_Proceso_Judicial { get; set; }
        public string Numero_de_Averiguacion { get; set; }
        public string Fecha_de_Captura { get; set; }
        public string Fecha_de_Recepcion { get; set; }
        public string Fecha_de_Prescripcion { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        public string Oficio_de_Cumplimiento { get; set; }
        public string Fecha_de_Cancelacion { get; set; }
        public int? Motivo_de_Cancelacion { get; set; }
        public string Motivo_de_CancelacionDescripcion { get; set; }
        public string Oficio_de_Cancelacion { get; set; }
        public int? Tipo_de_Proceso { get; set; }
        public string Tipo_de_ProcesoDescripcion { get; set; }
        public int? Proceso_de_Extradiccion { get; set; }
        public string Proceso_de_ExtradiccionDescripcion { get; set; }
        public string Observacionesx { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_FotosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_DocumentosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Registro_de_Mandamiento_Judicial_Huellas_DigitalesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Huellas_Digitales { get; set; }
        [Range(0, 9999999999)]
        public int? Mano_Izquierda_dedos { get; set; }
        [Range(0, 9999999999)]
        public int? Mano_Derecha_Pulgar { get; set; }
        [Range(0, 9999999999)]
        public int? Mano_Derecha_Dedos { get; set; }

    }


}

