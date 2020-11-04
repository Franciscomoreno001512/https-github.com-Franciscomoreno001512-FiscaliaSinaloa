using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Corporacion;

namespace Spartane.Web.SqlModelMapper
{
    public class CorporacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Corporacion.Clave";
                case "Clave_Municipio":
                    return "Corporacion.Clave_Municipio";
                case "Clave_Policia":
                    return "Corporacion.Clave_Policia";
                case "Descripcion":
                    return "Corporacion.Descripcion";
                case "Vigencia[Abreviacion]":
                case "VigenciaAbreviacion":
                    return "Vigencia.Abreviacion";
                case "Uso_Vehiculo":
                    return "Corporacion.Uso_Vehiculo";
                case "Observaciones":
                    return "Corporacion.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Corporacion).GetProperty(columnName));
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

