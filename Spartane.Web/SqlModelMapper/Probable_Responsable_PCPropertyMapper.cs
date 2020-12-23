using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Probable_Responsable_PC;

namespace Spartane.Web.SqlModelMapper
{
    public class Probable_Responsable_PCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Probable_Responsable_PC.Clave";
                case "Solicitud[Folio]":
                case "SolicitudFolio":
                    return "Solicitud_de_Denuncia_Ciudadana.Folio";
                case "Tipo_de_Solicitud[Descripcion]":
                case "Tipo_de_SolicitudDescripcion":
                    return "Tipo_de_Solicitud.Descripcion";
                case "Tiene_informacion_responsable[Descripcion]":
                case "Tiene_informacion_responsableDescripcion":
                    return "Respuesta.Descripcion";
                case "Quien_Resulte_Responsable":
                    return "Probable_Responsable_PC.Quien_Resulte_Responsable";
                case "Persona_moral":
                    return "Probable_Responsable_PC.Persona_moral";
                case "Nombres":
                    return "Probable_Responsable_PC.Nombres";
                case "Apellido_Paterno":
                    return "Probable_Responsable_PC.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Probable_Responsable_PC.Apellido_Materno";
                case "Nombre_Completo":
                    return "Probable_Responsable_PC.Nombre_Completo";
                case "Alias":
                    return "Probable_Responsable_PC.Alias";
                case "Fecha_de_Nacimiento":
                    return "Probable_Responsable_PC.Fecha_de_Nacimiento";
                case "Edad":
                    return "Probable_Responsable_PC.Edad";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion":
                    return "Probable_Responsable_PC.Numero_de_Identificacion";
                case "CURP":
                    return "Probable_Responsable_PC.CURP";
                case "RFC":
                    return "Probable_Responsable_PC.RFC";
                case "Tiene_informacion__domicilio[Descripcion]":
                case "Tiene_informacion__domicilioDescripcion":
                    return "Respuesta.Descripcion";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Probable_Responsable_PC.Codigo_Postal";
                case "Calle_del_Imputado":
                    return "Probable_Responsable_PC.Calle_del_Imputado";
                case "Numero_Exterior":
                    return "Probable_Responsable_PC.Numero_Exterior";
                case "Numero_Interior":
                    return "Probable_Responsable_PC.Numero_Interior";
                case "Referencia_de_Domicilio":
                    return "Probable_Responsable_PC.Referencia_de_Domicilio";
                case "Latitud":
                    return "Probable_Responsable_PC.Latitud";
                case "Longitud":
                    return "Probable_Responsable_PC.Longitud";
                case "Peso":
                    return "Probable_Responsable_PC.Peso";
                case "Estatura":
                    return "Probable_Responsable_PC.Estatura";
                case "Padecimiento_de_Enfermedad":
                    return "Probable_Responsable_PC.Padecimiento_de_Enfermedad";
                case "Forma_Cara[Descripcion]":
                case "Forma_CaraDescripcion":
                    return "Forma_Cara.Descripcion";
                case "Tipo_de_Cejas[Descripcion]":
                case "Tipo_de_CejasDescripcion":
                    return "Cejas.Descripcion";
                case "Tamano_de_Cejas[Descripcion]":
                case "Tamano_de_CejasDescripcion":
                    return "Tamano_de_Cejas.Descripcion";
                case "Largo_de_Cabello[Descripcion]":
                case "Largo_de_CabelloDescripcion":
                    return "Largo_de_Cabello.Descripcion";
                case "Cantidad_Cabello[Descripcion]":
                case "Cantidad_CabelloDescripcion":
                    return "Cantidad_Cabello.Descripcion";
                case "Implantacion_Cabello[Descripcion]":
                case "Implantacion_CabelloDescripcion":
                    return "Implantacion_Cabello.Descripcion";
                case "Complexion[Descripcion]":
                case "ComplexionDescripcion":
                    return "Complexion.Descripcion";
                case "Color_Piel[Descrpicion]":
                case "Color_PielDescrpicion":
                    return "Color_Piel.Descrpicion";
                case "Frente[Descripcion]":
                case "FrenteDescripcion":
                    return "Frente.Descripcion";
                case "Forma_Cabello[Descripcion]":
                case "Forma_CabelloDescripcion":
                    return "Forma_Cabello.Descripcion";
                case "Color_Cabello[Descripcion]":
                case "Color_CabelloDescripcion":
                    return "Color_de_Cabello.Descripcion";
                case "Calvicie[Descripcion]":
                case "CalvicieDescripcion":
                    return "Calvicie.Descripcion";
                case "Color_Ojos[Descripcion]":
                case "Color_OjosDescripcion":
                    return "Color_Ojos.Descripcion";
                case "Tamano_de_Ojos[Descripcion]":
                case "Tamano_de_OjosDescripcion":
                    return "Ojos.Descripcion";
                case "Forma_Ojos[Descripcion]":
                case "Forma_OjosDescripcion":
                    return "Froma_Ojos.Descripcion";
                case "Anteojos[Descripcion]":
                case "AnteojosDescripcion":
                    return "Anteojos.Descripcion";
                case "Forma_de_Nariz[Descripcion]":
                case "Forma_de_NarizDescripcion":
                    return "Forma_de_Nariz.Descripcion";
                case "Tamano_Nariz[Descripcion]":
                case "Tamano_NarizDescripcion":
                    return "Nariz_Base.Descripcion";
                case "Labios[Descripcion]":
                case "LabiosDescripcion":
                    return "Labios.Descripcion";
                case "Boca[Descripcion]":
                case "BocaDescripcion":
                    return "Boca.Descripcion";
                case "Grosor_de_Labios[Descripcion]":
                case "Grosor_de_LabiosDescripcion":
                    return "Grosor_de_Labios.Descripcion";
                case "Menton[Descripcion]":
                case "MentonDescripcion":
                    return "Menton.Descripcion";
                case "Forma_de_Menton[Descripcion]":
                case "Forma_de_MentonDescripcion":
                    return "Forma_de_Menton.Descripcion";
                case "Barba[Descripcion]":
                case "BarbaDescripcion":
                    return "Barba.Descripcion";
                case "Forma_Orejas[Descripcion]":
                case "Forma_OrejasDescripcion":
                    return "Forma_Orejas.Descripcion";
                case "Tamano_Orejas[Descripcion]":
                case "Tamano_OrejasDescripcion":
                    return "Tamano_Orejas.Descripcion";
                case "Tipo_Lobulo[Descripcion]":
                case "Tipo_LobuloDescripcion":
                    return "Tipo_Lobulo.Descripcion";
                case "Bigote[Descripcion]":
                case "BigoteDescripcion":
                    return "Bigote.Descripcion";
                case "Senas_Particulares[Descripcion]":
                case "Senas_ParticularesDescripcion":
                    return "Senas_Particulares.Descripcion";
                case "Situacion_Fisica[Descripcion]":
                case "Situacion_FisicaDescripcion":
                    return "Situacion_Fisica.Descripcion";
                case "Otras_Senas_Particulares":
                    return "Probable_Responsable_PC.Otras_Senas_Particulares";
                case "Imputado_Recluido":
                    return "Probable_Responsable_PC.Imputado_Recluido";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Probable_Responsable_PC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Quien_Resulte_Responsable")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Persona_moral")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }


            var operatorCondition = GetOperationType(columnName);
            columnName = GetPropertyName(columnName);

            switch (operatorCondition)
            {
                case SqlOperationType.Contains:
                    return string.IsNullOrEmpty(Convert.ToString(value)) ? "" : columnName + " LIKE '%" + value + "%'";
                case SqlOperationType.Equals:
                    return Convert.ToString(value) == "0" || Convert.ToString(value) == "" ? "" : columnName + "='" + value + "'";

            }
            return null;
        }
    }
}

