using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Otros_Domicilios_Involucrado;

namespace Spartane.Web.SqlModelMapper
{
    public class Otros_Domicilios_InvolucradoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Otros_Domicilios_Involucrado.Clave";
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
                    return "Otros_Domicilios_Involucrado.Codigo_Postal";
                case "Calle":
                    return "Otros_Domicilios_Involucrado.Calle";
                case "Entre_Calle":
                    return "Otros_Domicilios_Involucrado.Entre_Calle";
                case "Y_Calle":
                    return "Otros_Domicilios_Involucrado.Y_Calle";
                case "Numero_Exterior":
                    return "Otros_Domicilios_Involucrado.Numero_Exterior";
                case "Numero_Interior":
                    return "Otros_Domicilios_Involucrado.Numero_Interior";
                case "Coordenada_X":
                    return "Otros_Domicilios_Involucrado.Coordenada_X";
                case "Coordenada_Y":
                    return "Otros_Domicilios_Involucrado.Coordenada_Y";
                case "Observaciones":
                    return "Otros_Domicilios_Involucrado.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Otros_Domicilios_Involucrado).GetProperty(columnName));
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

