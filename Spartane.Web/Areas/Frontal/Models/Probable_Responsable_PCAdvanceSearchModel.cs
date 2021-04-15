using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Probable_Responsable_PCAdvanceSearchModel
    {
        public Probable_Responsable_PCAdvanceSearchModel()
        {
            Quien_Resulte_Responsable = RadioOptions.NoApply;
            Persona_moral = RadioOptions.NoApply;
            Conoce_los_datos_del_representante_legal = RadioOptions.NoApply;
            Fotografia_de_la_identificacion = RadioOptions.NoApply;
            Imagen_Tatuaje = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        public Filters Tiene_informacion_responsableFilter { set; get; }
        public string AdvanceTiene_informacion_responsable { set; get; }
        public int[] AdvanceTiene_informacion_responsableMultiple { set; get; }

        public RadioOptions Quien_Resulte_Responsable { set; get; }

        public RadioOptions Persona_moral { set; get; }

        public RadioOptions Conoce_los_datos_del_representante_legal { set; get; }

        public Filters Razon_SocialFilter { set; get; }
        public string Razon_Social { set; get; }

        public Filters NombresFilter { set; get; }
        public string Nombres { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string Nombre_Completo { set; get; }

        public Filters AliasFilter { set; get; }
        public string Alias { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Nacimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Nacimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Nacimiento { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad { set; get; }

        public Filters SexoFilter { set; get; }
        public string AdvanceSexo { set; get; }
        public int[] AdvanceSexoMultiple { set; get; }

        public Filters Estado_CivilFilter { set; get; }
        public string AdvanceEstado_Civil { set; get; }
        public int[] AdvanceEstado_CivilMultiple { set; get; }

        public Filters Tipo_de_IdentificacionFilter { set; get; }
        public string AdvanceTipo_de_Identificacion { set; get; }
        public int[] AdvanceTipo_de_IdentificacionMultiple { set; get; }

        public Filters Numero_de_IdentificacionFilter { set; get; }
        public string Numero_de_Identificacion { set; get; }

        public RadioOptions Fotografia_de_la_identificacion { set; get; }

        public Filters CURPFilter { set; get; }
        public string CURP { set; get; }

        public Filters RFCFilter { set; get; }
        public string RFC { set; get; }

        public Filters Tiene_informacion__domicilioFilter { set; get; }
        public string AdvanceTiene_informacion__domicilio { set; get; }
        public int[] AdvanceTiene_informacion__domicilioMultiple { set; get; }

        public Filters PaisFilter { set; get; }
        public string AdvancePais { set; get; }
        public int[] AdvancePaisMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters Calle_del_ImputadoFilter { set; get; }
        public string Calle_del_Imputado { set; get; }

        public Filters Numero_ExteriorFilter { set; get; }
        public string Numero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters Referencia_de_DomicilioFilter { set; get; }
        public string Referencia_de_Domicilio { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

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

        public Filters Imputado_RecluidoFilter { set; get; }
        public string Imputado_Recluido { set; get; }


    }
}
