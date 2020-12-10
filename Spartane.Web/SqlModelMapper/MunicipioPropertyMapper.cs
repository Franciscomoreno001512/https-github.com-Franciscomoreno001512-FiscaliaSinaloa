using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Municipio;

namespace Spartane.Web.SqlModelMapper
{
    public class MunicipioPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Municipio.Clave";
                case "Nombre":
                    return "Municipio.Nombre";
                case "Abreviacion":
                    return "Municipio.Abreviacion";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Vigencia[Abreviacion]":
                case "VigenciaAbreviacion":
                    return "Vigencia.Abreviacion";
                case "Observaciones":
                    return "Municipio.Observaciones";
                case "cod_pais":
                    return "Municipio.cod_pais";
                case "cod_zona":
                    return "Municipio.cod_zona";
                case "MuniNSJP":
                    return "Municipio.MuniNSJP";
                case "cod_zona_nsjp":
                    return "Municipio.cod_zona_nsjp";
                case "cod_mun":
                    return "Municipio.cod_mun";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Municipio).GetProperty(columnName));
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

