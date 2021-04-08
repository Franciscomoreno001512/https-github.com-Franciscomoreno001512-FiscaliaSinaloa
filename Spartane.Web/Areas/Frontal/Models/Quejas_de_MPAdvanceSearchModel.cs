using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Quejas_de_MPAdvanceSearchModel
    {
        public Quejas_de_MPAdvanceSearchModel()
        {
            Imagen_Tatuaje = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters NombresFilter { set; get; }
        public string Nombres { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string Nombre_Completo { set; get; }

        public Filters Correo_ElectronicoFilter { set; get; }
        public string Correo_Electronico { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters PesoFilter { set; get; }
        public string Peso { set; get; }

        public Filters EstaturaFilter { set; get; }
        public string Estatura { set; get; }

        public Filters Padecimiento_de_EnfermedadFilter { set; get; }
        public string Padecimiento_de_Enfermedad { set; get; }

        public Filters Forma_CaraFilter { set; get; }
        public string AdvanceForma_Cara { set; get; }
        public int[] AdvanceForma_CaraMultiple { set; get; }

        public Filters Tipo_de_CejasFilter { set; get; }
        public string AdvanceTipo_de_Cejas { set; get; }
        public int[] AdvanceTipo_de_CejasMultiple { set; get; }

        public Filters Tamano_de_CejasFilter { set; get; }
        public string AdvanceTamano_de_Cejas { set; get; }
        public int[] AdvanceTamano_de_CejasMultiple { set; get; }

        public Filters Largo_de_CabelloFilter { set; get; }
        public string AdvanceLargo_de_Cabello { set; get; }
        public int[] AdvanceLargo_de_CabelloMultiple { set; get; }

        public Filters Cantidad_CabelloFilter { set; get; }
        public string AdvanceCantidad_Cabello { set; get; }
        public int[] AdvanceCantidad_CabelloMultiple { set; get; }

        public Filters Implantacion_CabelloFilter { set; get; }
        public string AdvanceImplantacion_Cabello { set; get; }
        public int[] AdvanceImplantacion_CabelloMultiple { set; get; }

        public Filters ComplexionFilter { set; get; }
        public string AdvanceComplexion { set; get; }
        public int[] AdvanceComplexionMultiple { set; get; }

        public Filters Color_PielFilter { set; get; }
        public string AdvanceColor_Piel { set; get; }
        public int[] AdvanceColor_PielMultiple { set; get; }

        public Filters FrenteFilter { set; get; }
        public string AdvanceFrente { set; get; }
        public int[] AdvanceFrenteMultiple { set; get; }

        public Filters Forma_CabelloFilter { set; get; }
        public string AdvanceForma_Cabello { set; get; }
        public int[] AdvanceForma_CabelloMultiple { set; get; }

        public Filters Color_CabelloFilter { set; get; }
        public string AdvanceColor_Cabello { set; get; }
        public int[] AdvanceColor_CabelloMultiple { set; get; }

        public Filters CalvicieFilter { set; get; }
        public string AdvanceCalvicie { set; get; }
        public int[] AdvanceCalvicieMultiple { set; get; }

        public Filters Color_OjosFilter { set; get; }
        public string AdvanceColor_Ojos { set; get; }
        public int[] AdvanceColor_OjosMultiple { set; get; }

        public Filters Tamano_de_OjosFilter { set; get; }
        public string AdvanceTamano_de_Ojos { set; get; }
        public int[] AdvanceTamano_de_OjosMultiple { set; get; }

        public Filters Forma_OjosFilter { set; get; }
        public string AdvanceForma_Ojos { set; get; }
        public int[] AdvanceForma_OjosMultiple { set; get; }

        public Filters AnteojosFilter { set; get; }
        public string AdvanceAnteojos { set; get; }
        public int[] AdvanceAnteojosMultiple { set; get; }

        public Filters Forma_de_NarizFilter { set; get; }
        public string AdvanceForma_de_Nariz { set; get; }
        public int[] AdvanceForma_de_NarizMultiple { set; get; }

        public Filters Tamano_NarizFilter { set; get; }
        public string AdvanceTamano_Nariz { set; get; }
        public int[] AdvanceTamano_NarizMultiple { set; get; }

        public Filters LabiosFilter { set; get; }
        public string AdvanceLabios { set; get; }
        public int[] AdvanceLabiosMultiple { set; get; }

        public Filters BocaFilter { set; get; }
        public string AdvanceBoca { set; get; }
        public int[] AdvanceBocaMultiple { set; get; }

        public Filters Grosor_de_LabiosFilter { set; get; }
        public string AdvanceGrosor_de_Labios { set; get; }
        public int[] AdvanceGrosor_de_LabiosMultiple { set; get; }

        public Filters MentonFilter { set; get; }
        public string AdvanceMenton { set; get; }
        public int[] AdvanceMentonMultiple { set; get; }

        public Filters Forma_de_MentonFilter { set; get; }
        public string AdvanceForma_de_Menton { set; get; }
        public int[] AdvanceForma_de_MentonMultiple { set; get; }

        public Filters BarbaFilter { set; get; }
        public string AdvanceBarba { set; get; }
        public int[] AdvanceBarbaMultiple { set; get; }

        public Filters Forma_OrejasFilter { set; get; }
        public string AdvanceForma_Orejas { set; get; }
        public int[] AdvanceForma_OrejasMultiple { set; get; }

        public Filters Tamano_OrejasFilter { set; get; }
        public string AdvanceTamano_Orejas { set; get; }
        public int[] AdvanceTamano_OrejasMultiple { set; get; }

        public Filters Tipo_LobuloFilter { set; get; }
        public string AdvanceTipo_Lobulo { set; get; }
        public int[] AdvanceTipo_LobuloMultiple { set; get; }

        public Filters BigoteFilter { set; get; }
        public string AdvanceBigote { set; get; }
        public int[] AdvanceBigoteMultiple { set; get; }

        public Filters Senas_ParticularesFilter { set; get; }
        public string AdvanceSenas_Particulares { set; get; }
        public int[] AdvanceSenas_ParticularesMultiple { set; get; }

        public RadioOptions Imagen_Tatuaje { set; get; }

        public Filters Situacion_FisicaFilter { set; get; }
        public string AdvanceSituacion_Fisica { set; get; }
        public int[] AdvanceSituacion_FisicaMultiple { set; get; }

        public Filters Otras_Senas_ParticularesFilter { set; get; }
        public string Otras_Senas_Particulares { set; get; }

        public Filters Descripcion_de_los_HechosFilter { set; get; }
        public string Descripcion_de_los_Hechos { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_los_Hechos { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_los_Hechos", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_los_Hechos { set; get; }

        public string ToHora_de_los_Hechos { set; get; }
        public string FromHora_de_los_Hechos { set; get; }

        public Filters Municipio_hechosFilter { set; get; }
        public string AdvanceMunicipio_hechos { set; get; }
        public int[] AdvanceMunicipio_hechosMultiple { set; get; }

        public Filters Poblacion_hechosFilter { set; get; }
        public string AdvancePoblacion_hechos { set; get; }
        public int[] AdvancePoblacion_hechosMultiple { set; get; }

        public Filters Colonia_hechosFilter { set; get; }
        public string AdvanceColonia_hechos { set; get; }
        public int[] AdvanceColonia_hechosMultiple { set; get; }

        public Filters Calle_hechosFilter { set; get; }
        public string Calle_hechos { set; get; }

        public Filters Entre_Calle_hechosFilter { set; get; }
        public string Entre_Calle_hechos { set; get; }

        public Filters Y_Calle_hechosFilter { set; get; }
        public string Y_Calle_hechos { set; get; }

        public Filters Numero_Exterior_hechosFilter { set; get; }
        public string Numero_Exterior_hechos { set; get; }

        public Filters Numero_Interior_hechosFilter { set; get; }
        public string Numero_Interior_hechos { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_hechos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_hechos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_hechos { set; get; }

        public Filters ReferenciaFilter { set; get; }
        public string Referencia { set; get; }

        public Filters CURP_IdentificacionFilter { set; get; }
        public string CURP_Identificacion { set; get; }

        public Filters Nombres_IdentificacionFilter { set; get; }
        public string Nombres_Identificacion { set; get; }

        public Filters Apellido_Paterno_IdentificacionFilter { set; get; }
        public string Apellido_Paterno_Identificacion { set; get; }

        public Filters Apellido_Materno_IdentificacionFilter { set; get; }
        public string Apellido_Materno_Identificacion { set; get; }

        public Filters AliasFilter { set; get; }
        public string Alias { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Nacimiento_Identificacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Nacimiento_Identificacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Nacimiento_Identificacion { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad_Identificacion { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad_Identificacion", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad_Identificacion { set; get; }

        public Filters Genero_IdentificacionFilter { set; get; }
        public string AdvanceGenero_Identificacion { set; get; }
        public int[] AdvanceGenero_IdentificacionMultiple { set; get; }

        public Filters Celular_IdentificacionFilter { set; get; }
        public string Celular_Identificacion { set; get; }

        public Filters Correo_IdentificacionFilter { set; get; }
        public string Correo_Identificacion { set; get; }

        public Filters Tipo_de_Identificacion_IdentificacionFilter { set; get; }
        public string AdvanceTipo_de_Identificacion_Identificacion { set; get; }
        public int[] AdvanceTipo_de_Identificacion_IdentificacionMultiple { set; get; }

        public Filters Numero_Identificacion_IdentificacionFilter { set; get; }
        public string Numero_Identificacion_Identificacion { set; get; }

        public Filters Nacionalidad_IdentificacionFilter { set; get; }
        public string AdvanceNacionalidad_Identificacion { set; get; }
        public int[] AdvanceNacionalidad_IdentificacionMultiple { set; get; }

        public Filters Entidad_de_Nacimiento_IdentificacionFilter { set; get; }
        public string AdvanceEntidad_de_Nacimiento_Identificacion { set; get; }
        public int[] AdvanceEntidad_de_Nacimiento_IdentificacionMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        public Filters CalleFilter { set; get; }
        public string Calle { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters Y_CalleFilter { set; get; }
        public string Y_Calle { set; get; }

        public Filters Numero_ExteriorFilter { set; get; }
        public string Numero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters Codigo_PostalFilter { set; get; }
        public string Codigo_Postal { set; get; }

        public Filters Referencias_de_domicilioFilter { set; get; }
        public string Referencias_de_domicilio { set; get; }


    }
}
