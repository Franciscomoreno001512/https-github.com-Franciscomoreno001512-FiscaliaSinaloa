using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Audiencia_Defensor_VictimaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Audiencia_Defensor_Victima.Clave";
                case "Nombre_del_Imputado[Nombre_Completo]":
                case "Nombre_del_ImputadoNombre_Completo":
                    return "Detalle_de_Datos_Generales.Nombre_Completo";
                case "Abogado":
                    return "Detalle_Audiencia_Defensor_Victima.Abogado";
                case "Cedula_Profesional":
                    return "Detalle_Audiencia_Defensor_Victima.Cedula_Profesional";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Audiencia_Defensor_Victima).GetProperty(columnName));
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

