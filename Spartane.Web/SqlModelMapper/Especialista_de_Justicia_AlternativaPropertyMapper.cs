using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Especialista_de_Justicia_Alternativa;

namespace Spartane.Web.SqlModelMapper
{
    public class Especialista_de_Justicia_AlternativaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Especialista_de_Justicia_Alternativa.Clave";
                case "Numero_de_Empleado":
                    return "Especialista_de_Justicia_Alternativa.Numero_de_Empleado";
                case "Nombre_de_Especialista":
                    return "Especialista_de_Justicia_Alternativa.Nombre_de_Especialista";
                case "Carga_de_Trabajo":
                    return "Especialista_de_Justicia_Alternativa.Carga_de_Trabajo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Especialista_de_Justicia_Alternativa).GetProperty(columnName));
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

