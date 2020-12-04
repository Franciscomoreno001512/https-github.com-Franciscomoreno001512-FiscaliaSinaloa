using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria;

namespace Spartane.Web.SqlModelMapper
{
    public class Plazo_de_Investigacion_ComplementariaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Plazo_de_Investigacion_Complementaria.Clave";
                case "Descripcion":
                    return "Plazo_de_Investigacion_Complementaria.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Plazo_de_Investigacion_Complementaria).GetProperty(columnName));
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

