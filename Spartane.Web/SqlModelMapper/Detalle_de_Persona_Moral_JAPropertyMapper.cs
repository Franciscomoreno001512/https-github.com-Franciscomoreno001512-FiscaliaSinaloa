using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Persona_Moral_JA;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Persona_Moral_JAPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Persona_Moral_JA.Clave";
                case "idRegistroAT":
                    return "Detalle_de_Persona_Moral_JA.idRegistroAT";
                case "idRegistroUI":
                    return "Detalle_de_Persona_Moral_JA.idRegistroUI";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Nombre":
                    return "Detalle_de_Persona_Moral_JA.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Persona_Moral_JA.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Persona_Moral_JA.Apellido_Materno";
                case "Calidad_Juridica":
                    return "Detalle_de_Persona_Moral_JA.Calidad_Juridica";
                case "Razon_Social":
                    return "Detalle_de_Persona_Moral_JA.Razon_Social";
                case "CURP":
                    return "Detalle_de_Persona_Moral_JA.CURP";
                case "RFC":
                    return "Detalle_de_Persona_Moral_JA.RFC";
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
                    return "Detalle_de_Persona_Moral_JA.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Persona_Moral_JA.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Persona_Moral_JA.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Persona_Moral_JA.Numero_Interior";
                case "Referencia":
                    return "Detalle_de_Persona_Moral_JA.Referencia";
                case "Latitud":
                    return "Detalle_de_Persona_Moral_JA.Latitud";
                case "Longitud":
                    return "Detalle_de_Persona_Moral_JA.Longitud";
                case "Telefono":
                    return "Detalle_de_Persona_Moral_JA.Telefono";
                case "Extension":
                    return "Detalle_de_Persona_Moral_JA.Extension";
                case "Celular":
                    return "Detalle_de_Persona_Moral_JA.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Persona_Moral_JA.Correo_Electronico";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Persona_Moral_JA).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {


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

