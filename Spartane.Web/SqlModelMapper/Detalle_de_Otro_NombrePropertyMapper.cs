using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Otro_Nombre;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Otro_NombrePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Otro_Nombre.Clave";
                case "Otro_Nombre_del_Individuo":
                    return "Detalle_de_Otro_Nombre.Otro_Nombre_del_Individuo";
                case "Otro_Apellido_Paterno_del_Individuo":
                    return "Detalle_de_Otro_Nombre.Otro_Apellido_Paterno_del_Individuo";
                case "Otro_Apellido_Materno_del_Individuo":
                    return "Detalle_de_Otro_Nombre.Otro_Apellido_Materno_del_Individuo";
                case "Otro_Alias_del_Individuo":
                    return "Detalle_de_Otro_Nombre.Otro_Alias_del_Individuo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Otro_Nombre).GetProperty(columnName));
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

